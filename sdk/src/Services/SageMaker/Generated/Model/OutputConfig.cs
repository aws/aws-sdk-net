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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains information about the output location for the compiled model and the target
    /// device that the model runs on. <c>TargetDevice</c> and <c>TargetPlatform</c> are mutually
    /// exclusive, so you need to choose one between the two to specify your target device
    /// or platform. If you cannot find your device you want to use from the <c>TargetDevice</c>
    /// list, use <c>TargetPlatform</c> to describe the platform of your edge device and <c>CompilerOptions</c>
    /// if there are specific settings that are required or recommended to use for particular
    /// TargetPlatform.
    /// </summary>
    public partial class OutputConfig
    {
        private string _compilerOptions;
        private string _kmsKeyId;
        private string _s3OutputLocation;
        private TargetDevice _targetDevice;
        private TargetPlatform _targetPlatform;

        /// <summary>
        /// Gets and sets the property CompilerOptions. 
        /// <para>
        /// Specifies additional parameters for compiler options in JSON format. The compiler
        /// options are <c>TargetPlatform</c> specific. It is required for NVIDIA accelerators
        /// and highly recommended for CPU compilations. For any other cases, it is optional to
        /// specify <c>CompilerOptions.</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DTYPE</c>: Specifies the data type for the input. When compiling for <c>ml_*</c>
        /// (except for <c>ml_inf</c>) instances using PyTorch framework, provide the data type
        /// (dtype) of the model's input. <c>"float32"</c> is used if <c>"DTYPE"</c> is not specified.
        /// Options for data type are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// float32: Use either <c>"float"</c> or <c>"float32"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// int64: Use either <c>"int64"</c> or <c>"long"</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, <c>{"dtype" : "float32"}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CPU</c>: Compilation for CPU supports the following compiler options.
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
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>ARM</c>: Details of ARM CPU compilations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEON</c>: NEON is an implementation of the Advanced SIMD extension used in ARMv7
        /// processors.
        /// </para>
        ///  
        /// <para>
        /// For example, add <c>{'mattr': ['+neon']}</c> to the compiler options if compiling
        /// for ARM 32-bit platform with the NEON support.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>NVIDIA</c>: Compilation for NVIDIA GPU supports the following compiler options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gpu_code</c>: Specifies the targeted architecture.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>trt-ver</c>: Specifies the TensorRT versions in x.y.z. format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cuda-ver</c>: Specifies the CUDA version in x.y format.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <c>{'gpu-code': 'sm_72', 'trt-ver': '6.0.1', 'cuda-ver': '10.1'}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANDROID</c>: Compilation for the Android OS supports the following compiler options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ANDROID_PLATFORM</c>: Specifies the Android API levels. Available levels range
        /// from 21 to 29. For example, <c>{'ANDROID_PLATFORM': 28}</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mattr</c>: Add <c>{'mattr': ['+neon']}</c> to compiler options if compiling for
        /// ARM 32-bit platform with NEON support.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>INFERENTIA</c>: Compilation for target ml_inf1 uses compiler options passed in
        /// as a JSON string. For example, <c>"CompilerOptions": "\"--verbose 1 --num-neuroncores
        /// 2 -O2\""</c>. 
        /// </para>
        ///  
        /// <para>
        /// For information about supported compiler options, see <a href="https://awsdocs-neuron.readthedocs-hosted.com/en/latest/compiler/neuronx-cc/api-reference-guide/neuron-compiler-cli-reference-guide.html">
        /// Neuron Compiler CLI Reference Guide</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CoreML</c>: Compilation for the CoreML <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html">OutputConfig</a>
        /// <c>TargetDevice</c> supports the following compiler options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>class_labels</c>: Specifies the classification labels file name inside input tar.gz
        /// file. For example, <c>{"class_labels": "imagenet_labels_1000.txt"}</c>. Labels inside
        /// the txt file should be separated by newlines.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=3, Max=1024)]
        public string CompilerOptions
        {
            get { return this._compilerOptions; }
            set { this._compilerOptions = value; }
        }

        // Check to see if CompilerOptions property is set
        internal bool IsSetCompilerOptions()
        {
            return this._compilerOptions != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service key (Amazon Web Services KMS) that
        /// Amazon SageMaker AI uses to encrypt your output models with Amazon S3 server-side
        /// encryption after compilation job. If you don't provide a KMS key ID, Amazon SageMaker
        /// AI uses the default KMS key for Amazon S3 for your role's account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <c>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// Identifies the S3 bucket where you want Amazon SageMaker AI to store the model artifacts.
        /// For example, <c>s3://bucket-name/key-name-prefix</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3OutputLocation
        {
            get { return this._s3OutputLocation; }
            set { this._s3OutputLocation = value; }
        }

        // Check to see if S3OutputLocation property is set
        internal bool IsSetS3OutputLocation()
        {
            return this._s3OutputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDevice. 
        /// <para>
        /// Identifies the target device or the machine learning instance that you want to run
        /// your model on after the compilation has completed. Alternatively, you can specify
        /// OS, architecture, and accelerator using <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TargetPlatform.html">TargetPlatform</a>
        /// fields. It can be used instead of <c>TargetPlatform</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently <c>ml_trn1</c> is available only in US East (N. Virginia) Region, and <c>ml_inf2</c>
        /// is available only in US East (Ohio) Region.
        /// </para>
        ///  </note>
        /// </summary>
        public TargetDevice TargetDevice
        {
            get { return this._targetDevice; }
            set { this._targetDevice = value; }
        }

        // Check to see if TargetDevice property is set
        internal bool IsSetTargetDevice()
        {
            return this._targetDevice != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPlatform. 
        /// <para>
        /// Contains information about a target platform that you want your model to run on, such
        /// as OS, architecture, and accelerators. It is an alternative of <c>TargetDevice</c>.
        /// </para>
        ///  
        /// <para>
        /// The following examples show how to configure the <c>TargetPlatform</c> and <c>CompilerOptions</c>
        /// JSON strings for popular target platforms: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Raspberry Pi 3 Model B+
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM_EABIHF"},</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "CompilerOptions": {'mattr': ['+neon']}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Jetson TX2
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM64", "Accelerator": "NVIDIA"},</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c> "CompilerOptions": {'gpu-code': 'sm_62', 'trt-ver': '6.0.1', 'cuda-ver': '10.0'}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EC2 m5.2xlarge instance OS
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "LINUX", "Arch": "X86_64", "Accelerator": "NVIDIA"},</c>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c> "CompilerOptions": {'mcpu': 'skylake-avx512'}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RK3399
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM64", "Accelerator": "MALI"}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARMv7 phone (CPU)
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "ANDROID", "Arch": "ARM_EABI"},</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "CompilerOptions": {'ANDROID_PLATFORM': 25, 'mattr': ['+neon']}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARMv8 phone (CPU)
        /// </para>
        ///  
        /// <para>
        ///  <c>"TargetPlatform": {"Os": "ANDROID", "Arch": "ARM64"},</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "CompilerOptions": {'ANDROID_PLATFORM': 29}</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TargetPlatform TargetPlatform
        {
            get { return this._targetPlatform; }
            set { this._targetPlatform = value; }
        }

        // Check to see if TargetPlatform property is set
        internal bool IsSetTargetPlatform()
        {
            return this._targetPlatform != null;
        }

    }
}