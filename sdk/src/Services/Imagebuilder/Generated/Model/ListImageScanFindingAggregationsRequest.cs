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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the ListImageScanFindingAggregations operation.
    /// Returns a list of image scan aggregations for your account. You can filter by the
    /// type of key that Image Builder uses to group results. For example, if you want to
    /// get a list of findings by severity level for one of your pipelines, you might specify
    /// your pipeline with the <code>imagePipelineArn</code> filter. If you don't specify
    /// a filter, Image Builder returns an aggregation for your account.
    /// 
    ///  
    /// <para>
    /// To streamline results, you can use the following filters in your request:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>accountId</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>imageBuildVersionArn</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>imagePipelineArn</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>vulnerabilityId</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListImageScanFindingAggregationsRequest : AmazonImagebuilderRequest
    {
        private Filter _filter;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Filter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to specify where to start paginating. This is the NextToken from a previously
        /// truncated response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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