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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Controls Secure Boot and UEFI data settings for the resulting image during ISO imports.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/uefi-secure-boot.html">UEFI
    /// Secure Boot for Amazon EC2 instances</a> in the <i> <i>Amazon EC2 User Guide</i> </i>.
    /// </summary>
    public partial class RegisterImageOptions
    {
        private bool? _secureBootEnabled;
        private string _uefiData;

        /// <summary>
        /// Gets and sets the property SecureBootEnabled. 
        /// <para>
        /// Specifies whether Secure Boot is enabled for the output AMI. The default value is
        /// <c>true</c>. To disable Secure Boot for custom unsigned drivers, set this value to
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public bool? SecureBootEnabled
        {
            get { return this._secureBootEnabled; }
            set { this._secureBootEnabled = value; }
        }

        // Check to see if SecureBootEnabled property is set
        internal bool IsSetSecureBootEnabled()
        {
            return this._secureBootEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UefiData. 
        /// <para>
        /// A Base64-encoded representation of the non-volatile UEFI variable store. You can specify
        /// this parameter only when <c>secureBootEnabled</c> is <c>true</c> or unspecified. You
        /// can inspect and modify the UEFI data by using the <a href="https://github.com/awslabs/python-uefivars">python-uefivars
        /// tool on GitHub</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/uefi-variables.html">UEFI
        /// variables for Amazon EC2 instances</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64000)]
        public string UefiData
        {
            get { return this._uefiData; }
            set { this._uefiData = value; }
        }

        // Check to see if UefiData property is set
        internal bool IsSetUefiData()
        {
            return this._uefiData != null;
        }

    }
}