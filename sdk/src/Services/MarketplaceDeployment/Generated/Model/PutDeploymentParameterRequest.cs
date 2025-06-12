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
 * Do not modify this file. This file is generated from the marketplace-deployment-2023-01-25.normal.json service model.
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
namespace Amazon.MarketplaceDeployment.Model
{
    /// <summary>
    /// Container for the parameters to the PutDeploymentParameter operation.
    /// Creates or updates a deployment parameter and is targeted by <c>catalog</c> and <c>agreementId</c>.
    /// </summary>
    public partial class PutDeploymentParameterRequest : AmazonMarketplaceDeploymentRequest
    {
        private string _agreementId;
        private string _catalog;
        private string _clientToken;
        private DeploymentParameterInput _deploymentParameter;
        private DateTime? _expirationDate;
        private string _productId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AgreementId. 
        /// <para>
        /// The unique identifier of the agreement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AgreementId
        {
            get { return this._agreementId; }
            set { this._agreementId = value; }
        }

        // Check to see if AgreementId property is set
        internal bool IsSetAgreementId()
        {
            return this._agreementId != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for deployment parameters. A unique identifier for the new version.
        /// </para>
        ///  <note> 
        /// <para>
        /// This field is not required if you're calling using an AWS SDK. Otherwise, a <c>clientToken</c>
        /// must be provided with the request.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=32, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentParameter. 
        /// <para>
        /// The deployment parameter targeted to the acceptor of an agreement for which to create
        /// the AWS Secret Manager resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentParameterInput DeploymentParameter
        {
            get { return this._deploymentParameter; }
            set { this._deploymentParameter = value; }
        }

        // Check to see if DeploymentParameter property is set
        internal bool IsSetDeploymentParameter()
        {
            return this._deploymentParameter != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when deployment parameters expire and are scheduled for deletion.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product for which AWS Marketplace will save secrets for the buyer’s account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProductId
        {
            get { return this._productId; }
            set { this._productId = value; }
        }

        // Check to see if ProductId property is set
        internal bool IsSetProductId()
        {
            return this._productId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of key-value pairs, where each pair represents a tag saved to the resource.
        /// Tags will only be applied for create operations, and they'll be ignored if the resource
        /// already exists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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