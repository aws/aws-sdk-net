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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListLongTermPricing operation.
    /// </summary>
    public partial class ListLongTermPricingResponse : AmazonWebServiceResponse
    {
        private List<LongTermPricingListEntry> _longTermPricingEntries = AWSConfigs.InitializeCollections ? new List<LongTermPricingListEntry>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LongTermPricingEntries. 
        /// <para>
        /// Each <c>LongTermPricingEntry</c> object contains a status, ID, and other information
        /// about the <c>LongTermPricing</c> type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LongTermPricingListEntry> LongTermPricingEntries
        {
            get { return this._longTermPricingEntries; }
            set { this._longTermPricingEntries = value; }
        }

        // Check to see if LongTermPricingEntries property is set
        internal bool IsSetLongTermPricingEntries()
        {
            return this._longTermPricingEntries != null && (this._longTermPricingEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Because HTTP requests are stateless, this is the starting point for your next list
        /// of returned <c>ListLongTermPricing</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}