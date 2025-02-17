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
 * Do not modify this file. This file is generated from the billing-2023-09-07.normal.json service model.
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
namespace Amazon.Billing.Model
{
    /// <summary>
    /// This is the response object from the ListSourceViewsForBillingView operation.
    /// </summary>
    public partial class ListSourceViewsForBillingViewResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _sourceViews = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The pagination token that is used on subsequent calls to list billing views. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2047)]
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
        /// Gets and sets the property SourceViews. 
        /// <para>
        /// A list of billing views used as the data source for the custom billing view. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> SourceViews
        {
            get { return this._sourceViews; }
            set { this._sourceViews = value; }
        }

        // Check to see if SourceViews property is set
        internal bool IsSetSourceViews()
        {
            return this._sourceViews != null && (this._sourceViews.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}