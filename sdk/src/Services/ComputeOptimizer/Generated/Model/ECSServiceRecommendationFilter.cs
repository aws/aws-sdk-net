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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes a filter that returns a more specific list of Amazon ECS service recommendations.
    /// Use this filter with the <a>GetECSServiceRecommendations</a> action.
    /// </summary>
    public partial class ECSServiceRecommendationFilter
    {
        private ECSServiceRecommendationFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the filter. 
        /// </para>
        ///  
        /// <para>
        ///  Specify <c>Finding</c> to return recommendations with a specific finding classification.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Specify <c>FindingReasonCode</c> to return recommendations with a specific finding
        /// reason code. 
        /// </para>
        ///  
        /// <para>
        /// You can filter your Amazon ECS service recommendations by <c>tag:key</c> and <c>tag-key</c>
        /// tags.
        /// </para>
        ///  
        /// <para>
        /// A <c>tag:key</c> is a key and value combination of a tag assigned to your Amazon ECS
        /// service recommendations. Use the tag key in the filter name and the tag value as the
        /// filter value. For example, to find all Amazon ECS service recommendations that have
        /// a tag with the key of <c>Owner</c> and the value of <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  
        /// <para>
        /// A <c>tag-key</c> is the key of a tag assigned to your Amazon ECS service recommendations.
        /// Use this filter to find all of your Amazon ECS service recommendations that have a
        /// tag with a specific key. This doesn’t consider the tag value. For example, you can
        /// find your Amazon ECS service recommendations with a tag key value of <c>Owner</c>
        /// or without any tag keys assigned.
        /// </para>
        /// </summary>
        public ECSServiceRecommendationFilterName Name
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
        ///  The value of the filter. 
        /// </para>
        ///  
        /// <para>
        /// The valid values for this parameter are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify the <c>name</c> parameter as <c>Finding</c>, specify <c>Optimized</c>,
        /// <c>Underprovisioned</c>, or <c>Overprovisioned</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify the <c>name</c> parameter as <c>FindingReasonCode</c>, specify <c>CPUUnderprovisioned</c>,
        /// <c>CPUOverprovisioned</c>, <c>MemoryUnderprovisioned</c>, or <c>MemoryOverprovisioned</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}