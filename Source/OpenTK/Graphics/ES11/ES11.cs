//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



namespace OpenTK.Graphics.ES11
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591
    #pragma warning disable 1572
    #pragma warning disable 1573

    partial class GL
    {

        public static partial class Apple
        {
            /// <summary>[requires: APPLE_sync]
            /// Block and wait for a sync object to become signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.
            /// </para>
            /// </param>
            public static 
            OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, Int32 flags, Int64 timeout)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glClientWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Block and wait for a sync object to become signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            OpenTK.Graphics.ES11.All ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glClientWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            public static 
            void CopyTextureLevel(Int32 destinationTexture, Int32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glCopyTextureLevelsAPPLE((UInt32)destinationTexture, (UInt32)sourceTexture, (Int32)sourceBaseLevel, (Int32)sourceLevelCount);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_copy_texture_levels]</summary>
            [System.CLSCompliant(false)]
            public static 
            void CopyTextureLevel(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glCopyTextureLevelsAPPLE((UInt32)destinationTexture, (UInt32)sourceTexture, (Int32)sourceBaseLevel, (Int32)sourceLevelCount);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Delete a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// The sync object to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteSync(IntPtr sync)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteSyncAPPLE((IntPtr)sync);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Create a new sync object and insert it into the GL command stream
            /// </summary>
            /// <param name="condition">
            /// <para>
            /// Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities.
            /// </para>
            /// </param>
            public static 
            IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, Int32 flags)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glFenceSyncAPPLE((OpenTK.Graphics.ES11.All)condition, (UInt32)flags);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Create a new sync object and insert it into the GL command stream
            /// </summary>
            /// <param name="condition">
            /// <para>
            /// Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero. flags is a placeholder for anticipated future extensions of fence sync object capabilities.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            IntPtr FenceSync(OpenTK.Graphics.ES11.All condition, UInt32 flags)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glFenceSyncAPPLE((OpenTK.Graphics.ES11.All)condition, (UInt32)flags);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]</summary>
            public static 
            void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int64* @params_ptr = @params)
                    {
                        Delegates.glGetInteger64vAPPLE((OpenTK.Graphics.ES11.All)pname, (Int64*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]</summary>
            public static 
            void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int64 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int64* @params_ptr = &@params)
                    {
                        Delegates.glGetInteger64vAPPLE((OpenTK.Graphics.ES11.All)pname, (Int64*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetInteger64(OpenTK.Graphics.ES11.All pname, [OutAttribute] Int64* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetInteger64vAPPLE((OpenTK.Graphics.ES11.All)pname, (Int64*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            public static 
            void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = length)
                    fixed (Int32* values_ptr = values)
                    {
                        Delegates.glGetSyncivAPPLE((IntPtr)sync, (OpenTK.Graphics.ES11.All)pname, (Int32)bufSize, (Int32*)length_ptr, (Int32*)values_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            public static 
            void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] out Int32 values)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = &length)
                    fixed (Int32* values_ptr = &values)
                    {
                        Delegates.glGetSyncivAPPLE((IntPtr)sync, (OpenTK.Graphics.ES11.All)pname, (Int32)bufSize, (Int32*)length_ptr, (Int32*)values_ptr);
                        length = *length_ptr;
                        values = *values_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Query the properties of a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose properties to query.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the sync object specified in sync.
            /// </para>
            /// </param>
            /// <param name="bufSize">
            /// <para>
            /// Specifies the size of the buffer whose address is given in values.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the address of an variable to receive the number of integers placed in values.
            /// </para>
            /// </param>
            /// <param name="values">
            /// <para>
            /// Specifies the address of an array to receive the values of the queried parameter.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetSync(IntPtr sync, OpenTK.Graphics.ES11.All pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetSyncivAPPLE((IntPtr)sync, (OpenTK.Graphics.ES11.All)pname, (Int32)bufSize, (Int32*)length, (Int32*)values);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Determine if a name corresponds to a sync object
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies a value that may be the name of a sync object.
            /// </para>
            /// </param>
            public static 
            bool IsSync(IntPtr sync)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsSyncAPPLE((IntPtr)sync);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_framebuffer_multisample]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            public static 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRenderbufferStorageMultisampleAPPLE((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_framebuffer_multisample]</summary>
            public static 
            void ResolveMultisampleFramebuffer()
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glResolveMultisampleFramebufferAPPLE();
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Instruct the GL server to block until the specified sync object becomes signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be zero.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.
            /// </para>
            /// </param>
            public static 
            void WaitSync(IntPtr sync, Int32 flags, Int64 timeout)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: APPLE_sync]
            /// Instruct the GL server to block until the specified sync object becomes signaled
            /// </summary>
            /// <param name="sync">
            /// <para>
            /// Specifies the sync object whose status to wait on.
            /// </para>
            /// </param>
            /// <param name="flags">
            /// <para>
            /// A bitfield controlling the command flushing behavior. flags may be zero.
            /// </para>
            /// </param>
            /// <param name="timeout">
            /// <para>
            /// Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glWaitSyncAPPLE((IntPtr)sync, (UInt32)flags, (UInt64)timeout);
                #if DEBUG
                }
                #endif
            }

        }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        public static 
        void ActiveTexture(OpenTK.Graphics.ES11.All texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glActiveTexture((OpenTK.Graphics.ES11.All)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the alpha test function
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the alpha comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0,1], where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
        /// </para>
        /// </param>
        public static 
        void AlphaFunc(OpenTK.Graphics.ES11.AlphaFunction func, Single @ref)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glAlphaFunc((OpenTK.Graphics.ES11.AlphaFunction)func, (Single)@ref);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glAlphaFuncx((OpenTK.Graphics.ES11.All)func, (int)@ref);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="buffer">
        /// <para>
        /// Specifies the name of a buffer object.
        /// </para>
        /// </param>
        public static 
        void BindBuffer(OpenTK.Graphics.ES11.All target, Int32 buffer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBindBuffer((OpenTK.Graphics.ES11.All)target, (UInt32)buffer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Bind a named buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the buffer object is bound. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="buffer">
        /// <para>
        /// Specifies the name of a buffer object.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void BindBuffer(OpenTK.Graphics.ES11.All target, UInt32 buffer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBindBuffer((OpenTK.Graphics.ES11.All)target, (UInt32)buffer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        public static 
        void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, Int32 texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBindTexture((OpenTK.Graphics.ES11.TextureTarget)target, (UInt32)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Bind a named texture to a texturing target
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
        /// </para>
        /// </param>
        /// <param name="texture">
        /// <para>
        /// Specifies the name of a texture.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void BindTexture(OpenTK.Graphics.ES11.TextureTarget target, UInt32 texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBindTexture((OpenTK.Graphics.ES11.TextureTarget)target, (UInt32)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify pixel arithmetic
        /// </summary>
        /// <param name="buf">
        /// <para>
        /// For glBlendFunci, specifies the index of the draw buffer for which to set the blend function.
        /// </para>
        /// </param>
        /// <param name="sfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE.
        /// </para>
        /// </param>
        /// <param name="dfactor">
        /// <para>
        /// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO.
        /// </para>
        /// </param>
        public static 
        void BlendFunc(OpenTK.Graphics.ES11.BlendingFactorSrc sfactor, OpenTK.Graphics.ES11.BlendingFactorDest dfactor)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBlendFunc((OpenTK.Graphics.ES11.BlendingFactorSrc)sfactor, (OpenTK.Graphics.ES11.BlendingFactorDest)dfactor);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        public static 
        void BufferData(OpenTK.Graphics.ES11.All target, IntPtr size, IntPtr data, OpenTK.Graphics.ES11.All usage)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data, (OpenTK.Graphics.ES11.All)usage);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        public static 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject(), (OpenTK.Graphics.ES11.All)usage);
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        public static 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject(), (OpenTK.Graphics.ES11.All)usage);
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        public static 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] T2[,,] data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject(), (OpenTK.Graphics.ES11.All)usage);
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Creates and initializes a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the buffer object's new data store.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be copied.
        /// </para>
        /// </param>
        /// <param name="usage">
        /// <para>
        /// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
        /// </para>
        /// </param>
        public static 
        void BufferData<T2>(OpenTK.Graphics.ES11.All target, IntPtr size, [InAttribute, OutAttribute] ref T2 data, OpenTK.Graphics.ES11.All usage)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferData((OpenTK.Graphics.ES11.All)target, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject(), (OpenTK.Graphics.ES11.All)usage);
                data = (T2)data_ptr.Target;
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        public static 
        void BufferSubData(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, IntPtr data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        public static 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        public static 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,] data)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        public static 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[,,] data)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Updates a subset of a buffer object's data store
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
        /// </para>
        /// </param>
        /// <param name="offset">
        /// <para>
        /// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
        /// </para>
        /// </param>
        /// <param name="size">
        /// <para>
        /// Specifies the size in bytes of the data store region being replaced.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the new data that will be copied into the data store.
        /// </para>
        /// </param>
        public static 
        void BufferSubData<T3>(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T3 data)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glBufferSubData((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)size, (IntPtr)data_ptr.AddrOfPinnedObject());
                data = (T3)data_ptr.Target;
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Clear buffers to preset values
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
        /// </para>
        /// </param>
        public static 
        void Clear(OpenTK.Graphics.ES11.ClearBufferMask mask)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClear((OpenTK.Graphics.ES11.ClearBufferMask)mask);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify clear values for the color buffers
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
        /// </para>
        /// </param>
        public static 
        void ClearColor(Single red, Single green, Single blue, Single alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClearColor((Single)red, (Single)green, (Single)blue, (Single)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void ClearColorx(int red, int green, int blue, int alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClearColorx((int)red, (int)green, (int)blue, (int)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the depth buffer
        /// </summary>
        /// <param name="depth">
        /// <para>
        /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
        /// </para>
        /// </param>
        public static 
        void ClearDepth(Single d)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClearDepthf((Single)d);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void ClearDepthx(int depth)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClearDepthx((int)depth);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the clear value for the stencil buffer
        /// </summary>
        /// <param name="s">
        /// <para>
        /// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ClearStencil(Int32 s)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClearStencil((Int32)s);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Select active texture unit
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least two. texture must be one of GL_TEXTURE, where i ranges from 0 to the value of GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value. The initial value is GL_TEXTURE0.
        /// </para>
        /// </param>
        public static 
        void ClientActiveTexture(OpenTK.Graphics.ES11.All texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClientActiveTexture((OpenTK.Graphics.ES11.All)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        public static 
        void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* eqn_ptr = eqn)
                {
                    Delegates.glClipPlanef((OpenTK.Graphics.ES11.All)p, (Single*)eqn_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        public static 
        void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* eqn_ptr = &eqn)
                {
                    Delegates.glClipPlanef((OpenTK.Graphics.ES11.All)p, (Single*)eqn_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a plane against which all geometry is clipped
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClipPlanef((OpenTK.Graphics.ES11.All)p, (Single*)eqn);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* equation_ptr = equation)
                {
                    Delegates.glClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* equation_ptr = &equation)
                {
                    Delegates.glClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify new red, green, and blue values for the current color.
        /// </para>
        /// </param>
        /// <param name="alpha">
        /// <para>
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </para>
        /// </param>
        public static 
        void Color4(Single red, Single green, Single blue, Single alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glColor4f((Single)red, (Single)green, (Single)blue, (Single)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the current color
        /// </summary>
        /// <param name="red">
        /// <para>
        /// Specify new red, green, and blue values for the current color.
        /// </para>
        /// </param>
        /// <param name="alpha">
        /// <para>
        /// Specifies a new alpha value for the current color. Included only in the four-argument glColor4 commands.
        /// </para>
        /// </param>
        public static 
        void Color4(Byte red, Byte green, Byte blue, Byte alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glColor4ub((Byte)red, (Byte)green, (Byte)blue, (Byte)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Color4x(int red, int green, int blue, int alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glColor4x((int)red, (int)green, (int)blue, (int)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="buf">
        /// <para>
        /// For glColorMaski, specifies the index of the draw buffer whose color mask to set.
        /// </para>
        /// </param>
        /// <param name="red">
        /// <para>
        /// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.
        /// </para>
        /// </param>
        public static 
        void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glColorMask((bool)red, (bool)green, (bool)blue, (bool)alpha);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ColorPointer(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, IntPtr pointer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of colors
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of components per color. Must be 3 or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each color component in the array. Symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, GL_UNSIGNED_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void ColorPointer<T3>(Int32 size, OpenTK.Graphics.ES11.ColorPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glColorPointer((Int32)size, (OpenTK.Graphics.ES11.ColorPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                pointer = (T3)pointer_ptr.Target;
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[] data)
            where T7 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,] data)
            where T7 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] T7[,,] data)
            where T7 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image. All implementations support 2D texture and cube map texture images that are at least 16384 texels high.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexImage2D<T7>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, [InAttribute, OutAttribute] ref T7 data)
            where T7 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)border, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                data = (T7)data_ptr.Target;
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, IntPtr data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[] data)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,] data)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] T8[,,] data)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage in a compressed format
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the compressed image data stored at address data.
        /// </para>
        /// </param>
        /// <param name="imageSize">
        /// <para>
        /// Specifies the number of unsigned bytes of image data starting at the address specified by data.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the compressed image data in memory.
        /// </para>
        /// </param>
        public static 
        void CompressedTexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, Int32 imageSize, [InAttribute, OutAttribute] ref T8 data)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
            try
            {
                Delegates.glCompressedTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (Int32)imageSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                data = (T8)data_ptr.Target;
            }
            finally
            {
                data_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Copy pixels into a 2D texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="internalformat">
        /// <para>
        /// Specifies the internal format of the texture. Must be one of the following symbolic constants: GL_COMPRESSED_RED, GL_COMPRESSED_RG, GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, GL_COMPRESSED_SRGB_ALPHA. GL_DEPTH_COMPONENT, GL_DEPTH_COMPONENT16, GL_DEPTH_COMPONENT24, GL_DEPTH_COMPONENT32, GL_STENCIL_INDEX8, GL_RED, GL_RG, GL_RGB, GL_R3_G3_B2, GL_RGB4, GL_RGB5, GL_RGB8, GL_RGB10, GL_RGB12, GL_RGB16, GL_RGBA, GL_RGBA2, GL_RGBA4, GL_RGB5_A1, GL_RGBA8, GL_RGB10_A2, GL_RGBA12, GL_RGBA16, GL_SRGB, GL_SRGB8, GL_SRGB_ALPHA, or GL_SRGB8_ALPHA8.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// Must be 0.
        /// </para>
        /// </param>
        public static 
        void CopyTexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, OpenTK.Graphics.ES11.All internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glCopyTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (OpenTK.Graphics.ES11.All)internalformat, (Int32)x, (Int32)y, (Int32)width, (Int32)height, (Int32)border);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Copy a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        public static 
        void CopyTexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glCopyTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)x, (Int32)y, (Int32)width, (Int32)height);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
        /// </para>
        /// </param>
        public static 
        void CullFace(OpenTK.Graphics.ES11.CullFaceMode mode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glCullFace((OpenTK.Graphics.ES11.CullFaceMode)mode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteBuffer(Int32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                UInt32* buffers_ptr = (UInt32*)&buffers;
                Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteBuffer(UInt32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                UInt32* buffers_ptr = (UInt32*)&buffers;
                Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteBuffers(Int32 n, Int32[] buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* buffers_ptr = buffers)
                {
                    Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteBuffers(Int32 n, ref Int32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* buffers_ptr = &buffers)
                {
                    Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void DeleteBuffers(Int32 n, Int32* buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteBuffers(Int32 n, UInt32[] buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* buffers_ptr = buffers)
                {
                    Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteBuffers(Int32 n, ref UInt32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* buffers_ptr = &buffers)
                {
                    Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named buffer objects
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer objects to be deleted.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array of buffer objects to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void DeleteBuffers(Int32 n, UInt32* buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDeleteBuffers((Int32)n, (UInt32*)buffers);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteTexture(Int32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                UInt32* textures_ptr = (UInt32*)&textures;
                Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteTexture(UInt32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                UInt32* textures_ptr = (UInt32*)&textures;
                Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteTextures(Int32 n, Int32[] textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* textures_ptr = textures)
                {
                    Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        public static 
        void DeleteTextures(Int32 n, ref Int32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* textures_ptr = &textures)
                {
                    Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void DeleteTextures(Int32 n, Int32* textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDeleteTextures((Int32)n, (UInt32*)textures);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteTextures(Int32 n, UInt32[] textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* textures_ptr = textures)
                {
                    Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void DeleteTextures(Int32 n, ref UInt32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* textures_ptr = &textures)
                {
                    Delegates.glDeleteTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Delete named textures
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of textures to be deleted.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array of textures to be deleted.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void DeleteTextures(Int32 n, UInt32* textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDeleteTextures((Int32)n, (UInt32*)textures);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
        /// </para>
        /// </param>
        public static 
        void DepthFunc(OpenTK.Graphics.ES11.DepthFunction func)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDepthFunc((OpenTK.Graphics.ES11.DepthFunction)func);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="flag">
        /// <para>
        /// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
        /// </para>
        /// </param>
        public static 
        void DepthMask(bool flag)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDepthMask((bool)flag);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="nearVal">
        /// <para>
        /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="farVal">
        /// <para>
        /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
        /// </para>
        /// </param>
        public static 
        void DepthRange(Single n, Single f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDepthRangef((Single)n, (Single)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void DepthRangex(int n, int f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDepthRangex((int)n, (int)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Disable(OpenTK.Graphics.ES11.EnableCap cap)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDisable((OpenTK.Graphics.ES11.EnableCap)cap);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void DisableClientState(OpenTK.Graphics.ES11.EnableCap array)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDisableClientState((OpenTK.Graphics.ES11.EnableCap)array);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="first">
        /// <para>
        /// Specifies the starting index in the enabled arrays.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of indices to be rendered.
        /// </para>
        /// </param>
        public static 
        void DrawArrays(OpenTK.Graphics.ES11.BeginMode mode, Int32 first, Int32 count)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDrawArrays((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)first, (Int32)count);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="first">
        /// <para>
        /// Specifies the starting index in the enabled arrays.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of indices to be rendered.
        /// </para>
        /// </param>
        public static 
        void DrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 first, Int32 count)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDrawArrays((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)first, (Int32)count);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.BeginMode mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
                indices = (T3)indices_ptr.Target;
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Render primitives from array data
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
        /// </para>
        /// </param>
        /// <param name="count">
        /// <para>
        /// Specifies the number of elements to be rendered.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
        /// </para>
        /// </param>
        /// <param name="indices">
        /// <para>
        /// Specifies a pointer to the location where the indices are stored.
        /// </para>
        /// </param>
        public static 
        void DrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
            try
            {
                Delegates.glDrawElements((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject());
                indices = (T3)indices_ptr.Target;
            }
            finally
            {
                indices_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the switch to disable (for glEnablei and glDisablei only).
        /// </para>
        /// </param>
        public static 
        void Enable(OpenTK.Graphics.ES11.EnableCap cap)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glEnable((OpenTK.Graphics.ES11.EnableCap)cap);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Enable or disable client-side capability
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies the capability to enable. Symbolic constants GL_COLOR_ARRAY, GL_EDGE_FLAG_ARRAY, GL_FOG_COORD_ARRAY, GL_INDEX_ARRAY, GL_NORMAL_ARRAY, GL_SECONDARY_COLOR_ARRAY, GL_TEXTURE_COORD_ARRAY, and GL_VERTEX_ARRAY are accepted.
        /// </para>
        /// </param>
        public static 
        void EnableClientState(OpenTK.Graphics.ES11.EnableCap array)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glEnableClientState((OpenTK.Graphics.ES11.EnableCap)array);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Block until all GL execution is complete
        /// </summary>
        public static 
        void Finish()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFinish();
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Force execution of GL commands in finite time
        /// </summary>
        public static 
        void Flush()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFlush();
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        public static 
        void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFogf((OpenTK.Graphics.ES11.FogParameter)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        public static 
        void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glFogfv((OpenTK.Graphics.ES11.FogParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify fog parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued fog parameter. GL_FOG_MODE, GL_FOG_DENSITY, GL_FOG_START, GL_FOG_END, GL_FOG_INDEX, and GL_FOG_COORD_SRC are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname will be set to.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Fog(OpenTK.Graphics.ES11.FogParameter pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFogfv((OpenTK.Graphics.ES11.FogParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Fogx(OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFogx((OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Fogx(OpenTK.Graphics.ES11.All pname, int[] param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* param_ptr = param)
                {
                    Delegates.glFogxv((OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFogxv((OpenTK.Graphics.ES11.All)pname, (int*)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
        /// </para>
        /// </param>
        public static 
        void FrontFace(OpenTK.Graphics.ES11.FrontFaceDirection mode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFrontFace((OpenTK.Graphics.ES11.FrontFaceDirection)mode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a perspective matrix
        /// </summary>
        /// <param name="left">
        /// <para>
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </para>
        /// </param>
        /// <param name="bottom">
        /// <para>
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </para>
        /// </param>
        /// <param name="nearVal">
        /// <para>
        /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
        /// </para>
        /// </param>
        public static 
        void Frustum(Single l, Single r, Single b, Single t, Single n, Single f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFrustumf((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Frustumx(int l, int r, int b, int t, int n, int f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glFrustumx((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        public static 
        Int32 GenBuffer()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                Int32 retval;
                Int32* buffers_ptr = &retval;
                Delegates.glGenBuffers((Int32)n, (UInt32*)buffers_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        public static 
        void GenBuffers(Int32 n, [OutAttribute] Int32[] buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* buffers_ptr = buffers)
                {
                    Delegates.glGenBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        public static 
        void GenBuffers(Int32 n, [OutAttribute] out Int32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* buffers_ptr = &buffers)
                {
                    Delegates.glGenBuffers((Int32)n, (UInt32*)buffers_ptr);
                    buffers = *buffers_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGenBuffers((Int32)n, (UInt32*)buffers);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* buffers_ptr = buffers)
                {
                    Delegates.glGenBuffers((Int32)n, (UInt32*)buffers_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void GenBuffers(Int32 n, [OutAttribute] out UInt32 buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* buffers_ptr = &buffers)
                {
                    Delegates.glGenBuffers((Int32)n, (UInt32*)buffers_ptr);
                    buffers = *buffers_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate buffer object names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of buffer object names to be generated.
        /// </para>
        /// </param>
        /// <param name="buffers">
        /// <para>
        /// Specifies an array in which the generated buffer object names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGenBuffers((Int32)n, (UInt32*)buffers);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        public static 
        Int32 GenTexture()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                const Int32 n = 1;
                Int32 retval;
                Int32* textures_ptr = &retval;
                Delegates.glGenTextures((Int32)n, (UInt32*)textures_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        public static 
        void GenTextures(Int32 n, [OutAttribute] Int32[] textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* textures_ptr = textures)
                {
                    Delegates.glGenTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        public static 
        void GenTextures(Int32 n, [OutAttribute] out Int32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* textures_ptr = &textures)
                {
                    Delegates.glGenTextures((Int32)n, (UInt32*)textures_ptr);
                    textures = *textures_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGenTextures((Int32)n, (UInt32*)textures);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void GenTextures(Int32 n, [OutAttribute] UInt32[] textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* textures_ptr = textures)
                {
                    Delegates.glGenTextures((Int32)n, (UInt32*)textures_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void GenTextures(Int32 n, [OutAttribute] out UInt32 textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (UInt32* textures_ptr = &textures)
                {
                    Delegates.glGenTextures((Int32)n, (UInt32*)textures_ptr);
                    textures = *textures_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Generate texture names
        /// </summary>
        /// <param name="n">
        /// <para>
        /// Specifies the number of texture names to be generated.
        /// </para>
        /// </param>
        /// <param name="textures">
        /// <para>
        /// Specifies an array in which the generated texture names are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGenTextures((Int32)n, (UInt32*)textures);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        bool GetBoolean(OpenTK.Graphics.ES11.GetPName pname)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                bool retval;
                bool* data_ptr = &retval;
                Delegates.glGetBooleanv((OpenTK.Graphics.ES11.GetPName)pname, (bool*)data_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool[] data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (bool* data_ptr = data)
                {
                    Delegates.glGetBooleanv((OpenTK.Graphics.ES11.GetPName)pname, (bool*)data_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out bool data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (bool* data_ptr = &data)
                {
                    Delegates.glGetBooleanv((OpenTK.Graphics.ES11.GetPName)pname, (bool*)data_ptr);
                    data = *data_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetBoolean(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] bool* data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetBooleanv((OpenTK.Graphics.ES11.GetPName)pname, (bool*)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        public static 
        void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    Delegates.glGetBufferParameteriv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        public static 
        void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    Delegates.glGetBufferParameteriv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return parameters of a buffer object
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target buffer object. The symbolic constant must be GL_ARRAY_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, or GL_PIXEL_UNPACK_BUFFER.
        /// </para>
        /// </param>
        /// <param name="value">
        /// <para>
        /// Specifies the symbolic name of a buffer object parameter. Accepted values are GL_BUFFER_ACCESS, GL_BUFFER_MAPPED, GL_BUFFER_SIZE, or GL_BUFFER_USAGE.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the requested parameter.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetBufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetBufferParameteriv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        public static 
        void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* equation_ptr = equation)
                {
                    Delegates.glGetClipPlanef((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        public static 
        void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* equation_ptr = &equation)
                {
                    Delegates.glGetClipPlanef((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                    equation = *equation_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the coefficients of the specified clipping plane
        /// </summary>
        /// <param name="plane">
        /// <para>
        /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
        /// </para>
        /// </param>
        /// <param name="equation">
        /// <para>
        /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetClipPlanef((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* equation_ptr = equation)
                {
                    Delegates.glGetClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* equation_ptr = &equation)
                {
                    Delegates.glGetClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                    equation = *equation_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetClipPlanex((OpenTK.Graphics.ES11.All)plane, (int*)equation);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return error information
        /// </summary>
        public static 
        OpenTK.Graphics.ES11.ErrorCode GetError()
        {
            return Delegates.glGetError();
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        int GetFixed(OpenTK.Graphics.ES11.All pname)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                int retval;
                int* @params_ptr = &retval;
                Delegates.glGetFixedv((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glGetFixedv((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    Delegates.glGetFixedv((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetFixedv((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        Single GetFloat(OpenTK.Graphics.ES11.GetPName pname)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                Single retval;
                Single* data_ptr = &retval;
                Delegates.glGetFloatv((OpenTK.Graphics.ES11.GetPName)pname, (Single*)data_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single[] data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* data_ptr = data)
                {
                    Delegates.glGetFloatv((OpenTK.Graphics.ES11.GetPName)pname, (Single*)data_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Single data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* data_ptr = &data)
                {
                    Delegates.glGetFloatv((OpenTK.Graphics.ES11.GetPName)pname, (Single*)data_ptr);
                    data = *data_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetFloat(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Single* data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetFloatv((OpenTK.Graphics.ES11.GetPName)pname, (Single*)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        Int32 GetInteger(OpenTK.Graphics.ES11.GetPName pname)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                Int32 retval;
                Int32* data_ptr = &retval;
                Delegates.glGetIntegerv((OpenTK.Graphics.ES11.GetPName)pname, (Int32*)data_ptr);
                return retval;
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32[] data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* data_ptr = data)
                {
                    Delegates.glGetIntegerv((OpenTK.Graphics.ES11.GetPName)pname, (Int32*)data_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] out Int32 data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* data_ptr = &data)
                {
                    Delegates.glGetIntegerv((OpenTK.Graphics.ES11.GetPName)pname, (Int32*)data_ptr);
                    data = *data_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetInteger(OpenTK.Graphics.ES11.GetPName pname, [OutAttribute] Int32* data)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetIntegerv((OpenTK.Graphics.ES11.GetPName)pname, (Int32*)data);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glGetLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] out Single @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = &@params)
                {
                    Delegates.glGetLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return light source parameter values
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT where ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a light source parameter for light. Accepted symbolic names are GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_POSITION, GL_SPOT_DIRECTION, GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetLight(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, [OutAttribute] Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glGetLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    Delegates.glGetLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glGetMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] out Single @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = &@params)
                {
                    Delegates.glGetMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return material parameters
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which of the two materials is being queried. GL_FRONT or GL_BACK are accepted, representing the front and back materials, respectively.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the material parameter to return. GL_AMBIENT, GL_DIFFUSE, GL_SPECULAR, GL_EMISSION, GL_SHININESS, and GL_COLOR_INDEXES are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetMaterial(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, [OutAttribute] Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glGetMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    Delegates.glGetMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        public static 
        void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int[] values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* values_ptr = values)
                {
                    Delegates.glGetPixelMapxv((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        public static 
        void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] out int values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* values_ptr = &values)
                {
                    Delegates.glGetPixelMapxv((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values_ptr);
                    values = *values_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetPixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, [OutAttribute] int* values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetPixelMapxv((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        public static 
        void GetPointer(OpenTK.Graphics.ES11.GetPointervPName pname, [OutAttribute] IntPtr @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        public static 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[] @params)
            where T1 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
            }
            finally
            {
                @params_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        public static 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,] @params)
            where T1 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
            }
            finally
            {
                @params_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        public static 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] T1[,,] @params)
            where T1 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
            }
            finally
            {
                @params_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return the address of the specified pointer
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the array or buffer pointer to be returned. Symbolic constants GL_COLOR_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER, GL_FOG_COORD_ARRAY_POINTER, GL_FEEDBACK_BUFFER_POINTER, GL_INDEX_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER, GL_SECONDARY_COLOR_ARRAY_POINTER, GL_SELECTION_BUFFER_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER, or GL_VERTEX_ARRAY_POINTER are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the pointer value specified by pname.
        /// </para>
        /// </param>
        public static 
        void GetPointer<T1>(OpenTK.Graphics.ES11.GetPointervPName pname, [InAttribute, OutAttribute] ref T1 @params)
            where T1 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
            try
            {
                Delegates.glGetPointerv((OpenTK.Graphics.ES11.GetPointervPName)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                @params = (T1)@params_ptr.Target;
            }
            finally
            {
                @params_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return a string describing the current GL connection
        /// </summary>
        /// <param name="name">
        /// <para>
        /// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, glGetStringi accepts the GL_EXTENSIONS token.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// For glGetStringi, specifies the index of the string to return.
        /// </para>
        /// </param>
        public static 
        String GetString(OpenTK.Graphics.ES11.StringName name)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe { return new string((sbyte*)Delegates.glGetString((OpenTK.Graphics.ES11.StringName)name)); }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glGetTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Single @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = &@params)
                {
                    Delegates.glGetTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    Delegates.glGetTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        public static 
        void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] out Int32 @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    Delegates.glGetTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL, or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture environment parameter. Accepted values are GL_TEXTURE_ENV_MODE, GL_TEXTURE_ENV_COLOR, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the requested data.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, [OutAttribute] Int32* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glGetTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    Delegates.glGetTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        public static 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glGetTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        public static 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Single @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = &@params)
                {
                    Delegates.glGetTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Single*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        public static 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    Delegates.glGetTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Int32*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        public static 
        void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] out Int32 @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = &@params)
                {
                    Delegates.glGetTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Int32*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Return texture parameter values
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the symbolic name of the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// Returns the texture parameters.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.GetTextureParameter pname, [OutAttribute] Int32* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.GetTextureParameter)pname, (Int32*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glGetTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = &@params)
                {
                    Delegates.glGetTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    @params = *@params_ptr;
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glGetTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify implementation-specific hints
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, GL_TEXTURE_COMPRESSION_HINT, and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
        /// </para>
        /// </param>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.
        /// </para>
        /// </param>
        public static 
        void Hint(OpenTK.Graphics.ES11.HintTarget target, OpenTK.Graphics.ES11.HintMode mode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glHint((OpenTK.Graphics.ES11.HintTarget)target, (OpenTK.Graphics.ES11.HintMode)mode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        public static 
        bool IsBuffer(Int32 buffer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            return Delegates.glIsBuffer((UInt32)buffer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a buffer object
        /// </summary>
        /// <param name="buffer">
        /// <para>
        /// Specifies a value that may be the name of a buffer object.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        bool IsBuffer(UInt32 buffer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            return Delegates.glIsBuffer((UInt32)buffer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Test whether a capability is enabled
        /// </summary>
        /// <param name="cap">
        /// <para>
        /// Specifies a symbolic constant indicating a GL capability.
        /// </para>
        /// </param>
        /// <param name="index">
        /// <para>
        /// Specifies the index of the capability.
        /// </para>
        /// </param>
        public static 
        bool IsEnabled(OpenTK.Graphics.ES11.EnableCap cap)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            return Delegates.glIsEnabled((OpenTK.Graphics.ES11.EnableCap)cap);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        public static 
        bool IsTexture(Int32 texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            return Delegates.glIsTexture((UInt32)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Determine if a name corresponds to a texture
        /// </summary>
        /// <param name="texture">
        /// <para>
        /// Specifies a value that may be the name of a texture.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        bool IsTexture(UInt32 texture)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            return Delegates.glIsTexture((UInt32)texture);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        public static 
        void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightf((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        public static 
        void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set light source parameters
        /// </summary>
        /// <param name="light">
        /// <para>
        /// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are identified by symbolic names of the form GL_LIGHT , where i ranges from 0 to the value of GL_MAX_LIGHTS - 1.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued light source parameter for light. GL_SPOT_EXPONENT, GL_SPOT_CUTOFF, GL_CONSTANT_ATTENUATION, GL_LINEAR_ATTENUATION, and GL_QUADRATIC_ATTENUATION are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter pname of light source light will be set to.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Light(OpenTK.Graphics.ES11.LightName light, OpenTK.Graphics.ES11.LightParameter pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightfv((OpenTK.Graphics.ES11.LightName)light, (OpenTK.Graphics.ES11.LightParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        public static 
        void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightModelf((OpenTK.Graphics.ES11.LightModelParameter)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        public static 
        void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glLightModelfv((OpenTK.Graphics.ES11.LightModelParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the lighting model parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued lighting model parameter. GL_LIGHT_MODEL_LOCAL_VIEWER, GL_LIGHT_MODEL_COLOR_CONTROL, and GL_LIGHT_MODEL_TWO_SIDE are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that param will be set to.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void LightModel(OpenTK.Graphics.ES11.LightModelParameter pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightModelfv((OpenTK.Graphics.ES11.LightModelParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void LightModelx(OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightModelx((OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* param_ptr = param)
                {
                    Delegates.glLightModelxv((OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightModelxv((OpenTK.Graphics.ES11.All)pname, (int*)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightx((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLightxv((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the width of rasterized lines
        /// </summary>
        /// <param name="width">
        /// <para>
        /// Specifies the width of rasterized lines. The initial value is 1.
        /// </para>
        /// </param>
        public static 
        void LineWidth(Single width)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLineWidth((Single)width);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void LineWidthx(int width)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLineWidthx((int)width);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the identity matrix
        /// </summary>
        public static 
        void LoadIdentity()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLoadIdentity();
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        public static 
        void LoadMatrix(Single[] m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* m_ptr = m)
                {
                    Delegates.glLoadMatrixf((Single*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        public static 
        void LoadMatrix(ref Single m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* m_ptr = &m)
                {
                    Delegates.glLoadMatrixf((Single*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Replace the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void LoadMatrix(Single* m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLoadMatrixf((Single*)m);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void LoadMatrixx(int[] m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* m_ptr = m)
                {
                    Delegates.glLoadMatrixx((int*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void LoadMatrixx(ref int m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* m_ptr = &m)
                {
                    Delegates.glLoadMatrixx((int*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void LoadMatrixx(int* m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLoadMatrixx((int*)m);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a logical pixel operation for rendering
        /// </summary>
        /// <param name="opcode">
        /// <para>
        /// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
        /// </para>
        /// </param>
        public static 
        void LogicOp(OpenTK.Graphics.ES11.LogicOp opcode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glLogicOp((OpenTK.Graphics.ES11.LogicOp)opcode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        public static 
        void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMaterialf((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        public static 
        void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify material parameters for the lighting model
        /// </summary>
        /// <param name="face">
        /// <para>
        /// Specifies which face or faces are being updated. Must be one of GL_FRONT, GL_BACK, or GL_FRONT_AND_BACK.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the single-valued material parameter of the face or faces that is being updated. Must be GL_SHININESS.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that parameter GL_SHININESS will be set to.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Material(OpenTK.Graphics.ES11.MaterialFace face, OpenTK.Graphics.ES11.MaterialParameter pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMaterialfv((OpenTK.Graphics.ES11.MaterialFace)face, (OpenTK.Graphics.ES11.MaterialParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMaterialx((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* param_ptr = param)
                {
                    Delegates.glMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMaterialxv((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify which matrix is the current matrix
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: GL_MODELVIEW, GL_PROJECTION, and GL_TEXTURE. The initial value is GL_MODELVIEW. Additionally, if the ARB_imaging extension is supported, GL_COLOR is also accepted.
        /// </para>
        /// </param>
        public static 
        void MatrixMode(OpenTK.Graphics.ES11.MatrixMode mode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMatrixMode((OpenTK.Graphics.ES11.MatrixMode)mode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the current texture coordinates
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
        /// </para>
        /// </param>
        /// <param name="s">
        /// <para>
        /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
        /// </para>
        /// </param>
        public static 
        void MultiTexCoord4(OpenTK.Graphics.ES11.All target, Single s, Single t, Single r, Single q)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMultiTexCoord4f((OpenTK.Graphics.ES11.All)target, (Single)s, (Single)t, (Single)r, (Single)q);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMultiTexCoord4x((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r, (int)q);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        public static 
        void MultMatrix(Single[] m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* m_ptr = m)
                {
                    Delegates.glMultMatrixf((Single*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        public static 
        void MultMatrix(ref Single m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* m_ptr = &m)
                {
                    Delegates.glMultMatrixf((Single*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with the specified matrix
        /// </summary>
        /// <param name="m">
        /// <para>
        /// Points to 16 consecutive values that are used as the elements of a 4 times 4 column-major matrix.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void MultMatrix(Single* m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMultMatrixf((Single*)m);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void MultMatrixx(int[] m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* m_ptr = m)
                {
                    Delegates.glMultMatrixx((int*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void MultMatrixx(ref int m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* m_ptr = &m)
                {
                    Delegates.glMultMatrixx((int*)m_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void MultMatrixx(int* m)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glMultMatrixx((int*)m);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the current normal vector
        /// </summary>
        /// <param name="nx">
        /// <para>
        /// Specify the , , and coordinates of the new current normal. The initial value of the current normal is the unit vector, (0, 0, 1).
        /// </para>
        /// <para>
        ///
        /// </para>
        /// </param>
        public static 
        void Normal3(Single nx, Single ny, Single nz)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glNormal3f((Single)nx, (Single)ny, (Single)nz);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Normal3x(int nx, int ny, int nz)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glNormal3x((int)nx, (int)ny, (int)nz);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void NormalPointer(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, IntPtr pointer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of normals
        /// </summary>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_BYTE, GL_SHORT, GL_INT, GL_FLOAT, and GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive normals. If stride is 0, the normals are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first normal in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void NormalPointer<T2>(OpenTK.Graphics.ES11.NormalPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
            where T2 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glNormalPointer((OpenTK.Graphics.ES11.NormalPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                pointer = (T2)pointer_ptr.Target;
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix with an orthographic matrix
        /// </summary>
        /// <param name="left">
        /// <para>
        /// Specify the coordinates for the left and right vertical clipping planes.
        /// </para>
        /// </param>
        /// <param name="bottom">
        /// <para>
        /// Specify the coordinates for the bottom and top horizontal clipping planes.
        /// </para>
        /// </param>
        /// <param name="nearVal">
        /// <para>
        /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
        /// </para>
        /// </param>
        public static 
        void Ortho(Single l, Single r, Single b, Single t, Single n, Single f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glOrthof((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Orthox(int l, int r, int b, int t, int n, int f)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glOrthox((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        public static 
        void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int[] values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* values_ptr = values)
                {
                    Delegates.glPixelMapx((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        public static 
        void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, ref int values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* values_ptr = &values)
                {
                    Delegates.glPixelMapx((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void PixelMapx(OpenTK.Graphics.ES11.All map, Int32 size, int* values)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPixelMapx((OpenTK.Graphics.ES11.All)map, (Int32)size, (int*)values);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set pixel storage modes
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: GL_PACK_SWAP_BYTES, GL_PACK_LSB_FIRST, GL_PACK_ROW_LENGTH, GL_PACK_IMAGE_HEIGHT, GL_PACK_SKIP_PIXELS, GL_PACK_SKIP_ROWS, GL_PACK_SKIP_IMAGES, and GL_PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: GL_UNPACK_SWAP_BYTES, GL_UNPACK_LSB_FIRST, GL_UNPACK_ROW_LENGTH, GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_IMAGES, and GL_UNPACK_ALIGNMENT.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies the value that pname is set to.
        /// </para>
        /// </param>
        public static 
        void PixelStore(OpenTK.Graphics.ES11.PixelStoreParameter pname, Int32 param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPixelStorei((OpenTK.Graphics.ES11.PixelStoreParameter)pname, (Int32)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary></summary>
        public static 
        void PixelStorex(OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPixelStorex((OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        public static 
        void PointParameter(OpenTK.Graphics.ES11.All pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointParameterf((OpenTK.Graphics.ES11.All)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        public static 
        void PointParameter(OpenTK.Graphics.ES11.All pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glPointParameterfv((OpenTK.Graphics.ES11.All)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify point parameters
        /// </summary>
        /// <param name="pname">
        /// <para>
        /// Specifies a single-valued point parameter. GL_POINT_FADE_THRESHOLD_SIZE, and GL_POINT_SPRITE_COORD_ORIGIN are accepted.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For glPointParameterfv and glPointParameteriv, specifies a pointer to an array where the value or values to be assigned to pname are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void PointParameter(OpenTK.Graphics.ES11.All pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointParameterfv((OpenTK.Graphics.ES11.All)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void PointParameterx(OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointParameterx((OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glPointParameterxv((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointParameterxv((OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify the diameter of rasterized points
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the diameter of rasterized points. The initial value is 1.
        /// </para>
        /// </param>
        public static 
        void PointSize(Single size)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointSize((Single)size);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void PointSizex(int size)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPointSizex((int)size);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the scale and units used to calculate depth values
        /// </summary>
        /// <param name="factor">
        /// <para>
        /// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="units">
        /// <para>
        /// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void PolygonOffset(Single factor, Single units)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPolygonOffset((Single)factor, (Single)units);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void PolygonOffsetx(int factor, int units)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPolygonOffsetx((int)factor, (int)units);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void PopMatrix()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPopMatrix();
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Push and pop the current matrix stack
        /// </summary>
        public static 
        void PushMatrix()
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glPushMatrix();
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        public static 
        void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [OutAttribute] IntPtr pixels)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        public static 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[] pixels)
            where T6 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        public static 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,] pixels)
            where T6 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        public static 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T6[,,] pixels)
            where T6 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Read a block of pixels from the frame buffer
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left corner of a rectangular block of pixels.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the dimensions of the pixel rectangle. width and height of one correspond to a single pixel.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL, GL_RED, GL_GREEN, GL_BLUE, GL_RGB, GL_BGR, GL_RGBA, and GL_BGRA.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. Must be one of GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_HALF_FLOAT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_2_10_10_10_REV, GL_UNSIGNED_INT_24_8, GL_UNSIGNED_INT_10F_11F_11F_REV, GL_UNSIGNED_INT_5_9_9_9_REV, or GL_FLOAT_32_UNSIGNED_INT_24_8_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Returns the pixel data.
        /// </para>
        /// </param>
        public static 
        void ReadPixels<T6>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T6 pixels)
            where T6 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glReadPixels((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
                pixels = (T6)pixels_ptr.Target;
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a rotation matrix
        /// </summary>
        /// <param name="angle">
        /// <para>
        /// Specifies the angle of rotation, in degrees.
        /// </para>
        /// </param>
        /// <param name="x">
        /// <para>
        /// Specify the x, y, and z coordinates of a vector, respectively.
        /// </para>
        /// </param>
        public static 
        void Rotate(Single angle, Single x, Single y, Single z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glRotatef((Single)angle, (Single)x, (Single)y, (Single)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Rotatex(int angle, int x, int y, int z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glRotatex((int)angle, (int)x, (int)y, (int)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify multisample coverage parameters
        /// </summary>
        /// <param name="value">
        /// <para>
        /// Specify a single floating-point sample coverage value. The value is clamped to the range [0 ,1]. The initial value is 1.0.
        /// </para>
        /// </param>
        /// <param name="invert">
        /// <para>
        /// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE.
        /// </para>
        /// </param>
        public static 
        void SampleCoverage(Single value, bool invert)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glSampleCoverage((Single)value, (bool)invert);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void SampleCoveragex(int value, bool invert)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glSampleCoveragex((int)value, (bool)invert);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a general scaling matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify scale factors along the x, y, and z axes, respectively.
        /// </para>
        /// </param>
        public static 
        void Scale(Single x, Single y, Single z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glScalef((Single)x, (Single)y, (Single)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Scalex(int x, int y, int z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glScalex((int)x, (int)y, (int)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define the scissor box
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the lower left corner of the scissor box. Initially (0, 0).
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </para>
        /// </param>
        public static 
        void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glScissor((Int32)x, (Int32)y, (Int32)width, (Int32)height);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Select flat or smooth shading
        /// </summary>
        /// <param name="mode">
        /// <para>
        /// Specifies a symbolic value representing a shading technique. Accepted values are GL_FLAT and GL_SMOOTH. The initial value is GL_SMOOTH.
        /// </para>
        /// </param>
        public static 
        void ShadeModel(OpenTK.Graphics.ES11.ShadingModel mode)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glShadeModel((OpenTK.Graphics.ES11.ShadingModel)mode);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        public static 
        void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, Int32 mask)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glStencilFunc((OpenTK.Graphics.ES11.StencilFunction)func, (Int32)@ref, (UInt32)mask);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set front and back function and reference value for stencil testing
        /// </summary>
        /// <param name="func">
        /// <para>
        /// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
        /// </para>
        /// </param>
        /// <param name="ref">
        /// <para>
        /// Specifies the reference value for the stencil test. ref is clamped to the range [0, 2 sup n - 1], where is the number of bitplanes in the stencil buffer. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="mask">
        /// <para>
        /// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The initial value is all 1's.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void StencilFunc(OpenTK.Graphics.ES11.StencilFunction func, Int32 @ref, UInt32 mask)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glStencilFunc((OpenTK.Graphics.ES11.StencilFunction)func, (Int32)@ref, (UInt32)mask);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        public static 
        void StencilMask(Int32 mask)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glStencilMask((UInt32)mask);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Control the front and back writing of individual bits in the stencil planes
        /// </summary>
        /// <param name="mask">
        /// <para>
        /// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 1's.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        void StencilMask(UInt32 mask)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glStencilMask((UInt32)mask);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set front and back stencil test actions
        /// </summary>
        /// <param name="sfail">
        /// <para>
        /// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: GL_KEEP, GL_ZERO, GL_REPLACE, GL_INCR, GL_INCR_WRAP, GL_DECR, GL_DECR_WRAP, and GL_INVERT. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dpfail">
        /// <para>
        /// Specifies the stencil action when the stencil test passes, but the depth test fails. dpfail accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        /// <param name="dppass">
        /// <para>
        /// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and either there is no depth buffer or depth testing is not enabled. dppass accepts the same symbolic constants as sfail. The initial value is GL_KEEP.
        /// </para>
        /// </param>
        public static 
        void StencilOp(OpenTK.Graphics.ES11.StencilOp fail, OpenTK.Graphics.ES11.StencilOp zfail, OpenTK.Graphics.ES11.StencilOp zpass)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glStencilOp((OpenTK.Graphics.ES11.StencilOp)fail, (OpenTK.Graphics.ES11.StencilOp)zfail, (OpenTK.Graphics.ES11.StencilOp)zpass);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void TexCoordPointer(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, IntPtr pointer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of texture coordinates
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per array element. Must be 1, 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each texture coordinate. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive texture coordinate sets. If stride is 0, the array elements are understood to be tightly packed. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first texture coordinate set in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void TexCoordPointer<T3>(Int32 size, OpenTK.Graphics.ES11.TexCoordPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glTexCoordPointer((Int32)size, (OpenTK.Graphics.ES11.TexCoordPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                pointer = (T3)pointer_ptr.Target;
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        public static 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnvf((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        public static 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnvfv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        public static 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32 param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnvi((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        public static 
        void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    Delegates.glTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture environment parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies a texture environment. May be GL_TEXTURE_ENV, GL_TEXTURE_FILTER_CONTROL or GL_POINT_SPRITE.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture environment parameter. May be either GL_TEXTURE_ENV_MODE, GL_TEXTURE_LOD_BIAS, GL_COMBINE_RGB, GL_COMBINE_ALPHA, GL_SRC0_RGB, GL_SRC1_RGB, GL_SRC2_RGB, GL_SRC0_ALPHA, GL_SRC1_ALPHA, GL_SRC2_ALPHA, GL_OPERAND0_RGB, GL_OPERAND1_RGB, GL_OPERAND2_RGB, GL_OPERAND0_ALPHA, GL_OPERAND1_ALPHA, GL_OPERAND2_ALPHA, GL_RGB_SCALE, GL_ALPHA_SCALE, or GL_COORD_REPLACE.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// Specifies a single symbolic constant, one of GL_ADD, GL_ADD_SIGNED, GL_INTERPOLATE, GL_MODULATE, GL_DECAL, GL_BLEND, GL_REPLACE, GL_SUBTRACT, GL_COMBINE, GL_TEXTURE, GL_CONSTANT, GL_PRIMARY_COLOR, GL_PREVIOUS, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when specifying the GL_RGB_SCALE or GL_ALPHA_SCALE.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexEnv(OpenTK.Graphics.ES11.TextureEnvTarget target, OpenTK.Graphics.ES11.TextureEnvParameter pname, Int32* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnviv((OpenTK.Graphics.ES11.TextureEnvTarget)target, (OpenTK.Graphics.ES11.TextureEnvParameter)pname, (Int32*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnvx((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexEnvxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture image
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.
        /// </para>
        /// </param>
        /// <param name="internalFormat">
        /// <para>
        /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.
        /// </para>
        /// </param>
        /// <param name="border">
        /// <para>
        /// This value must be 0.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)internalformat, (Int32)width, (Int32)height, (Int32)border, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
                pixels = (T8)pixels_ptr.Target;
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        public static 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameterf((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Single)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        public static 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Single* @params_ptr = @params)
                {
                    Delegates.glTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Single*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Single* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameterfv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Single*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        public static 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32 param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameteri((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Int32)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        public static 
        void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (Int32* @params_ptr = @params)
                {
                    Delegates.glTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Int32*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set texture parameters
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture, which must be either GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, or GL_TEXTURE_CUBE_MAP.
        /// </para>
        /// </param>
        /// <param name="pname">
        /// <para>
        /// Specifies the symbolic name of a single-valued texture parameter. pname can be one of the following: GL_DEPTH_STENCIL_TEXTURE_MODE, GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_COMPARE_FUNC, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MAG_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_SWIZZLE_R, GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, or GL_TEXTURE_WRAP_R.
        /// </para>
        /// <para>
        /// For the vector commands (glTexParameter*v), pname can also be one of GL_TEXTURE_BORDER_COLOR or GL_TEXTURE_SWIZZLE_RGBA.
        /// </para>
        /// </param>
        /// <param name="param">
        /// <para>
        /// For the scalar commands, specifies the value of pname.
        /// </para>
        /// </param>
        /// <param name="params">
        /// <para>
        /// For the vector commands, specifies a pointer to an array where the value or values of pname are stored.
        /// </para>
        /// </param>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexParameter(OpenTK.Graphics.ES11.TextureTarget target, OpenTK.Graphics.ES11.TextureParameterName pname, Int32* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameteriv((OpenTK.Graphics.ES11.TextureTarget)target, (OpenTK.Graphics.ES11.TextureParameterName)pname, (Int32*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameterx((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            unsafe
            {
                fixed (int* @params_ptr = @params)
                {
                    Delegates.glTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                }
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        [System.CLSCompliant(false)]
        public static 
        unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexParameterxv((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexSubImage2D(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, IntPtr pixels)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] T8[,,] pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Specify a two-dimensional texture subimage
        /// </summary>
        /// <param name="target">
        /// <para>
        /// Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_1D_ARRAY.
        /// </para>
        /// </param>
        /// <param name="level">
        /// <para>
        /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
        /// </para>
        /// </param>
        /// <param name="xoffset">
        /// <para>
        /// Specifies a texel offset in the x direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="yoffset">
        /// <para>
        /// Specifies a texel offset in the y direction within the texture array.
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specifies the width of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="height">
        /// <para>
        /// Specifies the height of the texture subimage.
        /// </para>
        /// </param>
        /// <param name="format">
        /// <para>
        /// Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.
        /// </para>
        /// </param>
        /// <param name="data">
        /// <para>
        /// Specifies a pointer to the image data in memory.
        /// </para>
        /// </param>
        public static 
        void TexSubImage2D<T8>(OpenTK.Graphics.ES11.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, OpenTK.Graphics.ES11.PixelFormat format, OpenTK.Graphics.ES11.PixelType type, [InAttribute, OutAttribute] ref T8 pixels)
            where T8 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pixels_ptr = GCHandle.Alloc(pixels, GCHandleType.Pinned);
            try
            {
                Delegates.glTexSubImage2D((OpenTK.Graphics.ES11.TextureTarget)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.PixelFormat)format, (OpenTK.Graphics.ES11.PixelType)type, (IntPtr)pixels_ptr.AddrOfPinnedObject());
                pixels = (T8)pixels_ptr.Target;
            }
            finally
            {
                pixels_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Multiply the current matrix by a translation matrix
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the x, y, and z coordinates of a translation vector.
        /// </para>
        /// </param>
        public static 
        void Translate(Single x, Single y, Single z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTranslatef((Single)x, (Single)y, (Single)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]</summary>
        public static 
        void Translatex(int x, int y, int z)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glTranslatex((int)x, (int)y, (int)z);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void VertexPointer(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, IntPtr pointer)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer);
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Define an array of vertex data
        /// </summary>
        /// <param name="size">
        /// <para>
        /// Specifies the number of coordinates per vertex. Must be 2, 3, or 4. The initial value is 4.
        /// </para>
        /// </param>
        /// <param name="type">
        /// <para>
        /// Specifies the data type of each coordinate in the array. Symbolic constants GL_SHORT, GL_INT, GL_FLOAT, or GL_DOUBLE are accepted. The initial value is GL_FLOAT.
        /// </para>
        /// </param>
        /// <param name="stride">
        /// <para>
        /// Specifies the byte offset between consecutive vertices. If stride is 0, the vertices are understood to be tightly packed in the array. The initial value is 0.
        /// </para>
        /// </param>
        /// <param name="pointer">
        /// <para>
        /// Specifies a pointer to the first coordinate of the first vertex in the array. The initial value is 0.
        /// </para>
        /// </param>
        public static 
        void VertexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.VertexPointerType type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
            where T3 : struct
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
            try
            {
                Delegates.glVertexPointer((Int32)size, (OpenTK.Graphics.ES11.VertexPointerType)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                pointer = (T3)pointer_ptr.Target;
            }
            finally
            {
                pointer_ptr.Free();
            }
            #if DEBUG
            }
            #endif
        }

        /// <summary>[requires: v1.0]
        /// Set the viewport
        /// </summary>
        /// <param name="x">
        /// <para>
        /// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
        /// </para>
        /// </param>
        /// <param name="width">
        /// <para>
        /// Specify the width and height of the viewport. When a GL context is first attached to a window, width and height are set to the dimensions of that window.
        /// </para>
        /// </param>
        public static 
        void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            #if DEBUG
            using (new ErrorHelper(GraphicsContext.CurrentContext))
            {
            #endif
            Delegates.glViewport((Int32)x, (Int32)y, (Int32)width, (Int32)height);
            #if DEBUG
            }
            #endif
        }

        public static partial class Ext
        {
            /// <summary>[requires: EXT_blend_minmax]
            /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
            /// </para>
            /// </param>
            /// <param name="mode">
            /// <para>
            /// specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            public static 
            void BlendEquation(OpenTK.Graphics.ES11.All mode)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBlendEquationEXT((OpenTK.Graphics.ES11.All)mode);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            public static 
            void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All[] attachments)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (OpenTK.Graphics.ES11.All* attachments_ptr = attachments)
                    {
                        Delegates.glDiscardFramebufferEXT((OpenTK.Graphics.ES11.All)target, (Int32)numAttachments, (OpenTK.Graphics.ES11.All*)attachments_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            public static 
            void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, ref OpenTK.Graphics.ES11.All attachments)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (OpenTK.Graphics.ES11.All* attachments_ptr = &attachments)
                    {
                        Delegates.glDiscardFramebufferEXT((OpenTK.Graphics.ES11.All)target, (Int32)numAttachments, (OpenTK.Graphics.ES11.All*)attachments_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_discard_framebuffer]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DiscardFramebuffer(OpenTK.Graphics.ES11.All target, Int32 numAttachments, OpenTK.Graphics.ES11.All* attachments)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDiscardFramebufferEXT((OpenTK.Graphics.ES11.All)target, (Int32)numAttachments, (OpenTK.Graphics.ES11.All*)attachments);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Indicate modifications to a range of a mapped buffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the flush operation. target must be GL_ARRAY_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, or GL_UNIFORM_BUFFER.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies the start of the buffer subrange, in basic machine units.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies the length of the buffer subrange, in basic machine units.
            /// </para>
            /// </param>
            public static 
            void FlushMappedBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFlushMappedBufferRangeEXT((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)length);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            public static 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DMultisampleEXT((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DMultisampleEXT((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            OpenTK.Graphics.ES11.All GetGraphicsResetStatus()
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glGetGraphicsResetStatusEXT();
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = @params)
                    {
                        Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = &@params)
                    {
                        Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = @params)
                    {
                        Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Single @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = &@params)
                    {
                        Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetnUniformfvEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Single*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetnUniform(Int32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetnUniform(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetnUniformivEXT((UInt32)program, (Int32)location, (Int32)bufSize, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Map a section of a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target buffer is bound.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies a the starting offset within the buffer of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies a length of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// Specifies a combination of access flags indicating the desired access to the range.
            /// </para>
            /// </param>
            public static 
            IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, Int32 access)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glMapBufferRangeEXT((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)length, (UInt32)access);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_map_buffer_range]
            /// Map a section of a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target buffer is bound.
            /// </para>
            /// </param>
            /// <param name="offset">
            /// <para>
            /// Specifies a the starting offset within the buffer of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="length">
            /// <para>
            /// Specifies a length of the range to be mapped.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// Specifies a combination of access flags indicating the desired access to the range.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            IntPtr MapBufferRange(OpenTK.Graphics.ES11.All target, IntPtr offset, IntPtr length, UInt32 access)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glMapBufferRangeEXT((OpenTK.Graphics.ES11.All)target, (IntPtr)offset, (IntPtr)length, (UInt32)access);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            public static 
            void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* first_ptr = first)
                    fixed (Int32* count_ptr = count)
                    {
                        Delegates.glMultiDrawArraysEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)first_ptr, (Int32*)count_ptr, (Int32)primcount);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            public static 
            void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 first, ref Int32 count, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* first_ptr = &first)
                    fixed (Int32* count_ptr = &count)
                    {
                        Delegates.glMultiDrawArraysEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)first_ptr, (Int32*)count_ptr, (Int32)primcount);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives from array data
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="first">
            /// <para>
            /// Points to an array of starting indices in the enabled arrays.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the number of indices to be rendered.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the first and count
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawArrays(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* first, Int32* count, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiDrawArraysEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)first, (Int32*)count, (Int32)primcount);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = count)
                    {
                        Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices, (Int32)primcount);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32[] count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                            indices = (T3)indices_ptr.Target;
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = &count)
                    {
                        Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices, (Int32)primcount);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = &count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = &count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = &count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            public static 
            void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, ref Int32 count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* count_ptr = &count)
                    {
                        GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                        try
                        {
                            Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count_ptr, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                            indices = (T3)indices_ptr.Target;
                        }
                        finally
                        {
                            indices_ptr.Free();
                        }
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawElements(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, IntPtr indices, Int32 primcount)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices, (Int32)primcount);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                try
                {
                    Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                }
                finally
                {
                    indices_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                try
                {
                    Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                }
                finally
                {
                    indices_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T3[,,] indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                try
                {
                    Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                }
                finally
                {
                    indices_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multi_draw_arrays]
            /// Render multiple sets of primitives by specifying indices of array data elements
            /// </summary>
            /// <param name="mode">
            /// <para>
            /// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
            /// </para>
            /// </param>
            /// <param name="count">
            /// <para>
            /// Points to an array of the elements counts.
            /// </para>
            /// </param>
            /// <param name="type">
            /// <para>
            /// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
            /// </para>
            /// </param>
            /// <param name="indices">
            /// <para>
            /// Specifies a pointer to the location where the indices are stored.
            /// </para>
            /// </param>
            /// <param name="drawcount">
            /// <para>
            /// Specifies the size of the count and indices arrays.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiDrawElements<T3>(OpenTK.Graphics.ES11.PrimitiveType mode, Int32* count, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T3 indices, Int32 primcount)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle indices_ptr = GCHandle.Alloc(indices, GCHandleType.Pinned);
                try
                {
                    Delegates.glMultiDrawElementsEXT((OpenTK.Graphics.ES11.PrimitiveType)mode, (Int32*)count, (OpenTK.Graphics.ES11.All)type, (IntPtr)indices_ptr.AddrOfPinnedObject(), (Int32)primcount);
                    indices = (T3)indices_ptr.Target;
                }
                finally
                {
                    indices_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [OutAttribute] IntPtr data)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[] data)
                where T7 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
                try
                {
                    Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,] data)
                where T7 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
                try
                {
                    Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] T7[,,] data)
                where T7 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
                try
                {
                    Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    data_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_robustness]</summary>
            public static 
            void ReadnPixels<T7>(Int32 x, Int32 y, Int32 width, Int32 height, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, Int32 bufSize, [InAttribute, OutAttribute] ref T7 data)
                where T7 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
                try
                {
                    Delegates.glReadnPixelsEXT((Int32)x, (Int32)y, (Int32)width, (Int32)height, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (Int32)bufSize, (IntPtr)data_ptr.AddrOfPinnedObject());
                    data = (T7)data_ptr.Target;
                }
                finally
                {
                    data_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_multisampled_render_to_texture]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            public static 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRenderbufferStorageMultisampleEXT((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a one-dimensional texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be either GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            public static 
            void TexStorage1D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexStorage1DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a two-dimensional or one-dimensional array texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be one of GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, or GL_PROXY_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the texture, in texels.
            /// </para>
            /// </param>
            public static 
            void TexStorage2D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexStorage2DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a three-dimensional, two-dimensional array or cube-map array texture
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the operation. target must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_ARRAY, or GL_PROXY_TEXTURE_CUBE_ARRAY.
            /// </para>
            /// </param>
            /// <param name="levels">
            /// <para>
            /// Specify the number of texture levels.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the sized internal format to be used to store texture image data.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the texture, in texels.
            /// </para>
            /// </param>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth of the texture, in texels.
            /// </para>
            /// </param>
            public static 
            void TexStorage3D(OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexStorage3DEXT((OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            public static 
            void TextureStorage1D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage1DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            public static 
            void TextureStorage1D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage1DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            public static 
            void TextureStorage2D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage2DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            public static 
            void TextureStorage2D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage2DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            public static 
            void TextureStorage3D(Int32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage3DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: EXT_texture_storage]</summary>
            [System.CLSCompliant(false)]
            public static 
            void TextureStorage3D(UInt32 texture, OpenTK.Graphics.ES11.All target, Int32 levels, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height, Int32 depth)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTextureStorage3DEXT((UInt32)texture, (OpenTK.Graphics.ES11.All)target, (Int32)levels, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height, (Int32)depth);
                #if DEBUG
                }
                #endif
            }

        }

        public static partial class Img
        {
            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            public static 
            void ClipPlane(OpenTK.Graphics.ES11.All p, Single[] eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* eqn_ptr = eqn)
                    {
                        Delegates.glClipPlanefIMG((OpenTK.Graphics.ES11.All)p, (Single*)eqn_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            public static 
            void ClipPlane(OpenTK.Graphics.ES11.All p, ref Single eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* eqn_ptr = &eqn)
                    {
                        Delegates.glClipPlanefIMG((OpenTK.Graphics.ES11.All)p, (Single*)eqn_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_user_clip_plane]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ClipPlane(OpenTK.Graphics.ES11.All p, Single* eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClipPlanefIMG((OpenTK.Graphics.ES11.All)p, (Single*)eqn);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            public static 
            void ClipPlanex(OpenTK.Graphics.ES11.All p, int[] eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* eqn_ptr = eqn)
                    {
                        Delegates.glClipPlanexIMG((OpenTK.Graphics.ES11.All)p, (int*)eqn_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            public static 
            void ClipPlanex(OpenTK.Graphics.ES11.All p, ref int eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* eqn_ptr = &eqn)
                    {
                        Delegates.glClipPlanexIMG((OpenTK.Graphics.ES11.All)p, (int*)eqn_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_user_clip_plane]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ClipPlanex(OpenTK.Graphics.ES11.All p, int* eqn)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClipPlanexIMG((OpenTK.Graphics.ES11.All)p, (int*)eqn);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            public static 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level, Int32 samples)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DMultisampleIMG((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_multisampled_render_to_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            void FramebufferTexture2DMultisample(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level, Int32 samples)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DMultisampleIMG((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level, (Int32)samples);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: IMG_multisampled_render_to_texture]
            /// Establish data storage, format, dimensions and sample count of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="samples">
            /// <para>
            /// Specifies the number of samples to be used for the renderbuffer object's storage.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            public static 
            void RenderbufferStorageMultisample(OpenTK.Graphics.ES11.All target, Int32 samples, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRenderbufferStorageMultisampleIMG((OpenTK.Graphics.ES11.All)target, (Int32)samples, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

        }

        public static partial class NV
        {
            /// <summary>[requires: NV_fence]</summary>
            public static 
            void DeleteFences(Int32 n, Int32[] fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* fences_ptr = fences)
                    {
                        Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void DeleteFences(Int32 n, ref Int32 fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* fences_ptr = &fences)
                    {
                        Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteFences(Int32 n, Int32* fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void DeleteFences(Int32 n, UInt32[] fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* fences_ptr = fences)
                    {
                        Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void DeleteFences(Int32 n, ref UInt32 fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* fences_ptr = &fences)
                    {
                        Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteFences(Int32 n, UInt32* fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteFencesNV((Int32)n, (UInt32*)fences);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void FinishFence(Int32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFinishFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void FinishFence(UInt32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFinishFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void GenFences(Int32 n, [OutAttribute] Int32[] fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* fences_ptr = fences)
                    {
                        Delegates.glGenFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void GenFences(Int32 n, [OutAttribute] out Int32 fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* fences_ptr = &fences)
                    {
                        Delegates.glGenFencesNV((Int32)n, (UInt32*)fences_ptr);
                        fences = *fences_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenFences(Int32 n, [OutAttribute] Int32* fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenFencesNV((Int32)n, (UInt32*)fences);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GenFences(Int32 n, [OutAttribute] UInt32[] fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* fences_ptr = fences)
                    {
                        Delegates.glGenFencesNV((Int32)n, (UInt32*)fences_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GenFences(Int32 n, [OutAttribute] out UInt32 fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* fences_ptr = &fences)
                    {
                        Delegates.glGenFencesNV((Int32)n, (UInt32*)fences_ptr);
                        fences = *fences_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenFences(Int32 n, [OutAttribute] UInt32* fences)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenFencesNV((Int32)n, (UInt32*)fences);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetFence(Int32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetFence(UInt32 fence, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetFenceivNV((UInt32)fence, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            bool IsFence(Int32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            bool IsFence(UInt32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            void SetFence(Int32 fence, OpenTK.Graphics.ES11.All condition)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glSetFenceNV((UInt32)fence, (OpenTK.Graphics.ES11.All)condition);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            void SetFence(UInt32 fence, OpenTK.Graphics.ES11.All condition)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glSetFenceNV((UInt32)fence, (OpenTK.Graphics.ES11.All)condition);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            public static 
            bool TestFence(Int32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glTestFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: NV_fence]</summary>
            [System.CLSCompliant(false)]
            public static 
            bool TestFence(UInt32 fence)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glTestFenceNV((UInt32)fence);
                #if DEBUG
                }
                #endif
            }

        }

        public static partial class Oes
        {
            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Accumx(OpenTK.Graphics.ES11.All op, int value)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glAccumxOES((OpenTK.Graphics.ES11.All)op, (int)value);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void AlphaFuncx(OpenTK.Graphics.ES11.All func, int @ref)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glAlphaFuncxOES((OpenTK.Graphics.ES11.All)func, (int)@ref);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a framebuffer to a framebuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target of the binding operation.
            /// </para>
            /// </param>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies the name of the framebuffer object to bind.
            /// </para>
            /// </param>
            public static 
            void BindFramebuffer(OpenTK.Graphics.ES11.All target, Int32 framebuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindFramebufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)framebuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a framebuffer to a framebuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target of the binding operation.
            /// </para>
            /// </param>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies the name of the framebuffer object to bind.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void BindFramebuffer(OpenTK.Graphics.ES11.All target, UInt32 framebuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindFramebufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)framebuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a renderbuffer to a renderbuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of the renderbuffer object to bind.
            /// </para>
            /// </param>
            public static 
            void BindRenderbuffer(OpenTK.Graphics.ES11.All target, Int32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindRenderbufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Bind a renderbuffer to a renderbuffer target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of the renderbuffer object to bind.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void BindRenderbuffer(OpenTK.Graphics.ES11.All target, UInt32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindRenderbufferOES((OpenTK.Graphics.ES11.All)target, (UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            public static 
            void BindVertexArray(Int32 array)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindVertexArrayOES((UInt32)array);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Bind a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies the name of the vertex array to bind.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void BindVertexArray(UInt32 array)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBindVertexArrayOES((UInt32)array);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte[] bitmap)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* bitmap_ptr = bitmap)
                    {
                        Delegates.glBitmapxOES((Int32)width, (Int32)height, (int)xorig, (int)yorig, (int)xmove, (int)ymove, (Byte*)bitmap_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, ref Byte bitmap)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* bitmap_ptr = &bitmap)
                    {
                        Delegates.glBitmapxOES((Int32)width, (Int32)height, (int)xorig, (int)yorig, (int)xmove, (int)ymove, (Byte*)bitmap_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Bitmapx(Int32 width, Int32 height, int xorig, int yorig, int xmove, int ymove, Byte* bitmap)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBitmapxOES((Int32)width, (Int32)height, (int)xorig, (int)yorig, (int)xmove, (int)ymove, (Byte*)bitmap);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void BlendColorx(int red, int green, int blue, int alpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBlendColorxOES((int)red, (int)green, (int)blue, (int)alpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_blend_subtract]
            /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationi, specifies the index of the draw buffer for which to set the blend equation.
            /// </para>
            /// </param>
            /// <param name="mode">
            /// <para>
            /// specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            public static 
            void BlendEquation(OpenTK.Graphics.ES11.All mode)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBlendEquationOES((OpenTK.Graphics.ES11.All)mode);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_blend_equation_separate]
            /// Set the RGB blend equation and the alpha blend equation separately
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// for glBlendEquationSeparatei, specifies the index of the draw buffer for which to set the blend equations.
            /// </para>
            /// </param>
            /// <param name="modeRGB">
            /// <para>
            /// specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            /// <param name="modeAlpha">
            /// <para>
            /// specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.
            /// </para>
            /// </param>
            public static 
            void BlendEquationSeparate(OpenTK.Graphics.ES11.All modeRGB, OpenTK.Graphics.ES11.All modeAlpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBlendEquationSeparateOES((OpenTK.Graphics.ES11.All)modeRGB, (OpenTK.Graphics.ES11.All)modeAlpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_blend_func_separate]
            /// Specify pixel arithmetic for RGB and alpha components separately
            /// </summary>
            /// <param name="buf">
            /// <para>
            /// For glBlendFuncSeparatei, specifies the index of the draw buffer for which to set the blend functions.
            /// </para>
            /// </param>
            /// <param name="srcRGB">
            /// <para>
            /// Specifies how the red, green, and blue blending factors are computed. The initial value is GL_ONE.
            /// </para>
            /// </param>
            /// <param name="dstRGB">
            /// <para>
            /// Specifies how the red, green, and blue destination blending factors are computed. The initial value is GL_ZERO.
            /// </para>
            /// </param>
            /// <param name="srcAlpha">
            /// <para>
            /// Specified how the alpha source blending factor is computed. The initial value is GL_ONE.
            /// </para>
            /// </param>
            /// <param name="dstAlpha">
            /// <para>
            /// Specified how the alpha destination blending factor is computed. The initial value is GL_ZERO.
            /// </para>
            /// </param>
            public static 
            void BlendFuncSeparate(OpenTK.Graphics.ES11.All srcRGB, OpenTK.Graphics.ES11.All dstRGB, OpenTK.Graphics.ES11.All srcAlpha, OpenTK.Graphics.ES11.All dstAlpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glBlendFuncSeparateOES((OpenTK.Graphics.ES11.All)srcRGB, (OpenTK.Graphics.ES11.All)dstRGB, (OpenTK.Graphics.ES11.All)srcAlpha, (OpenTK.Graphics.ES11.All)dstAlpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Check the completeness status of a framebuffer
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specify the target of the framebuffer completeness check.
            /// </para>
            /// </param>
            public static 
            OpenTK.Graphics.ES11.All CheckFramebufferStatus(OpenTK.Graphics.ES11.All target)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glCheckFramebufferStatusOES((OpenTK.Graphics.ES11.All)target);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ClearAccumx(int red, int green, int blue, int alpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClearAccumxOES((int)red, (int)green, (int)blue, (int)alpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ClearColorx(int red, int green, int blue, int alpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClearColorxOES((int)red, (int)green, (int)blue, (int)alpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Specify the clear value for the depth buffer
            /// </summary>
            /// <param name="depth">
            /// <para>
            /// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
            /// </para>
            /// </param>
            public static 
            void ClearDepth(Single depth)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClearDepthfOES((Single)depth);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ClearDepthx(int depth)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClearDepthxOES((int)depth);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            public static 
            void ClipPlane(OpenTK.Graphics.ES11.All plane, Single[] equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* equation_ptr = equation)
                    {
                        Delegates.glClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            public static 
            void ClipPlane(OpenTK.Graphics.ES11.All plane, ref Single equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* equation_ptr = &equation)
                    {
                        Delegates.glClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Specify a plane against which all geometry is clipped
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies which clipping plane is being positioned. Symbolic names of the form GL_CLIP_PLANEi, where i is an integer between 0 and GL_MAX_CLIP_PLANES - 1, are accepted.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a plane equation.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ClipPlane(OpenTK.Graphics.ES11.All plane, Single* equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ClipPlanex(OpenTK.Graphics.ES11.All plane, int[] equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* equation_ptr = equation)
                    {
                        Delegates.glClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ClipPlanex(OpenTK.Graphics.ES11.All plane, ref int equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* equation_ptr = &equation)
                    {
                        Delegates.glClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ClipPlanex(OpenTK.Graphics.ES11.All plane, int* equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color3x(int red, int green, int blue)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glColor3xOES((int)red, (int)green, (int)blue);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color3x(int[] components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* components_ptr = components)
                    {
                        Delegates.glColor3xvOES((int*)components_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color3x(ref int components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* components_ptr = &components)
                    {
                        Delegates.glColor3xvOES((int*)components_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Color3x(int* components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glColor3xvOES((int*)components);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color4x(int red, int green, int blue, int alpha)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glColor4xOES((int)red, (int)green, (int)blue, (int)alpha);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color4x(int[] components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* components_ptr = components)
                    {
                        Delegates.glColor4xvOES((int*)components_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Color4x(ref int components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* components_ptr = &components)
                    {
                        Delegates.glColor4xvOES((int*)components_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Color4x(int* components)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glColor4xvOES((int*)components);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glConvolutionParameterxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void CurrentPaletteMatrix(Int32 matrixpaletteindex)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glCurrentPaletteMatrixOES((UInt32)matrixpaletteindex);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            [System.CLSCompliant(false)]
            public static 
            void CurrentPaletteMatrix(UInt32 matrixpaletteindex)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glCurrentPaletteMatrixOES((UInt32)matrixpaletteindex);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteFramebuffers(Int32 n, Int32[] framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = framebuffers)
                    {
                        Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteFramebuffers(Int32 n, ref Int32 framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = &framebuffers)
                    {
                        Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteFramebuffers(Int32 n, Int32* framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteFramebuffers(Int32 n, UInt32[] framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = framebuffers)
                    {
                        Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteFramebuffers(Int32 n, ref UInt32 framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = &framebuffers)
                    {
                        Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete framebuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="framebuffers">
            /// <para>
            /// A pointer to an array containing n framebuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteFramebuffersOES((Int32)n, (UInt32*)framebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteRenderbuffers(Int32 n, Int32[] renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = renderbuffers)
                    {
                        Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteRenderbuffers(Int32 n, ref Int32 renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = &renderbuffers)
                    {
                        Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteRenderbuffers(Int32 n, Int32* renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = renderbuffers)
                    {
                        Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteRenderbuffers(Int32 n, ref UInt32 renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = &renderbuffers)
                    {
                        Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Delete renderbuffer objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// A pointer to an array containing n renderbuffer objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteVertexArrays(Int32 n, Int32[] arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* arrays_ptr = arrays)
                    {
                        Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            public static 
            void DeleteVertexArrays(Int32 n, ref Int32 arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* arrays_ptr = &arrays)
                    {
                        Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteVertexArrays(Int32 n, Int32* arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteVertexArrays(Int32 n, UInt32[] arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* arrays_ptr = arrays)
                    {
                        Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void DeleteVertexArrays(Int32 n, ref UInt32 arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* arrays_ptr = &arrays)
                    {
                        Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Delete vertex array objects
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array objects to be deleted.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies the address of an array containing the n names of the objects to be deleted.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDeleteVertexArraysOES((Int32)n, (UInt32*)arrays);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Specify mapping of depth values from normalized device coordinates to window coordinates
            /// </summary>
            /// <param name="nearVal">
            /// <para>
            /// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
            /// </para>
            /// </param>
            /// <param name="farVal">
            /// <para>
            /// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
            /// </para>
            /// </param>
            public static 
            void DepthRange(Single n, Single f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDepthRangefOES((Single)n, (Single)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void DepthRangex(int n, int f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDepthRangexOES((int)n, (int)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Single x, Single y, Single z, Single width, Single height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexfOES((Single)x, (Single)y, (Single)z, (Single)width, (Single)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Single[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* coords_ptr = coords)
                    {
                        Delegates.glDrawTexfvOES((Single*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(ref Single coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* coords_ptr = &coords)
                    {
                        Delegates.glDrawTexfvOES((Single*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DrawTex(Single* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexfvOES((Single*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Int32 x, Int32 y, Int32 z, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexiOES((Int32)x, (Int32)y, (Int32)z, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Int32[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* coords_ptr = coords)
                    {
                        Delegates.glDrawTexivOES((Int32*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(ref Int32 coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* coords_ptr = &coords)
                    {
                        Delegates.glDrawTexivOES((Int32*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DrawTex(Int32* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexivOES((Int32*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Int16 x, Int16 y, Int16 z, Int16 width, Int16 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexsOES((Int16)x, (Int16)y, (Int16)z, (Int16)width, (Int16)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(Int16[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int16* coords_ptr = coords)
                    {
                        Delegates.glDrawTexsvOES((Int16*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTex(ref Int16 coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int16* coords_ptr = &coords)
                    {
                        Delegates.glDrawTexsvOES((Int16*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DrawTex(Int16* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexsvOES((Int16*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTexx(int x, int y, int z, int width, int height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexxOES((int)x, (int)y, (int)z, (int)width, (int)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTexx(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glDrawTexxvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            public static 
            void DrawTexx(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glDrawTexxvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_draw_texture]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void DrawTexx(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDrawTexxvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_EGL_image]</summary>
            public static 
            void EGLImageTargetRenderbufferStorage(OpenTK.Graphics.ES11.All target, IntPtr image)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEGLImageTargetRenderbufferStorageOES((OpenTK.Graphics.ES11.All)target, (IntPtr)image);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_EGL_image]</summary>
            public static 
            void EGLImageTargetTexture2D(OpenTK.Graphics.ES11.All target, IntPtr image)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEGLImageTargetTexture2DOES((OpenTK.Graphics.ES11.All)target, (IntPtr)image);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void EvalCoord1x(int u)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEvalCoord1xOES((int)u);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void EvalCoord1x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEvalCoord1xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void EvalCoord2x(int u, int v)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEvalCoord2xOES((int)u, (int)v);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void EvalCoord2x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glEvalCoord2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void EvalCoord2x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glEvalCoord2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void EvalCoord2x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEvalCoord2xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int[] buffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* buffer_ptr = buffer)
                    {
                        Delegates.glFeedbackBufferxOES((Int32)n, (OpenTK.Graphics.ES11.All)type, (int*)buffer_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, ref int buffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* buffer_ptr = &buffer)
                    {
                        Delegates.glFeedbackBufferxOES((Int32)n, (OpenTK.Graphics.ES11.All)type, (int*)buffer_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void FeedbackBufferx(Int32 n, OpenTK.Graphics.ES11.All type, int* buffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFeedbackBufferxOES((Int32)n, (OpenTK.Graphics.ES11.All)type, (int*)buffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Fogx(OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFogxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Fogx(OpenTK.Graphics.ES11.All pname, int[] param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* param_ptr = param)
                    {
                        Delegates.glFogxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Fogx(OpenTK.Graphics.ES11.All pname, int* param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFogxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Attach a renderbuffer as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment point of the framebuffer.
            /// </para>
            /// </param>
            /// <param name="renderbuffertarget">
            /// <para>
            /// Specifies the renderbuffer target and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
            /// </para>
            /// </param>
            public static 
            void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, Int32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferRenderbufferOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)renderbuffertarget, (UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Attach a renderbuffer as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the framebuffer target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment point of the framebuffer.
            /// </para>
            /// </param>
            /// <param name="renderbuffertarget">
            /// <para>
            /// Specifies the renderbuffer target and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void FramebufferRenderbuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All renderbuffertarget, UInt32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferRenderbufferOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)renderbuffertarget, (UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            public static 
            void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, Int32 texture, Int32 level)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]</summary>
            [System.CLSCompliant(false)]
            public static 
            void FramebufferTexture2D(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All textarget, UInt32 texture, Int32 level)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFramebufferTexture2DOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)textarget, (UInt32)texture, (Int32)level);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Multiply the current matrix by a perspective matrix
            /// </summary>
            /// <param name="left">
            /// <para>
            /// Specify the coordinates for the left and right vertical clipping planes.
            /// </para>
            /// </param>
            /// <param name="bottom">
            /// <para>
            /// Specify the coordinates for the bottom and top horizontal clipping planes.
            /// </para>
            /// </param>
            /// <param name="nearVal">
            /// <para>
            /// Specify the distances to the near and far depth clipping planes. Both distances must be positive.
            /// </para>
            /// </param>
            public static 
            void Frustum(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFrustumfOES((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Frustumx(int l, int r, int b, int t, int n, int f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glFrustumxOES((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate mipmaps for a specified texture target
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target to which the texture whose mimaps to generate is bound. target must be GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY or GL_TEXTURE_CUBE_MAP.
            /// </para>
            /// </param>
            public static 
            void GenerateMipmap(OpenTK.Graphics.ES11.All target)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenerateMipmapOES((OpenTK.Graphics.ES11.All)target);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenFramebuffers(Int32 n, [OutAttribute] Int32[] framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = framebuffers)
                    {
                        Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenFramebuffers(Int32 n, [OutAttribute] out Int32 framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = &framebuffers)
                    {
                        Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                        framebuffers = *framebuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenFramebuffers(Int32 n, [OutAttribute] Int32* framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = framebuffers)
                    {
                        Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenFramebuffers(Int32 n, [OutAttribute] out UInt32 framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = &framebuffers)
                    {
                        Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers_ptr);
                        framebuffers = *framebuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate framebuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of framebuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="ids">
            /// <para>
            /// Specifies an array in which the generated framebuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenFramebuffersOES((Int32)n, (UInt32*)framebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenRenderbuffers(Int32 n, [OutAttribute] Int32[] renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = renderbuffers)
                    {
                        Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenRenderbuffers(Int32 n, [OutAttribute] out Int32 renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = &renderbuffers)
                    {
                        Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                        renderbuffers = *renderbuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenRenderbuffers(Int32 n, [OutAttribute] Int32* renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = renderbuffers)
                    {
                        Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenRenderbuffers(Int32 n, [OutAttribute] out UInt32 renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = &renderbuffers)
                    {
                        Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers_ptr);
                        renderbuffers = *renderbuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Generate renderbuffer object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of renderbuffer object names to generate.
            /// </para>
            /// </param>
            /// <param name="renderbuffers">
            /// <para>
            /// Specifies an array in which the generated renderbuffer object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenRenderbuffersOES((Int32)n, (UInt32*)renderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenVertexArrays(Int32 n, [OutAttribute] Int32[] arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* arrays_ptr = arrays)
                    {
                        Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            public static 
            void GenVertexArrays(Int32 n, [OutAttribute] out Int32 arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* arrays_ptr = &arrays)
                    {
                        Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                        arrays = *arrays_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenVertexArrays(Int32 n, [OutAttribute] Int32* arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* arrays_ptr = arrays)
                    {
                        Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void GenVertexArrays(Int32 n, [OutAttribute] out UInt32 arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* arrays_ptr = &arrays)
                    {
                        Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays_ptr);
                        arrays = *arrays_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Generate vertex array object names
            /// </summary>
            /// <param name="n">
            /// <para>
            /// Specifies the number of vertex array object names to generate.
            /// </para>
            /// </param>
            /// <param name="arrays">
            /// <para>
            /// Specifies an array in which the generated vertex array object names are stored.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGenVertexArraysOES((Int32)n, (UInt32*)arrays);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            void GetBufferPointer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] IntPtr @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[] @params)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,] @params)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] T2[,,] @params)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            void GetBufferPointer<T2>(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [InAttribute, OutAttribute] ref T2 @params)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glGetBufferPointervOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (IntPtr)@params_ptr.AddrOfPinnedObject());
                    @params = (T2)@params_ptr.Target;
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            public static 
            void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single[] equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* equation_ptr = equation)
                    {
                        Delegates.glGetClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            public static 
            void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] out Single equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* equation_ptr = &equation)
                    {
                        Delegates.glGetClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation_ptr);
                        equation = *equation_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Return the coefficients of the specified clipping plane
            /// </summary>
            /// <param name="plane">
            /// <para>
            /// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping planes are supported. They are identified by symbolic names of the form GL_CLIP_PLANE where i ranges from 0 to the value of GL_MAX_CLIP_PLANES - 1.
            /// </para>
            /// </param>
            /// <param name="equation">
            /// <para>
            /// Returns four double-precision values that are the coefficients of the plane equation of plane in eye coordinates. The initial value is (0, 0, 0, 0).
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetClipPlane(OpenTK.Graphics.ES11.All plane, [OutAttribute] Single* equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetClipPlanefOES((OpenTK.Graphics.ES11.All)plane, (Single*)equation);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int[] equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* equation_ptr = equation)
                    {
                        Delegates.glGetClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] out int equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* equation_ptr = &equation)
                    {
                        Delegates.glGetClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation_ptr);
                        equation = *equation_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetClipPlanex(OpenTK.Graphics.ES11.All plane, [OutAttribute] int* equation)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetClipPlanexOES((OpenTK.Graphics.ES11.All)plane, (int*)equation);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetConvolutionParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetConvolutionParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetFixedvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetFixedvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetFixed(OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetFixedvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            public static 
            void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetFramebufferAttachmentParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            public static 
            void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetFramebufferAttachmentParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about attachments of a bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation.
            /// </para>
            /// </param>
            /// <param name="attachment">
            /// <para>
            /// Specifies the attachment within target
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter of attachment to query.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of a variable receive the value of pname for attachment.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetFramebufferAttachmentParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All attachment, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetFramebufferAttachmentParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)attachment, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetHistogramParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetHistogramParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetHistogramParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetHistogramParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetLightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int[] v)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* v_ptr = v)
                    {
                        Delegates.glGetMapxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)query, (int*)v_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] out int v)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* v_ptr = &v)
                    {
                        Delegates.glGetMapxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)query, (int*)v_ptr);
                        v = *v_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetMapx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All query, [OutAttribute] int* v)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetMapxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)query, (int*)v);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetMaterialxOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetMaterialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            public static 
            void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetRenderbufferParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            public static 
            void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetRenderbufferParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Retrieve information about a bound renderbuffer object
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target of the query operation. target must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the parameter whose value to retrieve from the renderbuffer bound to target.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Specifies the address of an array to receive the value of the queried parameter.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetRenderbufferParameter(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetRenderbufferParameterivOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            public static 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = @params)
                    {
                        Delegates.glGetTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            public static 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Single @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = &@params)
                    {
                        Delegates.glGetTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Single* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            public static 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glGetTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            public static 
            void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glGetTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Return texture coordinate generation parameters
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the value(s) to be returned. Must be either GL_TEXTURE_GEN_MODE or the name of one of the texture generation plane equations: GL_OBJECT_PLANE or GL_EYE_PLANE.
            /// </para>
            /// </param>
            /// <param name="params">
            /// <para>
            /// Returns the requested data.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            public static 
            void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            public static 
            void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetTexLevelParameterxvOES((OpenTK.Graphics.ES11.All)target, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetTexLevelParameterxvOES((OpenTK.Graphics.ES11.All)target, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexLevelParameterx(OpenTK.Graphics.ES11.All target, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexLevelParameterxvOES((OpenTK.Graphics.ES11.All)target, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glGetTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] out int @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = &@params)
                    {
                        Delegates.glGetTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetTexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, [OutAttribute] int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Indexx(int component)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glIndexxOES((int)component);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Indexx(int* component)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glIndexxvOES((int*)component);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            public static 
            bool IsFramebuffer(Int32 framebuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsFramebufferOES((UInt32)framebuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a framebuffer object
            /// </summary>
            /// <param name="framebuffer">
            /// <para>
            /// Specifies a value that may be the name of a framebuffer object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            bool IsFramebuffer(UInt32 framebuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsFramebufferOES((UInt32)framebuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            public static 
            bool IsRenderbuffer(Int32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsRenderbufferOES((UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Determine if a name corresponds to a renderbuffer object
            /// </summary>
            /// <param name="renderbuffer">
            /// <para>
            /// Specifies a value that may be the name of a renderbuffer object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            bool IsRenderbuffer(UInt32 renderbuffer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsRenderbufferOES((UInt32)renderbuffer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            public static 
            bool IsVertexArray(Int32 array)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsVertexArrayOES((UInt32)array);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_vertex_array_object]
            /// Determine if a name corresponds to a vertex array object
            /// </summary>
            /// <param name="array">
            /// <para>
            /// Specifies a value that may be the name of a vertex array object.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            bool IsVertexArray(UInt32 array)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glIsVertexArrayOES((UInt32)array);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LightModelx(OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLightModelxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LightModelx(OpenTK.Graphics.ES11.All pname, int[] param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* param_ptr = param)
                    {
                        Delegates.glLightModelxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void LightModelx(OpenTK.Graphics.ES11.All pname, int* param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLightModelxvOES((OpenTK.Graphics.ES11.All)pname, (int*)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLightxOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glLightxvOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Lightx(OpenTK.Graphics.ES11.All light, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLightxvOES((OpenTK.Graphics.ES11.All)light, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LineWidthx(int width)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLineWidthxOES((int)width);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LoadMatrixx(int[] m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = m)
                    {
                        Delegates.glLoadMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LoadMatrixx(ref int m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = &m)
                    {
                        Delegates.glLoadMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void LoadMatrixx(int* m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLoadMatrixxOES((int*)m);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void LoadPaletteFromModelViewMatrix()
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLoadPaletteFromModelViewMatrixOES();
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LoadTransposeMatrixx(int[] m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = m)
                    {
                        Delegates.glLoadTransposeMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void LoadTransposeMatrixx(ref int m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = &m)
                    {
                        Delegates.glLoadTransposeMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void LoadTransposeMatrixx(int* m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glLoadTransposeMatrixxOES((int*)m);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Map1x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 stride, Int32 order, int points)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMap1xOES((OpenTK.Graphics.ES11.All)target, (int)u1, (int)u2, (Int32)stride, (Int32)order, (int)points);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Map2x(OpenTK.Graphics.ES11.All target, int u1, int u2, Int32 ustride, Int32 uorder, int v1, int v2, Int32 vstride, Int32 vorder, int points)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMap2xOES((OpenTK.Graphics.ES11.All)target, (int)u1, (int)u2, (Int32)ustride, (Int32)uorder, (int)v1, (int)v2, (Int32)vstride, (Int32)vorder, (int)points);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]
            /// Map a buffer object's data store
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the target buffer object being mapped. The symbolic constant must be GL_ARRAY_BUFFER, GL_ATOMIC_COUNTER_BUFFER, GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, GL_DRAW_INDIRECT_BUFFER, GL_DISPATCH_INDIRECT_BUFFER, GL_ELEMENT_ARRAY_BUFFER, GL_PIXEL_PACK_BUFFER, GL_PIXEL_UNPACK_BUFFER, GL_QUERY_BUFFER, GL_SHADER_STORAGE_BUFFER, GL_TEXTURE_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER or GL_UNIFORM_BUFFER.
            /// </para>
            /// </param>
            /// <param name="access">
            /// <para>
            /// For glMapBuffer only, specifies the access policy, indicating whether it will be possible to read from, write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE.
            /// </para>
            /// </param>
            public static 
            IntPtr MapBuffer(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All access)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glMapBufferOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)access);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MapGrid1x(Int32 n, int u1, int u2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMapGrid1xOES((Int32)n, (int)u1, (int)u2);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MapGrid2x(Int32 n, int u1, int u2, int v1, int v2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMapGrid2xOES((Int32)n, (int)u1, (int)u2, (int)v1, (int)v2);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMaterialxOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int[] param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* param_ptr = param)
                    {
                        Delegates.glMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Materialx(OpenTK.Graphics.ES11.All face, OpenTK.Graphics.ES11.All pname, int* param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMaterialxvOES((OpenTK.Graphics.ES11.All)face, (OpenTK.Graphics.ES11.All)pname, (int*)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void MatrixIndexPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void MatrixIndexPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glMatrixIndexPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                    pointer = (T3)pointer_ptr.Target;
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord1(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1xOES((OpenTK.Graphics.ES11.All)texture, (int)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord1x(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord1xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte s, Byte t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte s, SByte t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord2(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int s, int t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord2xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord2xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord2x(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord2xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord3(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int s, int t, int r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord3xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord3xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord3x(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord3xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte s, Byte t, Byte r, Byte q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r, (SByte)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte s, SByte t, SByte r, SByte q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4bOES((OpenTK.Graphics.ES11.All)texture, (SByte)s, (SByte)t, (SByte)r, (SByte)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation dependent, but must be at least two. Symbolic constant must be one of GL_TEXTURE, where i ranges from 0 to GL_MAX_TEXTURE_COORDS - 1, which is an implementation-dependent value.
            /// </para>
            /// </param>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates for target texture unit. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord4(OpenTK.Graphics.ES11.All texture, SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4bvOES((OpenTK.Graphics.ES11.All)texture, (SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int s, int t, int r, int q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4xOES((OpenTK.Graphics.ES11.All)texture, (int)s, (int)t, (int)r, (int)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glMultiTexCoord4xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glMultiTexCoord4xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultiTexCoord4x(OpenTK.Graphics.ES11.All texture, int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultiTexCoord4xvOES((OpenTK.Graphics.ES11.All)texture, (int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultMatrixx(int[] m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = m)
                    {
                        Delegates.glMultMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultMatrixx(ref int m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = &m)
                    {
                        Delegates.glMultMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultMatrixx(int* m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultMatrixxOES((int*)m);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultTransposeMatrixx(int[] m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = m)
                    {
                        Delegates.glMultTransposeMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void MultTransposeMatrixx(ref int m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* m_ptr = &m)
                    {
                        Delegates.glMultTransposeMatrixxOES((int*)m_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void MultTransposeMatrixx(int* m)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glMultTransposeMatrixxOES((int*)m);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Normal3x(int nx, int ny, int nz)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glNormal3xOES((int)nx, (int)ny, (int)nz);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Normal3x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glNormal3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Normal3x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glNormal3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Normal3x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glNormal3xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_single_precision]
            /// Multiply the current matrix with an orthographic matrix
            /// </summary>
            /// <param name="left">
            /// <para>
            /// Specify the coordinates for the left and right vertical clipping planes.
            /// </para>
            /// </param>
            /// <param name="bottom">
            /// <para>
            /// Specify the coordinates for the bottom and top horizontal clipping planes.
            /// </para>
            /// </param>
            /// <param name="nearVal">
            /// <para>
            /// Specify the distances to the nearer and farther depth clipping planes. These values are negative if the plane is to be behind the viewer.
            /// </para>
            /// </param>
            public static 
            void Ortho(Single l, Single r, Single b, Single t, Single n, Single f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glOrthofOES((Single)l, (Single)r, (Single)b, (Single)t, (Single)n, (Single)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Orthox(int l, int r, int b, int t, int n, int f)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glOrthoxOES((int)l, (int)r, (int)b, (int)t, (int)n, (int)f);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PassThroughx(int token)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPassThroughxOES((int)token);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PixelTransferx(OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPixelTransferxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PixelZoomx(int xfactor, int yfactor)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPixelZoomxOES((int)xfactor, (int)yfactor);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PointParameterx(OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPointParameterxOES((OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PointParameterx(OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glPointParameterxvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void PointParameterx(OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPointParameterxvOES((OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_point_size_array]</summary>
            public static 
            void PointSizePointer(OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_point_size_array]</summary>
            public static 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[] pointer)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_point_size_array]</summary>
            public static 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,] pointer)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_point_size_array]</summary>
            public static 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T2[,,] pointer)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_point_size_array]</summary>
            public static 
            void PointSizePointer<T2>(OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T2 pointer)
                where T2 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glPointSizePointerOES((OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                    pointer = (T2)pointer_ptr.Target;
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PointSizex(int size)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPointSizexOES((int)size);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PolygonOffsetx(int factor, int units)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPolygonOffsetxOES((int)factor, (int)units);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PrioritizeTexturesx(Int32 n, Int32[] textures, int[] priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* textures_ptr = textures)
                    fixed (int* priorities_ptr = priorities)
                    {
                        Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures_ptr, (int*)priorities_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void PrioritizeTexturesx(Int32 n, ref Int32 textures, ref int priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* textures_ptr = &textures)
                    fixed (int* priorities_ptr = &priorities)
                    {
                        Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures_ptr, (int*)priorities_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void PrioritizeTexturesx(Int32 n, Int32* textures, int* priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures, (int*)priorities);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            void PrioritizeTexturesx(Int32 n, UInt32[] textures, int[] priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* textures_ptr = textures)
                    fixed (int* priorities_ptr = priorities)
                    {
                        Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures_ptr, (int*)priorities_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            void PrioritizeTexturesx(Int32 n, ref UInt32 textures, ref int priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* textures_ptr = &textures)
                    fixed (int* priorities_ptr = &priorities)
                    {
                        Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures_ptr, (int*)priorities_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void PrioritizeTexturesx(Int32 n, UInt32* textures, int* priorities)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glPrioritizeTexturesxOES((Int32)n, (UInt32*)textures, (int*)priorities);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_query_matrix]</summary>
            public static 
            Int32 QueryMatrixx([OutAttribute] int[] mantissa, [OutAttribute] Int32[] exponent)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* mantissa_ptr = mantissa)
                    fixed (Int32* exponent_ptr = exponent)
                    {
                        return Delegates.glQueryMatrixxOES((int*)mantissa_ptr, (Int32*)exponent_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_query_matrix]</summary>
            public static 
            Int32 QueryMatrixx([OutAttribute] out int mantissa, [OutAttribute] out Int32 exponent)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* mantissa_ptr = &mantissa)
                    fixed (Int32* exponent_ptr = &exponent)
                    {
                        Int32 retval = Delegates.glQueryMatrixxOES((int*)mantissa_ptr, (Int32*)exponent_ptr);
                        mantissa = *mantissa_ptr;
                        exponent = *exponent_ptr;
                        return retval;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_query_matrix]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe Int32 QueryMatrixx([OutAttribute] int* mantissa, [OutAttribute] Int32* exponent)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glQueryMatrixxOES((int*)mantissa, (Int32*)exponent);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos2x(int x, int y)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos2xOES((int)x, (int)y);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos2x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glRasterPos2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos2x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glRasterPos2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void RasterPos2x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos2xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos3x(int x, int y, int z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos3xOES((int)x, (int)y, (int)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos3x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glRasterPos3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos3x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glRasterPos3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void RasterPos3x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos3xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos4x(int x, int y, int z, int w)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos4xOES((int)x, (int)y, (int)z, (int)w);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos4x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glRasterPos4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void RasterPos4x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glRasterPos4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void RasterPos4x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRasterPos4xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Rectx(int x1, int y1, int x2, int y2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRectxOES((int)x1, (int)y1, (int)x2, (int)y2);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Rectx(int[] v1, int[] v2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* v1_ptr = v1)
                    fixed (int* v2_ptr = v2)
                    {
                        Delegates.glRectxvOES((int*)v1_ptr, (int*)v2_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Rectx(ref int v1, ref int v2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* v1_ptr = &v1)
                    fixed (int* v2_ptr = &v2)
                    {
                        Delegates.glRectxvOES((int*)v1_ptr, (int*)v2_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Rectx(int* v1, int* v2)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRectxvOES((int*)v1, (int*)v2);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_framebuffer_object]
            /// Establish data storage, format and dimensions of a renderbuffer object's image
            /// </summary>
            /// <param name="target">
            /// <para>
            /// Specifies a binding to which the target of the allocation and must be GL_RENDERBUFFER.
            /// </para>
            /// </param>
            /// <param name="internalformat">
            /// <para>
            /// Specifies the internal format to use for the renderbuffer object's image.
            /// </para>
            /// </param>
            /// <param name="width">
            /// <para>
            /// Specifies the width of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            /// <param name="height">
            /// <para>
            /// Specifies the height of the renderbuffer, in pixels.
            /// </para>
            /// </param>
            public static 
            void RenderbufferStorage(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All internalformat, Int32 width, Int32 height)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRenderbufferStorageOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)internalformat, (Int32)width, (Int32)height);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Rotatex(int angle, int x, int y, int z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glRotatexOES((int)angle, (int)x, (int)y, (int)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]
            /// Specify multisample coverage parameters
            /// </summary>
            /// <param name="value">
            /// <para>
            /// Specify a single floating-point sample coverage value. The value is clamped to the range [0 ,1]. The initial value is 1.0.
            /// </para>
            /// </param>
            /// <param name="invert">
            /// <para>
            /// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE.
            /// </para>
            /// </param>
            public static 
            void SampleCoverage(int value, bool invert)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glSampleCoverageOES((int)value, (bool)invert);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void SampleCoveragex(int value, bool invert)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glSampleCoveragexOES((int)value, (bool)invert);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Scalex(int x, int y, int z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glScalexOES((int)x, (int)y, (int)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord1(Byte s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1bOES((SByte)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord1(SByte s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1bOES((SByte)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord1(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord1(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord1x(int s)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1xOES((int)s);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord1x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord1xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord2(Byte s, Byte t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2bOES((SByte)s, (SByte)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord2(SByte s, SByte t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2bOES((SByte)s, (SByte)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord2(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord2(ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord2(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord2(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord2(ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord2(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord2x(int s, int t)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2xOES((int)s, (int)t);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord2x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glTexCoord2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord2x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord2x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord2xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord3(Byte s, Byte t, Byte r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3bOES((SByte)s, (SByte)t, (SByte)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord3(SByte s, SByte t, SByte r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3bOES((SByte)s, (SByte)t, (SByte)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord3(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord3(ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord3(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord3(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord3(ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord3(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord3x(int s, int t, int r)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3xOES((int)s, (int)t, (int)r);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord3x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glTexCoord3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord3x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord3x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord3xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord4(Byte s, Byte t, Byte r, Byte q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4bOES((SByte)s, (SByte)t, (SByte)r, (SByte)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord4(SByte s, SByte t, SByte r, SByte q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4bOES((SByte)s, (SByte)t, (SByte)r, (SByte)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord4(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void TexCoord4(ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord4(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord4(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glTexCoord4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void TexCoord4(ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Set the current texture coordinates
            /// </summary>
            /// <param name="s">
            /// <para>
            /// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord4(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord4x(int s, int t, int r, int q)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4xOES((int)s, (int)t, (int)r, (int)q);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord4x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glTexCoord4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexCoord4x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glTexCoord4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexCoord4x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexCoord4xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexEnvxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexEnvx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexEnvxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            public static 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGenfOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            public static 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Single* @params_ptr = @params)
                    {
                        Delegates.glTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Single* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGenfvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Single*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            public static 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32 param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGeniOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            public static 
            void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_texture_cube_map]
            /// Control the generation of texture coordinates
            /// </summary>
            /// <param name="coord">
            /// <para>
            /// Specifies a texture coordinate. Must be one of GL_S, GL_T, GL_R, or GL_Q.
            /// </para>
            /// </param>
            /// <param name="pname">
            /// <para>
            /// Specifies the symbolic name of the texture-coordinate generation function. Must be GL_TEXTURE_GEN_MODE.
            /// </para>
            /// </param>
            /// <param name="param">
            /// <para>
            /// Specifies a single-valued texture generation parameter, one of GL_OBJECT_LINEAR, GL_EYE_LINEAR, GL_SPHERE_MAP, GL_NORMAL_MAP, or GL_REFLECTION_MAP.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexGen(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGenivOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            public static 
            void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGenxOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            public static 
            void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point|OES_texture_cube_map]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexGenx(OpenTK.Graphics.ES11.All coord, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexGenxvOES((OpenTK.Graphics.ES11.All)coord, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexParameterxOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* @params_ptr = @params)
                    {
                        Delegates.glTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void TexParameterx(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, int* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTexParameterxvOES((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (int*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Translatex(int x, int y, int z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glTranslatexOES((int)x, (int)y, (int)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_mapbuffer]</summary>
            public static 
            bool UnmapBuffer(OpenTK.Graphics.ES11.All target)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glUnmapBufferOES((OpenTK.Graphics.ES11.All)target);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex2(Byte x)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2bOES((SByte)x);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex2(SByte x)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2bOES((SByte)x);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex2(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glVertex2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex2(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex2(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glVertex2bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex2(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex2x(int x)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2xOES((int)x);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex2x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glVertex2xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex2x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex2xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex3(Byte x, Byte y)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3bOES((SByte)x, (SByte)y);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex3(SByte x, SByte y)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3bOES((SByte)x, (SByte)y);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex3(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glVertex3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex3(ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glVertex3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex3(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex3(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glVertex3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex3(ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glVertex3bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex3(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex3x(int x, int y)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3xOES((int)x, (int)y);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex3x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glVertex3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex3x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glVertex3xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex3x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex3xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex4(Byte x, Byte y, Byte z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4bOES((SByte)x, (SByte)y, (SByte)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex4(SByte x, SByte y, SByte z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4bOES((SByte)x, (SByte)y, (SByte)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex4(Byte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = coords)
                    {
                        Delegates.glVertex4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            public static 
            void Vertex4(ref Byte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Byte* coords_ptr = &coords)
                    {
                        Delegates.glVertex4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex4(Byte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex4(SByte[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = coords)
                    {
                        Delegates.glVertex4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            void Vertex4(ref SByte coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (SByte* coords_ptr = &coords)
                    {
                        Delegates.glVertex4bvOES((SByte*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_byte_coordinates]
            /// Specify a vertex
            /// </summary>
            /// <param name="x">
            /// <para>
            /// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
            /// </para>
            /// </param>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex4(SByte* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4bvOES((SByte*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex4x(int x, int y, int z)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4xOES((int)x, (int)y, (int)z);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex4x(int[] coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = coords)
                    {
                        Delegates.glVertex4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            public static 
            void Vertex4x(ref int coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (int* coords_ptr = &coords)
                    {
                        Delegates.glVertex4xvOES((int*)coords_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_fixed_point]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void Vertex4x(int* coords)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glVertex4xvOES((int*)coords);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void WeightPointer(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, IntPtr pointer)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] T3[,,] pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: OES_matrix_palette]</summary>
            public static 
            void WeightPointer<T3>(Int32 size, OpenTK.Graphics.ES11.All type, Int32 stride, [InAttribute, OutAttribute] ref T3 pointer)
                where T3 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle pointer_ptr = GCHandle.Alloc(pointer, GCHandleType.Pinned);
                try
                {
                    Delegates.glWeightPointerOES((Int32)size, (OpenTK.Graphics.ES11.All)type, (Int32)stride, (IntPtr)pointer_ptr.AddrOfPinnedObject());
                    pointer = (T3)pointer_ptr.Target;
                }
                finally
                {
                    pointer_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

        }

        public static partial class Qcom
        {
            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void DisableDriverControl(Int32 driverControl)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDisableDriverControlQCOM((UInt32)driverControl);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void DisableDriverControl(UInt32 driverControl)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glDisableDriverControlQCOM((UInt32)driverControl);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void EnableDriverControl(Int32 driverControl)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEnableDriverControlQCOM((UInt32)driverControl);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void EnableDriverControl(UInt32 driverControl)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEnableDriverControlQCOM((UInt32)driverControl);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            public static 
            void EndTiling(Int32 preserveMask)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEndTilingQCOM((UInt32)preserveMask);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            public static 
            void EndTiling(UInt32 preserveMask)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glEndTilingQCOM((UInt32)preserveMask);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBufferPointer(OpenTK.Graphics.ES11.All target, [OutAttribute] IntPtr @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[] @params)
                where T1 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,] @params)
                where T1 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] T1[,,] @params)
                where T1 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBufferPointer<T1>(OpenTK.Graphics.ES11.All target, [InAttribute, OutAttribute] ref T1 @params)
                where T1 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle @params_ptr = GCHandle.Alloc(@params, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetBufferPointervQCOM((OpenTK.Graphics.ES11.All)target, (IntPtr)@params_ptr.AddrOfPinnedObject());
                    @params = (T1)@params_ptr.Target;
                }
                finally
                {
                    @params_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBuffers([OutAttribute] Int32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* buffers_ptr = buffers)
                    fixed (Int32* numBuffers_ptr = numBuffers)
                    {
                        Delegates.glExtGetBuffersQCOM((UInt32*)buffers_ptr, (Int32)maxBuffers, (Int32*)numBuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetBuffers([OutAttribute] out Int32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* buffers_ptr = &buffers)
                    fixed (Int32* numBuffers_ptr = &numBuffers)
                    {
                        Delegates.glExtGetBuffersQCOM((UInt32*)buffers_ptr, (Int32)maxBuffers, (Int32*)numBuffers_ptr);
                        buffers = *buffers_ptr;
                        numBuffers = *numBuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetBuffers([OutAttribute] Int32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetBuffersQCOM((UInt32*)buffers, (Int32)maxBuffers, (Int32*)numBuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetBuffers([OutAttribute] UInt32[] buffers, Int32 maxBuffers, [OutAttribute] Int32[] numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* buffers_ptr = buffers)
                    fixed (Int32* numBuffers_ptr = numBuffers)
                    {
                        Delegates.glExtGetBuffersQCOM((UInt32*)buffers_ptr, (Int32)maxBuffers, (Int32*)numBuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetBuffers([OutAttribute] out UInt32 buffers, Int32 maxBuffers, [OutAttribute] out Int32 numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* buffers_ptr = &buffers)
                    fixed (Int32* numBuffers_ptr = &numBuffers)
                    {
                        Delegates.glExtGetBuffersQCOM((UInt32*)buffers_ptr, (Int32)maxBuffers, (Int32*)numBuffers_ptr);
                        buffers = *buffers_ptr;
                        numBuffers = *numBuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetBuffers([OutAttribute] UInt32* buffers, Int32 maxBuffers, [OutAttribute] Int32* numBuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetBuffersQCOM((UInt32*)buffers, (Int32)maxBuffers, (Int32*)numBuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetFramebuffers([OutAttribute] Int32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = framebuffers)
                    fixed (Int32* numFramebuffers_ptr = numFramebuffers)
                    {
                        Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers_ptr, (Int32)maxFramebuffers, (Int32*)numFramebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetFramebuffers([OutAttribute] out Int32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* framebuffers_ptr = &framebuffers)
                    fixed (Int32* numFramebuffers_ptr = &numFramebuffers)
                    {
                        Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers_ptr, (Int32)maxFramebuffers, (Int32*)numFramebuffers_ptr);
                        framebuffers = *framebuffers_ptr;
                        numFramebuffers = *numFramebuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetFramebuffers([OutAttribute] Int32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers, (Int32)maxFramebuffers, (Int32*)numFramebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetFramebuffers([OutAttribute] UInt32[] framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32[] numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = framebuffers)
                    fixed (Int32* numFramebuffers_ptr = numFramebuffers)
                    {
                        Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers_ptr, (Int32)maxFramebuffers, (Int32*)numFramebuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetFramebuffers([OutAttribute] out UInt32 framebuffers, Int32 maxFramebuffers, [OutAttribute] out Int32 numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* framebuffers_ptr = &framebuffers)
                    fixed (Int32* numFramebuffers_ptr = &numFramebuffers)
                    {
                        Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers_ptr, (Int32)maxFramebuffers, (Int32*)numFramebuffers_ptr);
                        framebuffers = *framebuffers_ptr;
                        numFramebuffers = *numFramebuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetFramebuffers([OutAttribute] UInt32* framebuffers, Int32 maxFramebuffers, [OutAttribute] Int32* numFramebuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetFramebuffersQCOM((UInt32*)framebuffers, (Int32)maxFramebuffers, (Int32*)numFramebuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = length)
                    {
                        Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = &length)
                    {
                        Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length_ptr);
                        length = *length_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetProgramBinarySource(Int32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32[] length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = length)
                    {
                        Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] out Int32 length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = &length)
                    {
                        Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length_ptr);
                        length = *length_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetProgramBinarySource(UInt32 program, OpenTK.Graphics.ES11.All shadertype, [OutAttribute] StringBuilder source, [OutAttribute] Int32* length)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetProgramBinarySourceQCOM((UInt32)program, (OpenTK.Graphics.ES11.All)shadertype, (StringBuilder)source, (Int32*)length);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetProgram([OutAttribute] Int32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* programs_ptr = programs)
                    fixed (Int32* numPrograms_ptr = numPrograms)
                    {
                        Delegates.glExtGetProgramsQCOM((UInt32*)programs_ptr, (Int32)maxPrograms, (Int32*)numPrograms_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetProgram([OutAttribute] out Int32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* programs_ptr = &programs)
                    fixed (Int32* numPrograms_ptr = &numPrograms)
                    {
                        Delegates.glExtGetProgramsQCOM((UInt32*)programs_ptr, (Int32)maxPrograms, (Int32*)numPrograms_ptr);
                        programs = *programs_ptr;
                        numPrograms = *numPrograms_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetProgram([OutAttribute] Int32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetProgramsQCOM((UInt32*)programs, (Int32)maxPrograms, (Int32*)numPrograms);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetProgram([OutAttribute] UInt32[] programs, Int32 maxPrograms, [OutAttribute] Int32[] numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* programs_ptr = programs)
                    fixed (Int32* numPrograms_ptr = numPrograms)
                    {
                        Delegates.glExtGetProgramsQCOM((UInt32*)programs_ptr, (Int32)maxPrograms, (Int32*)numPrograms_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetProgram([OutAttribute] out UInt32 programs, Int32 maxPrograms, [OutAttribute] out Int32 numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* programs_ptr = &programs)
                    fixed (Int32* numPrograms_ptr = &numPrograms)
                    {
                        Delegates.glExtGetProgramsQCOM((UInt32*)programs_ptr, (Int32)maxPrograms, (Int32*)numPrograms_ptr);
                        programs = *programs_ptr;
                        numPrograms = *numPrograms_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetProgram([OutAttribute] UInt32* programs, Int32 maxPrograms, [OutAttribute] Int32* numPrograms)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetProgramsQCOM((UInt32*)programs, (Int32)maxPrograms, (Int32*)numPrograms);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetRenderbuffers([OutAttribute] Int32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = renderbuffers)
                    fixed (Int32* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers_ptr, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetRenderbuffers([OutAttribute] out Int32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* renderbuffers_ptr = &renderbuffers)
                    fixed (Int32* numRenderbuffers_ptr = &numRenderbuffers)
                    {
                        Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers_ptr, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers_ptr);
                        renderbuffers = *renderbuffers_ptr;
                        numRenderbuffers = *numRenderbuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetRenderbuffers([OutAttribute] Int32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetRenderbuffers([OutAttribute] UInt32[] renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32[] numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = renderbuffers)
                    fixed (Int32* numRenderbuffers_ptr = numRenderbuffers)
                    {
                        Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers_ptr, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetRenderbuffers([OutAttribute] out UInt32 renderbuffers, Int32 maxRenderbuffers, [OutAttribute] out Int32 numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* renderbuffers_ptr = &renderbuffers)
                    fixed (Int32* numRenderbuffers_ptr = &numRenderbuffers)
                    {
                        Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers_ptr, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers_ptr);
                        renderbuffers = *renderbuffers_ptr;
                        numRenderbuffers = *numRenderbuffers_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetRenderbuffers([OutAttribute] UInt32* renderbuffers, Int32 maxRenderbuffers, [OutAttribute] Int32* numRenderbuffers)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetRenderbuffersQCOM((UInt32*)renderbuffers, (Int32)maxRenderbuffers, (Int32*)numRenderbuffers);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetShaders([OutAttribute] Int32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* shaders_ptr = shaders)
                    fixed (Int32* numShaders_ptr = numShaders)
                    {
                        Delegates.glExtGetShadersQCOM((UInt32*)shaders_ptr, (Int32)maxShaders, (Int32*)numShaders_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            void ExtGetShaders([OutAttribute] out Int32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* shaders_ptr = &shaders)
                    fixed (Int32* numShaders_ptr = &numShaders)
                    {
                        Delegates.glExtGetShadersQCOM((UInt32*)shaders_ptr, (Int32)maxShaders, (Int32*)numShaders_ptr);
                        shaders = *shaders_ptr;
                        numShaders = *numShaders_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetShaders([OutAttribute] Int32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetShadersQCOM((UInt32*)shaders, (Int32)maxShaders, (Int32*)numShaders);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetShaders([OutAttribute] UInt32[] shaders, Int32 maxShaders, [OutAttribute] Int32[] numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* shaders_ptr = shaders)
                    fixed (Int32* numShaders_ptr = numShaders)
                    {
                        Delegates.glExtGetShadersQCOM((UInt32*)shaders_ptr, (Int32)maxShaders, (Int32*)numShaders_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetShaders([OutAttribute] out UInt32 shaders, Int32 maxShaders, [OutAttribute] out Int32 numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* shaders_ptr = &shaders)
                    fixed (Int32* numShaders_ptr = &numShaders)
                    {
                        Delegates.glExtGetShadersQCOM((UInt32*)shaders_ptr, (Int32)maxShaders, (Int32*)numShaders_ptr);
                        shaders = *shaders_ptr;
                        numShaders = *numShaders_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetShaders([OutAttribute] UInt32* shaders, Int32 maxShaders, [OutAttribute] Int32* numShaders)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetShadersQCOM((UInt32*)shaders, (Int32)maxShaders, (Int32*)numShaders);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetTexLevelParameter(Int32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32[] @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = @params)
                    {
                        Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] out Int32 @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* @params_ptr = &@params)
                    {
                        Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params_ptr);
                        @params = *@params_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetTexLevelParameter(UInt32 texture, OpenTK.Graphics.ES11.All face, Int32 level, OpenTK.Graphics.ES11.All pname, [OutAttribute] Int32* @params)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetTexLevelParameterivQCOM((UInt32)texture, (OpenTK.Graphics.ES11.All)face, (Int32)level, (OpenTK.Graphics.ES11.All)pname, (Int32*)@params);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexSubImage(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [OutAttribute] IntPtr texels)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[] texels)
                where T10 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle texels_ptr = GCHandle.Alloc(texels, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    texels_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,] texels)
                where T10 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle texels_ptr = GCHandle.Alloc(texels, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    texels_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] T10[,,] texels)
                where T10 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle texels_ptr = GCHandle.Alloc(texels, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels_ptr.AddrOfPinnedObject());
                }
                finally
                {
                    texels_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTexSubImage<T10>(OpenTK.Graphics.ES11.All target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, OpenTK.Graphics.ES11.All format, OpenTK.Graphics.ES11.All type, [InAttribute, OutAttribute] ref T10 texels)
                where T10 : struct
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                GCHandle texels_ptr = GCHandle.Alloc(texels, GCHandleType.Pinned);
                try
                {
                    Delegates.glExtGetTexSubImageQCOM((OpenTK.Graphics.ES11.All)target, (Int32)level, (Int32)xoffset, (Int32)yoffset, (Int32)zoffset, (Int32)width, (Int32)height, (Int32)depth, (OpenTK.Graphics.ES11.All)format, (OpenTK.Graphics.ES11.All)type, (IntPtr)texels_ptr.AddrOfPinnedObject());
                    texels = (T10)texels_ptr.Target;
                }
                finally
                {
                    texels_ptr.Free();
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTextures([OutAttribute] Int32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* textures_ptr = textures)
                    fixed (Int32* numTextures_ptr = numTextures)
                    {
                        Delegates.glExtGetTexturesQCOM((UInt32*)textures_ptr, (Int32)maxTextures, (Int32*)numTextures_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtGetTextures([OutAttribute] out Int32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* textures_ptr = &textures)
                    fixed (Int32* numTextures_ptr = &numTextures)
                    {
                        Delegates.glExtGetTexturesQCOM((UInt32*)textures_ptr, (Int32)maxTextures, (Int32*)numTextures_ptr);
                        textures = *textures_ptr;
                        numTextures = *numTextures_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetTextures([OutAttribute] Int32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetTexturesQCOM((UInt32*)textures, (Int32)maxTextures, (Int32*)numTextures);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetTextures([OutAttribute] UInt32[] textures, Int32 maxTextures, [OutAttribute] Int32[] numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* textures_ptr = textures)
                    fixed (Int32* numTextures_ptr = numTextures)
                    {
                        Delegates.glExtGetTexturesQCOM((UInt32*)textures_ptr, (Int32)maxTextures, (Int32*)numTextures_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            void ExtGetTextures([OutAttribute] out UInt32 textures, Int32 maxTextures, [OutAttribute] out Int32 numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (UInt32* textures_ptr = &textures)
                    fixed (Int32* numTextures_ptr = &numTextures)
                    {
                        Delegates.glExtGetTexturesQCOM((UInt32*)textures_ptr, (Int32)maxTextures, (Int32*)numTextures_ptr);
                        textures = *textures_ptr;
                        numTextures = *numTextures_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void ExtGetTextures([OutAttribute] UInt32* textures, Int32 maxTextures, [OutAttribute] Int32* numTextures)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtGetTexturesQCOM((UInt32*)textures, (Int32)maxTextures, (Int32*)numTextures);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            public static 
            bool ExtIsProgramBinary(Int32 program)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glExtIsProgramBinaryQCOM((UInt32)program);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get2]</summary>
            [System.CLSCompliant(false)]
            public static 
            bool ExtIsProgramBinary(UInt32 program)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                return Delegates.glExtIsProgramBinaryQCOM((UInt32)program);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_extended_get]</summary>
            public static 
            void ExtTexObjectStateOverride(OpenTK.Graphics.ES11.All target, OpenTK.Graphics.ES11.All pname, Int32 param)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glExtTexObjectStateOverrideiQCOM((OpenTK.Graphics.ES11.All)target, (OpenTK.Graphics.ES11.All)pname, (Int32)param);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] Int32[] driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* num_ptr = num)
                    fixed (Int32* driverControls_ptr = driverControls)
                    {
                        Delegates.glGetDriverControlsQCOM((Int32*)num_ptr, (Int32)size, (UInt32*)driverControls_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetDriverControl([OutAttribute] Int32[] num, Int32 size, [OutAttribute] UInt32[] driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* num_ptr = num)
                    fixed (UInt32* driverControls_ptr = driverControls)
                    {
                        Delegates.glGetDriverControlsQCOM((Int32*)num_ptr, (Int32)size, (UInt32*)driverControls_ptr);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out Int32 driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* num_ptr = &num)
                    fixed (Int32* driverControls_ptr = &driverControls)
                    {
                        Delegates.glGetDriverControlsQCOM((Int32*)num_ptr, (Int32)size, (UInt32*)driverControls_ptr);
                        num = *num_ptr;
                        driverControls = *driverControls_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetDriverControl([OutAttribute] out Int32 num, Int32 size, [OutAttribute] out UInt32 driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* num_ptr = &num)
                    fixed (UInt32* driverControls_ptr = &driverControls)
                    {
                        Delegates.glGetDriverControlsQCOM((Int32*)num_ptr, (Int32)size, (UInt32*)driverControls_ptr);
                        num = *num_ptr;
                        driverControls = *driverControls_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] Int32* driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetDriverControlsQCOM((Int32*)num, (Int32)size, (UInt32*)driverControls);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetDriverControl([OutAttribute] Int32* num, Int32 size, [OutAttribute] UInt32* driverControls)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetDriverControlsQCOM((Int32*)num, (Int32)size, (UInt32*)driverControls);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = length)
                    {
                        Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)driverControlString);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            public static 
            void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = &length)
                    {
                        Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)driverControlString);
                        length = *length_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetDriverControlString(Int32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length, (StringBuilder)driverControlString);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = length)
                    {
                        Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)driverControlString);
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] out Int32 length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                unsafe
                {
                    fixed (Int32* length_ptr = &length)
                    {
                        Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length_ptr, (StringBuilder)driverControlString);
                        length = *length_ptr;
                    }
                }
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_driver_control]</summary>
            [System.CLSCompliant(false)]
            public static 
            unsafe void GetDriverControlString(UInt32 driverControl, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder driverControlString)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glGetDriverControlStringQCOM((UInt32)driverControl, (Int32)bufSize, (Int32*)length, (StringBuilder)driverControlString);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            public static 
            void StartTiling(Int32 x, Int32 y, Int32 width, Int32 height, Int32 preserveMask)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glStartTilingQCOM((UInt32)x, (UInt32)y, (UInt32)width, (UInt32)height, (UInt32)preserveMask);
                #if DEBUG
                }
                #endif
            }

            /// <summary>[requires: QCOM_tiled_rendering]</summary>
            [System.CLSCompliant(false)]
            public static 
            void StartTiling(UInt32 x, UInt32 y, UInt32 width, UInt32 height, UInt32 preserveMask)
            {
                #if DEBUG
                using (new ErrorHelper(GraphicsContext.CurrentContext))
                {
                #endif
                Delegates.glStartTilingQCOM((UInt32)x, (UInt32)y, (UInt32)width, (UInt32)height, (UInt32)preserveMask);
                #if DEBUG
                }
                #endif
            }

        }

    }
}
