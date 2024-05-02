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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// The platform on which a model runs on an AWS IoT Greengrass core device.
    /// </summary>
    public partial class TargetPlatform
    {
        private TargetPlatformAccelerator _accelerator;
        private TargetPlatformArch _arch;
        private TargetPlatformOs _os;

        /// <summary>
        /// Gets and sets the property Accelerator. 
        /// <para>
        /// The target accelerator for the model. Currently, Amazon Lookout for Vision only supports
        /// NVIDIA (Nvidia graphics processing unit) and CPU accelerators. If you specify NVIDIA
        /// as an accelerator, you must also specify the <c>gpu-code</c>, <c>trt-ver</c>, and
        /// <c>cuda-ver</c> compiler options. If you don't specify an accelerator, Lookout for
        /// Vision uses the CPU for compilation and we highly recommend that you use the <a>GreengrassConfiguration$CompilerOptions</a>
        /// field. For example, you can use the following compiler options for CPU: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>mcpu</c>: CPU micro-architecture. For example, <c>{'mcpu': 'skylake-avx512'}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mattr</c>: CPU flags. For example, <c>{'mattr': ['+neon', '+vfpv4']}</c> 
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
        /// The target architecture for the model. The currently supported architectures are X86_64
        /// (64-bit version of the x86 instruction set) and ARM_64 (ARMv8 64-bit CPU). 
        /// </para>
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
        /// The target operating system for the model. Linux is the only operating system that
        /// is currently supported. 
        /// </para>
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