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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDomainNameAccessAssociation operation. Creates
    /// a domain name access association resource between an access association source and
    /// a private custom domain name.
    /// </summary>
    public partial class CreateDomainNameAccessAssociationRequest : AmazonAPIGatewayRequest
    {
        /// <summary>
        /// Gets and sets the property AccessAssociationSource. 
        /// <para>
        ///  The identifier of the domain name access association source. For a VPCE, the value
        /// is the VPC endpoint ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccessAssociationSource { get; set; }

        /// <summary>
        /// Checks to see if the AccessAssociationSource property is set.
        /// </summary>
        internal bool IsSetAccessAssociationSource() => this.AccessAssociationSource != null;

        /// <summary>
        /// Gets and sets the property AccessAssociationSourceType. 
        /// <para>
        ///  The type of the domain name access association source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessAssociationSourceType AccessAssociationSourceType { get; set; }

        /// <summary>
        /// Checks to see if the AccessAssociationSourceType property is set.
        /// </summary>
        internal bool IsSetAccessAssociationSourceType() => this.AccessAssociationSourceType != null;

        /// <summary>
        /// Gets and sets the property DomainNameArn. 
        /// <para>
        ///  The ARN of the domain name. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainNameArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainNameArn property is set.
        /// </summary>
        internal bool IsSetDomainNameArn() => this.DomainNameArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value map of strings. The valid character set is [a-zA-Z+-=._:/]. The tag
        /// key can be up to 128 characters and must not start with <c>aws:</c>. The tag value
        /// can be up to 256 characters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
