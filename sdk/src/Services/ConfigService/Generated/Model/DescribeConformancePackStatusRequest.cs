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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConformancePackStatus operation.
    /// Provides one or more conformance packs deployment status.
    /// 
    ///  <note> 
    /// <para>
    /// If there are no conformance packs then you will see an empty result.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConformancePackStatusRequest : AmazonConfigServiceRequest
    {
        private List<string> _conformancePackNames = new List<string>();
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConformancePackNames. 
        /// <para>
        /// Comma-separated list of conformance pack names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> ConformancePackNames
        {
            get { return this._conformancePackNames; }
            set { this._conformancePackNames = value; }
        }

        // Check to see if ConformancePackNames property is set
        internal bool IsSetConformancePackNames()
        {
            return this._conformancePackNames != null && this._conformancePackNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of conformance packs status returned on each page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned in a previous request that you use to request
        /// the next page of results in a paginated response.
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

    }
}