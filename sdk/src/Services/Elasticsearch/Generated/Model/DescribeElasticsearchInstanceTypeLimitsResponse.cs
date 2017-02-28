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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters received from <code> <a>DescribeElasticsearchInstanceTypeLimits</a>
    /// </code> operation.
    /// </summary>
    public partial class DescribeElasticsearchInstanceTypeLimitsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, Limits> _limitsByRole = new Dictionary<string, Limits>();

        /// <summary>
        /// Gets and sets the property LimitsByRole.
        /// </summary>
        public Dictionary<string, Limits> LimitsByRole
        {
            get { return this._limitsByRole; }
            set { this._limitsByRole = value; }
        }

        // Check to see if LimitsByRole property is set
        internal bool IsSetLimitsByRole()
        {
            return this._limitsByRole != null && this._limitsByRole.Count > 0; 
        }

    }
}