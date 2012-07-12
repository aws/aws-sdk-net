/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the rank expressions for a search domain.</para>
    /// </summary>
    public class DescribeRankExpressionsResult  
    {
        
        private List<RankExpressionStatus> rankExpressions = new List<RankExpressionStatus>();

        /// <summary>
        /// The rank expressions configured for the domain.
        ///  
        /// </summary>
        public List<RankExpressionStatus> RankExpressions
        {
            get { return this.rankExpressions; }
            set { this.rankExpressions = value; }
        }
        /// <summary>
        /// Adds elements to the RankExpressions collection
        /// </summary>
        /// <param name="rankExpressions">The values to add to the RankExpressions collection </param>
        /// <returns>this instance</returns>
        public DescribeRankExpressionsResult WithRankExpressions(params RankExpressionStatus[] rankExpressions)
        {
            foreach (RankExpressionStatus element in rankExpressions)
            {
                this.rankExpressions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the RankExpressions collection
        /// </summary>
        /// <param name="rankExpressions">The values to add to the RankExpressions collection </param>
        /// <returns>this instance</returns>
        public DescribeRankExpressionsResult WithRankExpressions(IEnumerable<RankExpressionStatus> rankExpressions)
        {
            foreach (RankExpressionStatus element in rankExpressions)
            {
                this.rankExpressions.Add(element);
            }

            return this;
        }

        // Check to see if RankExpressions property is set
        internal bool IsSetRankExpressions()
        {
            return this.rankExpressions.Count > 0;       
        }
    }
}
