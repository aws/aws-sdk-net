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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Configuration settings of a canary deployment.
    /// </summary>
    public partial class CanarySettings
    {
        private string _deploymentId;
        private double? _percentTraffic;
        private Dictionary<string, string> _stageVariableOverrides = new Dictionary<string, string>();
        private bool? _useStageCache;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The ID of the canary deployment.
        /// </para>
        /// </summary>
        public string DeploymentId
        {
            get { return this._deploymentId; }
            set { this._deploymentId = value; }
        }

        // Check to see if DeploymentId property is set
        internal bool IsSetDeploymentId()
        {
            return this._deploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property PercentTraffic. 
        /// <para>
        /// The percent (0-100) of traffic diverted to a canary deployment.
        /// </para>
        /// </summary>
        public double PercentTraffic
        {
            get { return this._percentTraffic.GetValueOrDefault(); }
            set { this._percentTraffic = value; }
        }

        // Check to see if PercentTraffic property is set
        internal bool IsSetPercentTraffic()
        {
            return this._percentTraffic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageVariableOverrides. 
        /// <para>
        /// Stage variables overridden for a canary release deployment, including new stage variables
        /// introduced in the canary. These stage variables are represented as a string-to-string
        /// map between stage variable names and their values.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StageVariableOverrides
        {
            get { return this._stageVariableOverrides; }
            set { this._stageVariableOverrides = value; }
        }

        // Check to see if StageVariableOverrides property is set
        internal bool IsSetStageVariableOverrides()
        {
            return this._stageVariableOverrides != null && this._stageVariableOverrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UseStageCache. 
        /// <para>
        /// A Boolean flag to indicate whether the canary deployment uses the stage cache or not.
        /// </para>
        /// </summary>
        public bool UseStageCache
        {
            get { return this._useStageCache.GetValueOrDefault(); }
            set { this._useStageCache = value; }
        }

        // Check to see if UseStageCache property is set
        internal bool IsSetUseStageCache()
        {
            return this._useStageCache.HasValue; 
        }

    }
}