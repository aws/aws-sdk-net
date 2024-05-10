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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// A summary of the proposal received from the proposer.
    /// </summary>
    public partial class ProposalSummary
    {
        private string _offerId;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer in AWS Marketplace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OfferId
        {
            get { return this._offerId; }
            set { this._offerId = value; }
        }

        // Check to see if OfferId property is set
        internal bool IsSetOfferId()
        {
            return this._offerId != null;
        }

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The list of resources involved in the agreement.
        /// </para>
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}