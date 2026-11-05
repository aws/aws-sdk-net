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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Base32StringSeed. 
        /// <para>
        ///  The base32 seed defined as specified in <a href="https://tools.ietf.org/html/rfc3548.txt">RFC3548</a>.
        /// The <c>Base32StringSeed</c> is base32-encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream Base32StringSeed { get; set; }

        /// <summary>
        /// Checks to see if the Base32StringSeed property is set.
        /// </summary>
        internal bool IsSetBase32StringSeed() => this.Base32StringSeed != null;

        /// <summary>
        /// Gets and sets the property EnableDate. 
        /// <para>
        /// The date and time on which the virtual MFA device was enabled.
        /// </para>
        /// </summary>
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// Checks to see if the EnableDate property is set.
        /// </summary>
        internal bool IsSetEnableDate() => this.EnableDate.HasValue;

        /// <summary>
        /// Gets and sets the property QRCodePNG. 
        /// <para>
        ///  A QR code PNG image that encodes <c>otpauth://totp/$virtualMFADeviceName@$AccountName?secret=$Base32String</c>
        /// where <c>$virtualMFADeviceName</c> is one of the create call arguments. <c>AccountName</c>
        /// is the user name if set (otherwise, the account ID otherwise), and <c>Base32String</c>
        /// is the seed in base32 format. The <c>Base32String</c> value is base64-encoded. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream QRCodePNG { get; set; }

        /// <summary>
        /// Checks to see if the QRCodePNG property is set.
        /// </summary>
        internal bool IsSetQRCodePNG() => this.QRCodePNG != null;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number associated with <c>VirtualMFADevice</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 256)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the virtual MFA device. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// The IAM user associated with this virtual MFA device.
        /// </para>
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
