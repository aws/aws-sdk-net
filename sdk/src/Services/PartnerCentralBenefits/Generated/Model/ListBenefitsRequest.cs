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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Container for the parameters to the ListBenefits operation.
    /// Retrieves a paginated list of available benefits based on specified filter criteria.
    /// </summary>
    public partial class ListBenefitsRequest : AmazonPartnerCentralBenefitsRequest
    {
        private string _catalog;
        private List<string> _fulfillmentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _programs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _status = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog identifier to filter benefits by catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FulfillmentTypes. 
        /// <para>
        /// Filter benefits by specific fulfillment types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> FulfillmentTypes
        {
            get { return this._fulfillmentTypes; }
            set { this._fulfillmentTypes = value; }
        }

        // Check to see if FulfillmentTypes property is set
        internal bool IsSetFulfillmentTypes()
        {
            return this._fulfillmentTypes != null && (this._fulfillmentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of benefits to return in a single response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to retrieve the next set of results from a previous request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Programs. 
        /// <para>
        /// Filter benefits by specific AWS partner programs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> Programs
        {
            get { return this._programs; }
            set { this._programs = value; }
        }

        // Check to see if Programs property is set
        internal bool IsSetPrograms()
        {
            return this._programs != null && (this._programs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter benefits by their current status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && (this._status.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}