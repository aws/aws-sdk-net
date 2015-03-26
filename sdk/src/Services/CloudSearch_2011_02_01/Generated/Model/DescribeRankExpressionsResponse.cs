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
 * Do not modify this file. This file is generated from the cloudsearch-2011-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudSearch_2011_02_01.Model
{
    /// <summary>
    /// A response message that contains the rank expressions for a search domain.
    /// </summary>
    public partial class DescribeRankExpressionsResponse : AmazonWebServiceResponse
    {
        private List<RankExpressionStatus> _rankExpressions = new List<RankExpressionStatus>();

        /// <summary>
        /// Gets and sets the property RankExpressions. 
        /// <para>
        /// The rank expressions configured for the domain.
        /// </para>
        /// </summary>
        public List<RankExpressionStatus> RankExpressions
        {
            get { return this._rankExpressions; }
            set { this._rankExpressions = value; }
        }

        // Check to see if RankExpressions property is set
        internal bool IsSetRankExpressions()
        {
            return this._rankExpressions != null && this._rankExpressions.Count > 0; 
        }

    }
}