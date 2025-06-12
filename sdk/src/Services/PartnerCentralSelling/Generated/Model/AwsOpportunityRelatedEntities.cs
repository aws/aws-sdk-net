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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents other entities related to the AWS opportunity, such as AWS products, partner
    /// solutions, and marketplace offers. These associations help build a complete picture
    /// of the solution being sold.
    /// </summary>
    public partial class AwsOpportunityRelatedEntities
    {
        private List<string> _awsProducts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _solutions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AwsProducts. 
        /// <para>
        /// Specifies the AWS products associated with the opportunity. This field helps track
        /// the specific products that are part of the proposed solution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AwsProducts
        {
            get { return this._awsProducts; }
            set { this._awsProducts = value; }
        }

        // Check to see if AwsProducts property is set
        internal bool IsSetAwsProducts()
        {
            return this._awsProducts != null && (this._awsProducts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Solutions. 
        /// <para>
        /// Specifies the partner solutions related to the opportunity. These solutions represent
        /// the partner's offerings that are being positioned as part of the overall AWS opportunity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Solutions
        {
            get { return this._solutions; }
            set { this._solutions = value; }
        }

        // Check to see if Solutions property is set
        internal bool IsSetSolutions()
        {
            return this._solutions != null && (this._solutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}