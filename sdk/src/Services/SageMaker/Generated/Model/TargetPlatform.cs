/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about a target platform that you want your model to run on, such
    /// as OS, architecture, and accelerators. It is an alternative of <code>TargetDevice</code>.
    /// </summary>
    public partial class TargetPlatform
    {
        private TargetPlatformAccelerator _accelerator;
        private TargetPlatformArch _arch;
        private TargetPlatformOs _os;

        /// <summary>
        /// Gets and sets the property Accelerator. 
        /// <para>
        /// Specifies a target platform accelerator (optional).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NVIDIA</code>: Nvidia graphics processing unit. It also requires <code>gpu-code</code>,
        /// <code>trt-ver</code>, <code>cuda-ver</code> compiler options
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MALI</code>: ARM Mali graphics processor
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INTEL_GRAPHICS</code>: Integrated Intel graphics
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetPlatformAccelerator Accelerator
        {
            get { return this._accelerator; }
            set { this._accelerator = value; }
        }

        // Check to see if Accelerator property is set
        internal bool IsSetAccelerator()
        {
            return this._accelerator != null;
        }

        /// <summary>
        /// Gets and sets the property Arch. 
        /// <para>
        /// Specifies a target platform architecture.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>X86_64</code>: 64-bit version of the x86 instruction set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>X86</code>: 32-bit version of the x86 instruction set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ARM64</code>: ARMv8 64-bit CPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ARM_EABIHF</code>: ARMv7 32-bit, Hard Float.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ARM_EABI</code>: ARMv7 32-bit, Soft Float. Used by Android 32-bit ARM platform.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetPlatformArch Arch
        {
            get { return this._arch; }
            set { this._arch = value; }
        }

        // Check to see if Arch property is set
        internal bool IsSetArch()
        {
            return this._arch != null;
        }

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// Specifies a target platform OS.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LINUX</code>: Linux-based operating systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ANDROID</code>: Android operating systems. Android API level can be specified
        /// using the <code>ANDROID_PLATFORM</code> compiler option. For example, <code>"CompilerOptions":
        /// {'ANDROID_PLATFORM': 28}</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetPlatformOs Os
        {
            get { return this._os; }
            set { this._os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }

    }
}