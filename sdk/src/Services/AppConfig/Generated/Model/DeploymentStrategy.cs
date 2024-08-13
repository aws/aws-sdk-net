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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DeploymentStrategy
    {
        private int? _deploymentDurationInMinutes;
        private string _description;
        private int? _finalBakeTimeInMinutes;
        private float? _growthFactor;
        private GrowthType _growthType;
        private string _id;
        private string _name;
        private ReplicateTo _replicateTo;

        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time the deployment lasted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
        public int? DeploymentDurationInMinutes
        {
            get { return this._deploymentDurationInMinutes; }
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
        /// The description of the deployment strategy.
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
        /// The amount of time that AppConfig monitored for alarms before considering the deployment
        /// to be complete and no longer eligible for automatic rollback.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
        public int? FinalBakeTimeInMinutes
        {
            get { return this._finalBakeTimeInMinutes; }
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
        /// The percentage of targets that received a deployed configuration during each interval.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public float? GrowthFactor
        {
            get { return this._growthFactor; }
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
        /// The algorithm used to define how percentage grew over time.
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The deployment strategy ID.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the deployment strategy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

    }
}