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
    /// Container for the parameters to the ModifyInstanceGroups operation. ModifyInstanceGroups
    /// modifies the number of nodes and configuration settings of an instance group. The
    /// input parameters include the new target instance count for the group and the instance
    /// group ID. The call will either succeed or fail atomically.
    /// </summary>
    public partial class ModifyInstanceGroupsRequest : AmazonElasticMapReduceRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ModifyInstanceGroupsRequest() { }

        /// <summary>
        /// Instantiates ModifyInstanceGroupsRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceGroups">Instance groups to change.</param>
        public ModifyInstanceGroupsRequest(List<InstanceGroupModifyConfig> instanceGroups)
        {
            this.InstanceGroups = instanceGroups;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The ID of the cluster to which the instance group belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Instance groups to change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceGroupModifyConfig> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceGroupModifyConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
