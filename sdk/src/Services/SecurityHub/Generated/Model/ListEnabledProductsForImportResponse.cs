/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the ListEnabledProductsForImport operation.
    /// </summary>
    public partial class ListEnabledProductsForImportResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _productSubscriptions = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that is required for pagination.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProductSubscriptions. 
        /// <para>
        /// A list of ARNs for the resources that represent your subscriptions to products. 
        /// </para>
        /// </summary>
        public List<string> ProductSubscriptions
        {
            get { return this._productSubscriptions; }
            set { this._productSubscriptions = value; }
        }

        // Check to see if ProductSubscriptions property is set
        internal bool IsSetProductSubscriptions()
        {
            return this._productSubscriptions != null && this._productSubscriptions.Count > 0; 
        }

    }
}