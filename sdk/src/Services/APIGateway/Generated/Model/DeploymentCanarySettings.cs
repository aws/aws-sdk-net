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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// The input configuration for a canary deployment.
    /// </summary>
    public partial class DeploymentCanarySettings
    {
        private double? _percentTraffic;
        private Dictionary<string, string> _stageVariableOverrides = new Dictionary<string, string>();
        private bool? _useStageCache;

        /// <summary>
        /// Gets and sets the property PercentTraffic. 
        /// <para>
        /// The percentage (0.0-100.0) of traffic routed to the canary deployment.
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
        /// A stage variable overrides used for the canary release deployment. They can override
        /// existing stage variables or add new stage variables for the canary release deployment.
        /// These stage variables are represented as a string-to-string map between stage variable
        /// names and their values.
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
        /// A Boolean flag to indicate whether the canary release deployment uses the stage cache
        /// or not.
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