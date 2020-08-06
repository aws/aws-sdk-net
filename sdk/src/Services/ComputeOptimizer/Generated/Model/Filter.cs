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
    /// Describes a filter that returns a more specific list of recommendations.
    /// </summary>
    public partial class Filter
    {
        private FilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>Finding</code> to return recommendations with a specific findings classification
        /// (e.g., <code>Overprovisioned</code>).
        /// </para>
        ///  
        /// <para>
        /// Specify <code>RecommendationSourceType</code> to return recommendations of a specific
        /// resource type (e.g., <code>AutoScalingGroup</code>).
        /// </para>
        /// </summary>
        public FilterName Name
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
        /// If you specify the <code>name</code> parameter as <code>Finding</code>, and you request
        /// recommendations for an <i>instance</i>, then the valid values are <code>Underprovisioned</code>,
        /// <code>Overprovisioned</code>, <code>NotOptimized</code>, or <code>Optimized</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>name</code> parameter as <code>Finding</code>, and you request
        /// recommendations for an <i>Auto Scaling group</i>, then the valid values are <code>Optimized</code>,
        /// or <code>NotOptimized</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>name</code> parameter as <code>RecommendationSourceType</code>,
        /// then the valid values are <code>Ec2Instance</code>, or <code>AutoScalingGroup</code>.
        /// </para>
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