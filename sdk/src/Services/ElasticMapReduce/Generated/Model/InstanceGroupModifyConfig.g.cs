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
    /// Modify the size or configurations of an instance group.
    /// </summary>
    public partial class InstanceGroupModifyConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupModifyConfig() { }

        /// <summary>
        /// Instantiates InstanceGroupModifyConfig with the parameterized properties
        /// </summary>
        /// <param name="instanceGroupId">Unique ID of the instance group to modify.</param>
        /// <param name="instanceCount">Target size for the instance group.</param>
        public InstanceGroupModifyConfig(string instanceGroupId, int? instanceCount)
        {
            this.InstanceGroupId = instanceGroupId;
            this.InstanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A list of new or modified configurations to apply for an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EC2InstanceIdsToTerminate. 
        /// <para>
        /// The Amazon EC2 InstanceIds to terminate. After you terminate the instances, the instance
        /// group will not return to its original requested size.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EC2InstanceIdsToTerminate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EC2InstanceIdsToTerminate property is set.
        /// </summary>
        internal bool IsSetEC2InstanceIdsToTerminate() => this.EC2InstanceIdsToTerminate != null && (this.EC2InstanceIdsToTerminate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target size for the instance group.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Unique ID of the instance group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string InstanceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupId property is set.
        /// </summary>
        internal bool IsSetInstanceGroupId() => this.InstanceGroupId != null;

        /// <summary>
        /// Gets and sets the property ReconfigurationType. 
        /// <para>
        /// Type of reconfiguration requested. Valid values are MERGE and OVERWRITE.
        /// </para>
        /// </summary>
        public ReconfigurationType ReconfigurationType { get; set; }

        /// <summary>
        /// Checks to see if the ReconfigurationType property is set.
        /// </summary>
        internal bool IsSetReconfigurationType() => this.ReconfigurationType != null;

        /// <summary>
        /// Gets and sets the property ShrinkPolicy. 
        /// <para>
        /// Policy for customizing shrink operations.
        /// </para>
        /// </summary>
        public ShrinkPolicy ShrinkPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ShrinkPolicy property is set.
        /// </summary>
        internal bool IsSetShrinkPolicy() => this.ShrinkPolicy != null;
    }
}
