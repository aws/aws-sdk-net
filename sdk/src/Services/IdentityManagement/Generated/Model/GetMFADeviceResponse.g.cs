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
    /// This is the response object from the GetMFADevice operation.
    /// </summary>
    public partial class GetMFADeviceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Certifications. 
        /// <para>
        /// The certifications of a specified user's MFA device. We currently provide FIPS-140-2,
        /// FIPS-140-3, and FIDO certification levels obtained from <a href="https://fidoalliance.org/metadata/">
        /// FIDO Alliance Metadata Service (MDS)</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Certifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Certifications property is set.
        /// </summary>
        internal bool IsSetCertifications() => this.Certifications != null && (this.Certifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableDate. 
        /// <para>
        /// The date that a specified user's MFA device was first enabled.
        /// </para>
        /// </summary>
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// Checks to see if the EnableDate property is set.
        /// </summary>
        internal bool IsSetEnableDate() => this.EnableDate.HasValue;

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// Serial number that uniquely identifies the MFA device. For this API, we only accept
        /// FIDO security key <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 9, Max = 256)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The friendly name identifying the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
