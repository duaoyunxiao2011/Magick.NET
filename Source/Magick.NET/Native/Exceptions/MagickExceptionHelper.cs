//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://magick.codeplex.com/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   http://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================
// <auto-generated/>

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

#if Q8
using QuantumType = System.Byte;
#elif Q16
using QuantumType = System.UInt16;
#elif Q16HDRI
using QuantumType = System.Single;
#else
#error Not implemented!
#endif

namespace ImageMagick
{
  internal static partial class MagickExceptionHelper
  {
    private static class NativeMethods
    {
      #if WIN64 || ANYCPU
      public static class X64
      {
        #if ANYCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickExceptionHelper+NativeMethods.X64#.cctor()")]
        static X64() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Description(IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickExceptionHelper_Dispose(IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Message(IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Related(IntPtr exception, UIntPtr index);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickExceptionHelper_RelatedCount(IntPtr exception);
        [DllImport(NativeLibrary.X64Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickExceptionHelper_Severity(IntPtr exception);
      }
      #endif
      #if !WIN64 || ANYCPU
      public static class X86
      {
        #if ANYCPU
        [SuppressMessage("Microsoft.Performance", "CA1810: InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "ImageMagick.MagickExceptionHelper+NativeMethods.X86#.cctor()")]
        static X86() { NativeLibraryLoader.Load(); }
        #endif
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Description(IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern void MagickExceptionHelper_Dispose(IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Message(IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr MagickExceptionHelper_Related(IntPtr exception, UIntPtr index);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickExceptionHelper_RelatedCount(IntPtr exception);
        [DllImport(NativeLibrary.X86Name, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr MagickExceptionHelper_Severity(IntPtr exception);
      }
      #endif
    }
    private static class NativeMagickExceptionHelper
    {
      public static string Description(IntPtr exception)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return UTF8Marshaler.NativeToManaged(NativeMethods.X64.MagickExceptionHelper_Description(exception));
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return UTF8Marshaler.NativeToManaged(NativeMethods.X86.MagickExceptionHelper_Description(exception));
        #endif
      }
      public static void Dispose(IntPtr exception)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        NativeMethods.X64.MagickExceptionHelper_Dispose(exception);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        NativeMethods.X86.MagickExceptionHelper_Dispose(exception);
        #endif
      }
      public static string Message(IntPtr exception)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return UTF8Marshaler.NativeToManaged(NativeMethods.X64.MagickExceptionHelper_Message(exception));
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return UTF8Marshaler.NativeToManaged(NativeMethods.X86.MagickExceptionHelper_Message(exception));
        #endif
      }
      public static IntPtr Related(IntPtr exception, int index)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return NativeMethods.X64.MagickExceptionHelper_Related(exception, (UIntPtr)index);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return NativeMethods.X86.MagickExceptionHelper_Related(exception, (UIntPtr)index);
        #endif
      }
      public static int RelatedCount(IntPtr exception)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return (int)NativeMethods.X64.MagickExceptionHelper_RelatedCount(exception);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return (int)NativeMethods.X86.MagickExceptionHelper_RelatedCount(exception);
        #endif
      }
      public static int Severity(IntPtr exception)
      {
        #if ANYCPU
        if (NativeLibrary.Is64Bit)
        #endif
        #if WIN64 || ANYCPU
        return (int)NativeMethods.X64.MagickExceptionHelper_Severity(exception);
        #endif
        #if ANYCPU
        else
        #endif
        #if !WIN64 || ANYCPU
        return (int)NativeMethods.X86.MagickExceptionHelper_Severity(exception);
        #endif
      }
    }
  }
}