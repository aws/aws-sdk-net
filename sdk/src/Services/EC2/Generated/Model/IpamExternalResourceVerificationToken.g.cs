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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// A verification token is an Amazon Web Services-generated random value that you can
    /// use to prove ownership of an external resource. For example, you can use a verification
    /// token to validate that you control a public IP address range when you bring an IP
    /// address range to Amazon Web Services (BYOIP).
    /// </summary>
    public partial class IpamExternalResourceVerificationToken
    {
        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// ARN of the IPAM that created the token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamArn property is set.
        /// </summary>
        internal bool IsSetIpamArn() => this.IpamArn != null;

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenArn. 
        /// <para>
        /// Token ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamExternalResourceVerificationTokenArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamExternalResourceVerificationTokenArn property is set.
        /// </summary>
        internal bool IsSetIpamExternalResourceVerificationTokenArn() => this.IpamExternalResourceVerificationTokenArn != null;

        /// <summary>
        /// Gets and sets the property IpamExternalResourceVerificationTokenId. 
        /// <para>
        /// The ID of the token.
        /// </para>
        /// </summary>
        public string IpamExternalResourceVerificationTokenId { get; set; }

        /// <summary>
        /// Checks to see if the IpamExternalResourceVerificationTokenId property is set.
        /// </summary>
        internal bool IsSetIpamExternalResourceVerificationTokenId() => this.IpamExternalResourceVerificationTokenId != null;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM that created the token.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// Region of the IPAM that created the token.
        /// </para>
        /// </summary>
        public string IpamRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamRegion property is set.
        /// </summary>
        internal bool IsSetIpamRegion() => this.IpamRegion != null;

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// Token expiration.
        /// </para>
        /// </summary>
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Token state.
        /// </para>
        /// </summary>
        public IpamExternalResourceVerificationTokenState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Token status.
        /// </para>
        /// </summary>
        public TokenState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Token tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenName. 
        /// <para>
        /// Token name.
        /// </para>
        /// </summary>
        public string TokenName { get; set; }

        /// <summary>
        /// Checks to see if the TokenName property is set.
        /// </summary>
        internal bool IsSetTokenName() => this.TokenName != null;

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// Token value.
        /// </para>
        /// </summary>
        public string TokenValue { get; set; }

        /// <summary>
        /// Checks to see if the TokenValue property is set.
        /// </summary>
        internal bool IsSetTokenValue() => this.TokenValue != null;
    }
}
