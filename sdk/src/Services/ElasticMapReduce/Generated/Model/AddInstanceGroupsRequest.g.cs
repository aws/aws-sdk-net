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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the AddInstanceGroups operation. Adds one or more
    /// instance groups to a running cluster.
    /// </summary>
    public partial class AddInstanceGroupsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AddInstanceGroupsRequest() { }

        /// <summary>
        /// Instantiates AddInstanceGroupsRequest with the parameterized properties
        /// </summary>
        /// <param name="jobFlowId">Job flow in which to add the instance groups.</param>
        /// <param name="instanceGroups">Instance groups to add.</param>
        public AddInstanceGroupsRequest(string jobFlowId, List<InstanceGroupConfig> instanceGroups)
        {
            this.JobFlowId = jobFlowId;
            this.InstanceGroups = instanceGroups;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Instance groups to add.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<InstanceGroupConfig> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceGroupConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobFlowId. 
        /// <para>
        /// Job flow in which to add the instance groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string JobFlowId { get; set; }

        /// <summary>
        /// Checks to see if the JobFlowId property is set.
        /// </summary>
        internal bool IsSetJobFlowId() => this.JobFlowId != null;
    }
}
