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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeploymentStrategy operation.
    /// Creates a deployment strategy that defines important criteria for rolling out your
    /// configuration to the designated targets. A deployment strategy includes the overall
    /// duration required, a percentage of targets to receive the deployment during each interval,
    /// an algorithm that defines how percentage grows, and bake time.
    /// </summary>
    public partial class CreateDeploymentStrategyRequest : AmazonAppConfigRequest
    {
        private int? _deploymentDurationInMinutes;
        private string _description;
        private int? _finalBakeTimeInMinutes;
        private float? _growthFactor;
        private GrowthType _growthType;
        private string _name;
        private ReplicateTo _replicateTo;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time for a deployment to last.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1440)]
        public int DeploymentDurationInMinutes
        {
            get { return this._deploymentDurationInMinutes.GetValueOrDefault(); }
            set { this._deploymentDurationInMinutes = value; }
        }

        // Check to see if DeploymentDurationInMinutes property is set
        internal bool IsSetDeploymentDurationInMinutes()
        {
            return this._deploymentDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the deployment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FinalBakeTimeInMinutes. 
        /// <para>
        /// The amount of time AppConfig monitors for alarms before considering the deployment
        /// to be complete and no longer eligible for automatic roll back.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
        public int FinalBakeTimeInMinutes
        {
            get { return this._finalBakeTimeInMinutes.GetValueOrDefault(); }
            set { this._finalBakeTimeInMinutes = value; }
        }

        // Check to see if FinalBakeTimeInMinutes property is set
        internal bool IsSetFinalBakeTimeInMinutes()
        {
            return this._finalBakeTimeInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrowthFactor. 
        /// <para>
        /// The percentage of targets to receive a deployed configuration during each interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public float GrowthFactor
        {
            get { return this._growthFactor.GetValueOrDefault(); }
            set { this._growthFactor = value; }
        }

        // Check to see if GrowthFactor property is set
        internal bool IsSetGrowthFactor()
        {
            return this._growthFactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrowthType. 
        /// <para>
        /// The algorithm used to define how percentage grows over time. AppConfig supports the
        /// following growth types:
        /// </para>
        ///  
        /// <para>
        ///  <b>Linear</b>: For this type, AppConfig processes the deployment by dividing the
        /// total number of targets by the value specified for <code>Step percentage</code>. For
        /// example, a linear deployment that uses a <code>Step percentage</code> of 10 deploys
        /// the configuration to 10 percent of the hosts. After those deployments are complete,
        /// the system deploys the configuration to the next 10 percent. This continues until
        /// 100% of the targets have successfully received the configuration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Exponential</b>: For this type, AppConfig processes the deployment exponentially
        /// using the following formula: <code>G*(2^N)</code>. In this formula, <code>G</code>
        /// is the growth factor specified by the user and <code>N</code> is the number of steps
        /// until the configuration is deployed to all targets. For example, if you specify a
        /// growth factor of 2, then the system rolls out the configuration as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>2*(2^0)</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>2*(2^1)</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>2*(2^2)</code> 
        /// </para>
        ///  
        /// <para>
        /// Expressed numerically, the deployment rolls out as follows: 2% of the targets, 4%
        /// of the targets, 8% of the targets, and continues until the configuration has been
        /// deployed to all targets.
        /// </para>
        /// </summary>
        public GrowthType GrowthType
        {
            get { return this._growthType; }
            set { this._growthType = value; }
        }

        // Check to see if GrowthType property is set
        internal bool IsSetGrowthType()
        {
            return this._growthType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the deployment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
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
        /// Gets and sets the property ReplicateTo. 
        /// <para>
        /// Save the deployment strategy to a Systems Manager (SSM) document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplicateTo ReplicateTo
        {
            get { return this._replicateTo; }
            set { this._replicateTo = value; }
        }

        // Check to see if ReplicateTo property is set
        internal bool IsSetReplicateTo()
        {
            return this._replicateTo != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata to assign to the deployment strategy. Tags help organize and categorize your
        /// AppConfig resources. Each tag consists of a key and an optional value, both of which
        /// you define.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}