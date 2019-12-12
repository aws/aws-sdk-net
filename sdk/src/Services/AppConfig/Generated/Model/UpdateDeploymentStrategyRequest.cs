/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeploymentStrategy operation.
    /// Updates a deployment strategy.
    /// </summary>
    public partial class UpdateDeploymentStrategyRequest : AmazonAppConfigRequest
    {
        private int? _deploymentDurationInMinutes;
        private string _deploymentStrategyId;
        private string _description;
        private int? _finalBakeTimeInMinutes;
        private float? _growthFactor;
        private GrowthType _growthType;

        /// <summary>
        /// Gets and sets the property DeploymentDurationInMinutes. 
        /// <para>
        /// Total amount of time for a deployment to last.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1440)]
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
        /// Gets and sets the property DeploymentStrategyId. 
        /// <para>
        /// The deployment strategy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeploymentStrategyId
        {
            get { return this._deploymentStrategyId; }
            set { this._deploymentStrategyId = value; }
        }

        // Check to see if DeploymentStrategyId property is set
        internal bool IsSetDeploymentStrategyId()
        {
            return this._deploymentStrategyId != null;
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
        [AWSProperty(Min=1, Max=100)]
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
        /// The algorithm used to define how percentage grows over time.
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

    }
}