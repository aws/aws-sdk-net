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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a filter that returns a more specific list of Lambda function recommendations.
    /// Use this filter with the <a>GetLambdaFunctionRecommendations</a> action.
    /// 
    ///  
    /// <para>
    /// You can use <code>EBSFilter</code> with the <a>GetEBSVolumeRecommendations</a> action,
    /// <code>JobFilter</code> with the <a>DescribeRecommendationExportJobs</a> action, and
    /// <code>Filter</code> with the <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
    /// actions.
    /// </para>
    /// </summary>
    public partial class LambdaFunctionRecommendationFilter
    {
        private LambdaFunctionRecommendationFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>Finding</code> to return recommendations with a specific finding classification
        /// (for example, <code>NotOptimized</code>).
        /// </para>
        ///  
        /// <para>
        /// Specify <code>FindingReasonCode</code> to return recommendations with a specific finding
        /// reason code (for example, <code>MemoryUnderprovisioned</code>).
        /// </para>
        ///  
        /// <para>
        /// You can filter your Lambda function recommendations by <code>tag:key</code> and <code>tag-key</code>
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// A <code>tag:key</code> is a key and value combination of a tag assigned to your Lambda
        /// function recommendations. Use the tag key in the filter name and the tag value as
        /// the filter value. For example, to find all Lambda function recommendations that have
        /// a tag with the key of <code>Owner</code> and the value of <code>TeamA</code>, specify
        /// <code>tag:Owner</code> for the filter name and <code>TeamA</code> for the filter value.
        /// </para>
        ///  
        /// <para>
        /// A <code>tag-key</code> is the key of a tag assigned to your Lambda function recommendations.
        /// Use this filter to find all of your Lambda function recommendations that have a tag
        /// with a specific key. This doesn’t consider the tag value. For example, you can find
        /// your Lambda function recommendations with a tag key value of <code>Owner</code> or
        /// without any tag keys assigned.
        /// </para>
        /// </summary>
        public LambdaFunctionRecommendationFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value of the filter.
        /// </para>
        ///  
        /// <para>
        /// The valid values for this parameter are as follows, depending on what you specify
        /// for the <code>name</code> parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <code>Optimized</code>, <code>NotOptimized</code>, or <code>Unavailable</code>
        /// if you specify the <code>name</code> parameter as <code>Finding</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>MemoryOverprovisioned</code>, <code>MemoryUnderprovisioned</code>, <code>InsufficientData</code>,
        /// or <code>Inconclusive</code> if you specify the <code>name</code> parameter as <code>FindingReasonCode</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}