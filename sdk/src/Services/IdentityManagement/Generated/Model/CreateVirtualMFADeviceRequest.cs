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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualMFADevice operation.
    /// Creates a new virtual MFA device for the Amazon Web Services account. After creating
    /// the virtual MFA, use <a>EnableMFADevice</a> to attach the MFA device to an IAM user.
    /// For more information about creating and working with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
    /// a virtual MFA device</a> in the <i>IAM User Guide</i>.
    /// 
    ///  
    /// <para>
    /// For information about the maximum number of MFA devices you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
    /// and STS quotas</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The seed information contained in the QR code and the Base32 string should be treated
    /// like any other secret access information. In other words, protect the seed information
    /// as you would your Amazon Web Services access keys or your passwords. After you provision
    /// your virtual device, you should ensure that the information is destroyed following
    /// secure procedures.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateVirtualMFADeviceRequest : AmazonIdentityManagementServiceRequest
    {
        private string _path;
        private List<Tag> _tags = new List<Tag>();
        private string _virtualMFADeviceName;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        ///  The path for the virtual MFA device. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of either a forward slash (/) by itself
        /// or a string that must begin and end with forward slashes. In addition, it can contain
        /// any ASCII character from the ! (<code>\u0021</code>) through the DEL character (<code>\u007F</code>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the new IAM virtual MFA device. Each tag
        /// consists of a key name and an associated value. For more information about tagging,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualMFADeviceName. 
        /// <para>
        /// The name of the virtual MFA device, which must be unique. Use with path to uniquely
        /// identify a virtual MFA device.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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