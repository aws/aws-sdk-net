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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListComputationModelDataBindingUsages operation.
    /// Lists all data binding usages for computation models. This allows to identify where
    /// specific data bindings are being utilized across the computation models. This track
    /// dependencies between data sources and computation models.
    /// </summary>
    public partial class ListComputationModelDataBindingUsagesRequest : AmazonIoTSiteWiseRequest
    {
        private DataBindingValueFilter _dataBindingValueFilter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DataBindingValueFilter. 
        /// <para>
        /// A filter used to limit the returned data binding usages based on specific data binding
        /// values. You can filter by asset, asset model, asset property, or asset model property
        /// to find all computation models using these specific data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataBindingValueFilter DataBindingValueFilter
        {
            get { return this._dataBindingValueFilter; }
            set { this._dataBindingValueFilter = value; }
        }

        // Check to see if DataBindingValueFilter property is set
        internal bool IsSetDataBindingValueFilter()
        {
            return this._dataBindingValueFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results returned for each paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The token used for the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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