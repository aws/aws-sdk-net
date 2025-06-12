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
    /// Describes a filter that returns a more specific list of recommendation export jobs.
    /// Use this filter with the <a>DescribeRecommendationExportJobs</a> action.
    /// 
    ///  
    /// <para>
    /// You can use <c>EBSFilter</c> with the <a>GetEBSVolumeRecommendations</a> action, <c>LambdaFunctionRecommendationFilter</c>
    /// with the <a>GetLambdaFunctionRecommendations</a> action, and <c>Filter</c> with the
    /// <a>GetAutoScalingGroupRecommendations</a> and <a>GetEC2InstanceRecommendations</a>
    /// actions.
    /// </para>
    /// </summary>
    public partial class JobFilter
    {
        private JobFilterName _name;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  
        /// <para>
        /// Specify <c>ResourceType</c> to return export jobs of a specific resource type (for
        /// example, <c>Ec2Instance</c>).
        /// </para>
        ///  
        /// <para>
        /// Specify <c>JobStatus</c> to return export jobs with a specific status (e.g, <c>Complete</c>).
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
        /// for the <c>name</c> parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <c>Ec2Instance</c> or <c>AutoScalingGroup</c> if you specify the <c>name</c>
        /// parameter as <c>ResourceType</c>. There is no filter for EBS volumes because volume
        /// recommendations cannot be exported at this time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <c>Queued</c>, <c>InProgress</c>, <c>Complete</c>, or <c>Failed</c> if you
        /// specify the <c>name</c> parameter as <c>JobStatus</c>.
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