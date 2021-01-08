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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Modify the size or configurations of an instance group.
    /// </summary>
    public partial class InstanceGroupModifyConfig
    {
        private List<Configuration> _configurations = new List<Configuration>();
        private List<string> _ec2InstanceIdsToTerminate = new List<string>();
        private int? _instanceCount;
        private string _instanceGroupId;
        private ShrinkPolicy _shrinkPolicy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public InstanceGroupModifyConfig() { }

        /// <summary>
        /// Instantiates InstanceGroupModifyConfig with the parameterized properties
        /// </summary>
        /// <param name="instanceGroupId">Unique ID of the instance group to modify.</param>
        /// <param name="instanceCount">Target size for the instance group.</param>
        public InstanceGroupModifyConfig(string instanceGroupId, int instanceCount)
        {
            _instanceGroupId = instanceGroupId;
            _instanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A list of new or modified configurations to apply for an instance group.
        /// </para>
        /// </summary>
        public List<Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && this._configurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EC2InstanceIdsToTerminate. 
        /// <para>
        /// The EC2 InstanceIds to terminate. After you terminate the instances, the instance
        /// group will not return to its original requested size.
        /// </para>
        /// </summary>
        public List<string> EC2InstanceIdsToTerminate
        {
            get { return this._ec2InstanceIdsToTerminate; }
            set { this._ec2InstanceIdsToTerminate = value; }
        }

        // Check to see if EC2InstanceIdsToTerminate property is set
        internal bool IsSetEC2InstanceIdsToTerminate()
        {
            return this._ec2InstanceIdsToTerminate != null && this._ec2InstanceIdsToTerminate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Target size for the instance group.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupId. 
        /// <para>
        /// Unique ID of the instance group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string InstanceGroupId
        {
            get { return this._instanceGroupId; }
            set { this._instanceGroupId = value; }
        }

        // Check to see if InstanceGroupId property is set
        internal bool IsSetInstanceGroupId()
        {
            return this._instanceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ShrinkPolicy. 
        /// <para>
        /// Policy for customizing shrink operations.
        /// </para>
        /// </summary>
        public ShrinkPolicy ShrinkPolicy
        {
            get { return this._shrinkPolicy; }
            set { this._shrinkPolicy = value; }
        }

        // Check to see if ShrinkPolicy property is set
        internal bool IsSetShrinkPolicy()
        {
            return this._shrinkPolicy != null;
        }

    }
}