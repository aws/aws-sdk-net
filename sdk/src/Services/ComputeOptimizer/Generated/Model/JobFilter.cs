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
    /// Describes a filter that returns a more specific list of recommendation export jobs.
    /// 
    ///  
    /// <para>
    /// This filter is used with the <code>DescribeRecommendationExportJobs</code> action.
    /// </para>
    /// </summary>
    public partial class JobFilter
    {
        private JobFilterName _name;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <code>ResourceType</code> to return export jobs of a specific resource type
        /// (e.g., <code>Ec2Instance</code>).
        /// </para>
        ///  
        /// <para>
        /// Specify <code>JobStatus</code> to return export jobs with a specific status (e.g,
        /// <code>Complete</code>).
        /// </para>
        /// </summary>
        public JobFilterName Name
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
        /// Specify <code>Ec2Instance</code> or <code>AutoScalingGroup</code> if you specified
        /// the <code>name</code> parameter as <code>ResourceType</code>. There is no filter for
        /// EBS volumes because volume recommendations cannot be exported at this time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>Queued</code>, <code>InProgress</code>, <code>Complete</code>, or <code>Failed</code>
        /// if you specified the <code>name</code> parameter as <code>JobStatus</code>.
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