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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
    /// Represents a domain name access association between an access association source and
    /// a private custom domain name. With a domain name access association, an access association
    /// source can invoke a private custom domain name while isolated from the public internet.
    /// </summary>
    public partial class CreateDomainNameAccessAssociationResponse : AmazonWebServiceResponse
    {
        private string _accessAssociationSource;
        private AccessAssociationSourceType _accessAssociationSourceType;
        private string _domainNameAccessAssociationArn;
        private string _domainNameArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AccessAssociationSource. 
        /// <para>
        ///  The ARN of the domain name access association source. For a VPCE, the ARN must be
        /// a VPC endpoint. 
        /// </para>
        /// </summary>
        public string AccessAssociationSource
        {
            get { return this._accessAssociationSource; }
            set { this._accessAssociationSource = value; }
        }

        // Check to see if AccessAssociationSource property is set
        internal bool IsSetAccessAssociationSource()
        {
            return this._accessAssociationSource != null;
        }

        /// <summary>
        /// Gets and sets the property AccessAssociationSourceType. 
        /// <para>
        ///  The type of the domain name access association source. 
        /// </para>
        /// </summary>
        public AccessAssociationSourceType AccessAssociationSourceType
        {
            get { return this._accessAssociationSourceType; }
            set { this._accessAssociationSourceType = value; }
        }

        // Check to see if AccessAssociationSourceType property is set
        internal bool IsSetAccessAssociationSourceType()
        {
            return this._accessAssociationSourceType != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameAccessAssociationArn. 
        /// <para>
        /// The ARN of the domain name access association resource. 
        /// </para>
        /// </summary>
        public string DomainNameAccessAssociationArn
        {
            get { return this._domainNameAccessAssociationArn; }
            set { this._domainNameAccessAssociationArn = value; }
        }

        // Check to see if DomainNameAccessAssociationArn property is set
        internal bool IsSetDomainNameAccessAssociationArn()
        {
            return this._domainNameAccessAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainNameArn. 
        /// <para>
        /// The ARN of the domain name. 
        /// </para>
        /// </summary>
        public string DomainNameArn
        {
            get { return this._domainNameArn; }
            set { this._domainNameArn = value; }
        }

        // Check to see if DomainNameArn property is set
        internal bool IsSetDomainNameArn()
        {
            return this._domainNameArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The collection of tags. Each tag element is associated with a given resource. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}