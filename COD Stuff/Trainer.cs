using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCUN
{
    class Trainer
    {
      
        //Credits:
        //Jorndel < Created original class
        //Me < Edited it a lot. Added new fetures
        //SamTheDope < Being dope

        #region -----Main-----
        //Dll Inports
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UInt32 dwSize, uint flNewProtect, out uint lpflOldProtect);

        [DllImport("kernel32.dll")]
        private static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        private static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);

        //Storing ProcessName
        IntPtr pHandel;
        Process attachedProcess = null;

        //Attching process
        public bool Process_Handle(string ProcessName)
        {
            try
            {
                Process[] ProcList = Process.GetProcessesByName(ProcessName);
                if (ProcList.Length == 0)
                    return false;
                else
                {
                    attachedProcess = ProcList[0];
                    pHandel = ProcList[0].Handle;
                    return true;
                }
            }
            catch (Exception ex) { SetLastError(ex); return false; }
        }

        #endregion
        #region 32 bit
        #region Basic Stuff
        private byte[] Read32(int Address, int Length)
        {
            byte[] Buffer = new byte[Length];
            IntPtr Zero = IntPtr.Zero;
            ReadProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
            return Buffer;
        }

        private void Write32(int Address, int Value)
        {
            byte[] Buffer = BitConverter.GetBytes(Value);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        #endregion
        #region Write Functions
        public void WriteDouble32(int Address, double value)
        {
            byte[] Buffer = BitConverter.GetBytes(value);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        public void WriteInteger(int Address, int Value)
        {
            Write32(Address, Value);
        }

        public void WriteString32(int Address, string Text)
        {
            byte[] Buffer = new ASCIIEncoding().GetBytes(Text);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        public void WriteBytes32(int Address, byte[] Bytes)
        {
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out Zero);
        }

        public void WriteNOP32(int Address, int nopLength)
        {
            byte[] Buffer = new byte[nopLength];
            for (int i = 0; i < nopLength; i++)
                Buffer[i] = (byte)0x90;
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        private void WriteFloat32(int Address, float Value)
        {
            byte[] Buffer = BitConverter.GetBytes(Value);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        public void WriteFloat_Protected32(int Address, float Value)
        {
            uint OldProtection;
            VirtualProtectEx(pHandel, (IntPtr)Address, (uint)sizeof(float), 0x40, out OldProtection);
            WriteFloat32(Address, Value);
            VirtualProtectEx(pHandel, (IntPtr)Address, (uint)sizeof(float), OldProtection, out OldProtection);
        }
        #endregion
        #region Read Functions
        public int ReadInteger32(int Address, int Length = 4)
        {
            return BitConverter.ToInt32(Read32(Address, Length), 0);
        }

        public float ReadFloat32(int address)
        {
            return BitConverter.ToSingle(ReadBytes32(address, 8), 0);
        }

        public string ReadString32(int Address, int Length = 4)
        {
            return new ASCIIEncoding().GetString(Read32(Address, Length));
        }

        public byte[] ReadBytes32(int Address, int Length)
        {
            return Read32(Address, Length);
        }

        public double ReadDouble32(int address)
        {
            byte[] buffer = new byte[sizeof(double)];
            IntPtr Zero = IntPtr.Zero;
            ReadProcessMemory(pHandel, (IntPtr)address, buffer, (UInt32)buffer.Length, out Zero);
            return BitConverter.ToDouble(buffer, 0);
        }
        #endregion
        #region Advance
        //Don't use hex
        //Example: PatternScanXX("0 255 212 53 ?? 53 74 ?? 86 ?? ?? 12 ??")
        public int PatternScan32(string pattern, bool mainModule = true)
        {
            string[] splitPattern = pattern.Split(' ');
            bool[] indexValid = new bool[splitPattern.Length];
            byte[] indexValue = new byte[splitPattern.Length];

            byte tempByte = (byte)0x00;

            for (int i = 0; i < splitPattern.Length; i++)
            {
                indexValid[i] = !(splitPattern[i] == "??" || splitPattern[i] == "?");
                if (Byte.TryParse(splitPattern[i], out tempByte))
                    indexValue[i] = tempByte;
                else
                    indexValid[i] = false;
            }


            //searching memory part
            int startOfMemory = 0;
            int endOfMemory = 0;

            if (mainModule)
            {
                startOfMemory = attachedProcess.MainModule.BaseAddress.ToInt32();
                endOfMemory = attachedProcess.MainModule.ModuleMemorySize;
            }
            else
            {
                for (int i = 0; i < attachedProcess.Modules.Count; i++)
                    endOfMemory += attachedProcess.Modules[i].ModuleMemorySize;
            }

            for (int currentMemAddy = startOfMemory; currentMemAddy < endOfMemory; currentMemAddy++)
            {
                bool complete = false;
                for (int i = 0; i < splitPattern.Length; i++)
                {
                    if (!indexValid[i])
                        continue;

                    tempByte = ReadBytes32(currentMemAddy + i, 1)[0];

                    if (tempByte != indexValue[i])
                        break;

                    if (i == splitPattern.Length - 1)
                        complete = true;

                    if (complete)
                        break;
                }

                if (complete)
                    return currentMemAddy;
            }

            throw new Exception("Pattern not found!");
            return 0;
        }
        #endregion
        #endregion
        #region 64 Bit
        #region Basic Stuff
        private byte[] Read64(long Address, int Length)
        {
            byte[] Buffer = new byte[Length];
            IntPtr Zero = IntPtr.Zero;
            ReadProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
            return Buffer;
        }

        private void Write64(long Address, int Value)
        {
            byte[] Buffer = BitConverter.GetBytes(Value);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        #endregion
        #region Write Function
        public void WriteInteger64(long Address, int Value)
        {
            Write64(Address, Value);
        }

        public void WriteString64(long Address, string Text)
        {
            byte[] Buffer = new ASCIIEncoding().GetBytes(Text);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        public void WriteBytes64(long Address, byte[] Bytes)
        {
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out Zero);
        }

        public void WriteNOP64(long Address)
        {
            byte[] Buffer = new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 };
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        public void WriteFloat64(long Address, float Float)
        {
            byte[] Buffer = BitConverter.GetBytes(Float);
            IntPtr Zero = IntPtr.Zero;
            WriteProcessMemory(pHandel, (IntPtr)Address, Buffer, (UInt32)Buffer.Length, out Zero);
        }

        #endregion
        #region Read Functions
        public int ReadInteger64(long Address, int Length = 4)
        {
            return BitConverter.ToInt32(Read64(Address, Length), 0);
        }

        public string ReadString64(long Address, int Length = 4)
        {
            return new ASCIIEncoding().GetString(Read64(Address, Length));
        }

        public byte[] ReadBytes64(long Address, int Length)
        {
            return Read64(Address, Length);
        }

        #endregion
        #endregion
        #region Advanced
        /// <summary>
        /// This will read the hole string until it's ended.
        /// Notes:
        /// This isn't the fastest method
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// 


        //public string ReadString_Advanced32(int offset)
        //{
        //    string output = null;

        //    int i = 0;
        //    while (true)
        //    {
        //        byte[] currentByteRead = ReadBytes32(offset + i, 1);
        //        char currentCharRead = Encoding.ASCII.GetChars(currentByteRead)[0];

        //        //Check is valid char
        //        if (IsValidChar(currentCharRead))
        //            output += currentCharRead.ToString();
        //        else
        //            break;

        //        i++;

        //        if (i > 10000)//You need some sort of limit
        //            break;
        //    }

        //    return output;
        //}


        /// <summary>
        /// This will read the hole string until it's ended.
        /// Notes:
        /// This isn't the fastest method
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// 

        //public string ReadString_Advanced64(long offset)
        //{
        //    string output = null;

        //    int i = 0;
        //    while (true)
        //    {
        //        byte[] currentByteRead = ReadBytes64(offset + i, 1);
        //        char currentCharRead = Encoding.ASCII.GetChars(currentByteRead)[0];

        //        //Check is valid char
        //        if (IsValidChar(currentCharRead))
        //            output += currentCharRead.ToString();
        //        else
        //            break;

        //        i++;

        //        if (i > 10000)
        //            break;
        //    }

        //    return output;
        //}
        #endregion


        #region Misc
        #region Error Handling
        private string lastError = null;

        public string GetLastError()
        {
            return lastError;
        }

        private void SetLastError(string error)
        {
            lastError = error;
        }

        private void SetLastError(Exception error)
        {
            lastError = error.ToString();
        }
        #endregion
        //#region Char Checks - Used for "ReadString_Advanced"
        //char[] validCharList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()_+-=` ".ToArray();//All the valid ascii chars I could think of

        //private bool IsValidChar(char toCheckVar)
        //{
        //    toCheckVar = ((toCheckVar.ToString()).ToLower()).ToCharArray()[0];
        //    for (int i = 0; i < validCharList.Length; i++)
        //        if (toCheckVar == validCharList[i])
        //            return true;
        //    return false;
        //}
        //#endregion
        #endregion
    }
}
