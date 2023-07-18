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
    /// Contains information about the output location for the compiled model and the target
    /// device that the model runs on. <code>TargetDevice</code> and <code>TargetPlatform</code>
    /// are mutually exclusive, so you need to choose one between the two to specify your
    /// target device or platform. If you cannot find your device you want to use from the
    /// <code>TargetDevice</code> list, use <code>TargetPlatform</code> to describe the platform
    /// of your edge device and <code>CompilerOptions</code> if there are specific settings
    /// that are required or recommended to use for particular TargetPlatform.
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
        /// options are <code>TargetPlatform</code> specific. It is required for NVIDIA accelerators
        /// and highly recommended for CPU compilations. For any other cases, it is optional to
        /// specify <code>CompilerOptions.</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DTYPE</code>: Specifies the data type for the input. When compiling for <code>ml_*</code>
        /// (except for <code>ml_inf</code>) instances using PyTorch framework, provide the data
        /// type (dtype) of the model's input. <code>"float32"</code> is used if <code>"DTYPE"</code>
        /// is not specified. Options for data type are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// float32: Use either <code>"float"</code> or <code>"float32"</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// int64: Use either <code>"int64"</code> or <code>"long"</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For example, <code>{"dtype" : "float32"}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CPU</code>: Compilation for CPU supports the following compiler options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>mcpu</code>: CPU micro-architecture. For example, <code>{'mcpu': 'skylake-avx512'}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mattr</code>: CPU flags. For example, <code>{'mattr': ['+neon', '+vfpv4']}</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>ARM</code>: Details of ARM CPU compilations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>NEON</code>: NEON is an implementation of the Advanced SIMD extension used
        /// in ARMv7 processors.
        /// </para>
        ///  
        /// <para>
        /// For example, add <code>{'mattr': ['+neon']}</code> to the compiler options if compiling
        /// for ARM 32-bit platform with the NEON support.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>NVIDIA</code>: Compilation for NVIDIA GPU supports the following compiler options.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>gpu_code</code>: Specifies the targeted architecture.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>trt-ver</code>: Specifies the TensorRT versions in x.y.z. format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cuda-ver</code>: Specifies the CUDA version in x.y format.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, <code>{'gpu-code': 'sm_72', 'trt-ver': '6.0.1', 'cuda-ver': '10.1'}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ANDROID</code>: Compilation for the Android OS supports the following compiler
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ANDROID_PLATFORM</code>: Specifies the Android API levels. Available levels
        /// range from 21 to 29. For example, <code>{'ANDROID_PLATFORM': 28}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>mattr</code>: Add <code>{'mattr': ['+neon']}</code> to compiler options if
        /// compiling for ARM 32-bit platform with NEON support.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>INFERENTIA</code>: Compilation for target ml_inf1 uses compiler options passed
        /// in as a JSON string. For example, <code>"CompilerOptions": "\"--verbose 1 --num-neuroncores
        /// 2 -O2\""</code>. 
        /// </para>
        ///  
        /// <para>
        /// For information about supported compiler options, see <a href="https://github.com/aws/aws-neuron-sdk/blob/master/docs/neuron-cc/command-line-reference.md">
        /// Neuron Compiler CLI</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CoreML</code>: Compilation for the CoreML <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_OutputConfig.html">OutputConfig</a>
        /// <code>TargetDevice</code> supports the following compiler options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>class_labels</code>: Specifies the classification labels file name inside input
        /// tar.gz file. For example, <code>{"class_labels": "imagenet_labels_1000.txt"}</code>.
        /// Labels inside the txt file should be separated by newlines.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>EIA</code>: Compilation for the Elastic Inference Accelerator supports the
        /// following compiler options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>precision_mode</code>: Specifies the precision of compiled artifacts. Supported
        /// values are <code>"FP16"</code> and <code>"FP32"</code>. Default is <code>"FP32"</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>signature_def_key</code>: Specifies the signature to use for models in SavedModel
        /// format. Defaults is TensorFlow's default signature def key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>output_names</code>: Specifies a list of output tensor names for models in
        /// FrozenGraph format. Set at most one API field, either: <code>signature_def_key</code>
        /// or <code>output_names</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example: <code>{"precision_mode": "FP32", "output_names": ["output:0"]}</code>
        /// 
        /// </para>
        ///  </li> </ul>
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
        /// Amazon SageMaker uses to encrypt your output models with Amazon S3 server-side encryption
        /// after compilation job. If you don't provide a KMS key ID, Amazon SageMaker uses the
        /// default KMS key for Amazon S3 for your role's account. For more information, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">KMS-Managed
        /// Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i> 
        /// </para>
        ///  
        /// <para>
        /// The KmsKeyId can be any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name ARN: <code>arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Identifies the S3 bucket where you want Amazon SageMaker to store the model artifacts.
        /// For example, <code>s3://bucket-name/key-name-prefix</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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
        /// fields. It can be used instead of <code>TargetPlatform</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently <code>ml_trn1</code> is available only in US East (N. Virginia) Region,
        /// and <code>ml_inf2</code> is available only in US East (Ohio) Region.
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
        /// as OS, architecture, and accelerators. It is an alternative of <code>TargetDevice</code>.
        /// </para>
        ///  
        /// <para>
        /// The following examples show how to configure the <code>TargetPlatform</code> and <code>CompilerOptions</code>
        /// JSON strings for popular target platforms: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Raspberry Pi 3 Model B+
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM_EABIHF"},</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "CompilerOptions": {'mattr': ['+neon']}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Jetson TX2
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM64", "Accelerator": "NVIDIA"},</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "CompilerOptions": {'gpu-code': 'sm_62', 'trt-ver': '6.0.1', 'cuda-ver': '10.0'}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EC2 m5.2xlarge instance OS
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "LINUX", "Arch": "X86_64", "Accelerator": "NVIDIA"},</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code> "CompilerOptions": {'mcpu': 'skylake-avx512'}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RK3399
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "LINUX", "Arch": "ARM64", "Accelerator": "MALI"}</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARMv7 phone (CPU)
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "ANDROID", "Arch": "ARM_EABI"},</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "CompilerOptions": {'ANDROID_PLATFORM': 25, 'mattr': ['+neon']}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARMv8 phone (CPU)
        /// </para>
        ///  
        /// <para>
        ///  <code>"TargetPlatform": {"Os": "ANDROID", "Arch": "ARM64"},</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> "CompilerOptions": {'ANDROID_PLATFORM': 29}</code> 
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