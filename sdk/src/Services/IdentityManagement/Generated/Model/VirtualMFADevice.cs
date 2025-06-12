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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a virtual MFA device.
    /// </summary>
    public partial class VirtualMFADevice
    {
        private MemoryStream _base32StringSeed;
        private DateTime? _enableDate;
        private MemoryStream _qrCodePNG;
        private string _serialNumber;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private User _user;

        /// <summary>
        /// Gets and sets the property Base32StringSeed. 
        /// <para>
        ///  The base32 seed defined as specified in <a href="https://tools.ietf.org/html/rfc3548.txt">RFC3548</a>.
        /// The <c>Base32StringSeed</c> is base32-encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream Base32StringSeed
        {
            get { return this._base32StringSeed; }
            set { this._base32StringSeed = value; }
        }

        // Check to see if Base32StringSeed property is set
        internal bool IsSetBase32StringSeed()
        {
            return this._base32StringSeed != null;
        }

        /// <summary>
        /// Gets and sets the property EnableDate. 
        /// <para>
        /// The date and time on which the virtual MFA device was enabled.
        /// </para>
        /// </summary>
        public DateTime? EnableDate
        {
            get { return this._enableDate; }
            set { this._enableDate = value; }
        }

        // Check to see if EnableDate property is set
        internal bool IsSetEnableDate()
        {
            return this._enableDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QRCodePNG. 
        /// <para>
        ///  A QR code PNG image that encodes <c>otpauth://totp/$virtualMFADeviceName@$AccountName?secret=$Base32String</c>
        /// where <c>$virtualMFADeviceName</c> is one of the create call arguments. <c>AccountName</c>
        /// is the user name if set (otherwise, the account ID otherwise), and <c>Base32String</c>
        /// is the seed in base32 format. The <c>Base32String</c> value is base64-encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream QRCodePNG
        {
            get { return this._qrCodePNG; }
            set { this._qrCodePNG = value; }
        }

        // Check to see if QRCodePNG property is set
        internal bool IsSetQRCodePNG()
        {
            return this._qrCodePNG != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number associated with <c>VirtualMFADevice</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=9, Max=256)]
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the virtual MFA device. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The IAM user associated with this virtual MFA device.
        /// </para>
        /// </summary>
        public User User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}