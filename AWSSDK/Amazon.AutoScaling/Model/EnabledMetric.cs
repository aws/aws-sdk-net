/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>EnabledMetric</c> data type. </para>
    /// </summary>
    public class EnabledMetric  
    {
        
        private string metric;
        private string granularity;

        /// <summary>
        /// The name of the enabled metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Metric
        {
            get { return this.metric; }
            set { this.metric = value; }
        }

        /// <summary>
        /// Sets the Metric property
        /// </summary>
        /// <param name="metric">The value to set for the Metric property </param>
        /// <returns>this instance</returns>
        public EnabledMetric WithMetric(string metric)
        {
            this.metric = metric;
            return this;
        }
            

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this.metric != null;       
        }

        /// <summary>
        /// The granularity of the enabled metric.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Granularity
        {
            get { return this.granularity; }
            set { this.granularity = value; }
        }

        /// <summary>
        /// Sets the Granularity property
        /// </summary>
        /// <param name="granularity">The value to set for the Granularity property </param>
        /// <returns>this instance</returns>
        public EnabledMetric WithGranularity(string granularity)
        {
            this.granularity = granularity;
            return this;
        }
            

        // Check to see if Granularity property is set
        internal bool IsSetGranularity()
        {
            return this.granularity != null;       
        }
    }
}
