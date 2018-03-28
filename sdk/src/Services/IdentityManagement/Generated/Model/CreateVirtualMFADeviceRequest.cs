/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualMFADevice operation.
    /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
    /// use <a>EnableMFADevice</a> to attach the MFA device to an IAM user. For more information
    /// about creating and working with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
    /// a Virtual MFA Device</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    /// For information about limits on the number of MFA devices you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on Entities</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The seed information contained in the QR code and the Base32 string should be treated
    /// like any other secret access information, such as your AWS access keys or your passwords.
    /// After you provision your virtual device, you should ensure that the information is
    /// destroyed following secure procedures.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateVirtualMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        private string _path;
        private string _virtualMFADeviceName;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path for the virtual MFA device. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of either a forward slash (/) by itself or a string
        /// that must begin and end with forward slashes. In addition, it can contain any ASCII
        /// character from the ! (\u0021) through the DEL character (\u007F), including most punctuation
        /// characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualMFADeviceName. 
        /// <para>
        /// The name of the virtual MFA device. Use with path to uniquely identify a virtual MFA
        /// device.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string VirtualMFADeviceName
        {
            get { return this._virtualMFADeviceName; }
            set { this._virtualMFADeviceName = value; }
        }

        // Check to see if VirtualMFADeviceName property is set
        internal bool IsSetVirtualMFADeviceName()
        {
            return this._virtualMFADeviceName != null;
        }

    }
}