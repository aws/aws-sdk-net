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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about policies that define how a deployment updates components
    /// and handles failure.
    /// </summary>
    public partial class DeploymentPolicies
    {
        private DeploymentComponentUpdatePolicy _componentUpdatePolicy;
        private DeploymentConfigurationValidationPolicy _configurationValidationPolicy;
        private DeploymentFailureHandlingPolicy _failureHandlingPolicy;

        /// <summary>
        /// Gets and sets the property ComponentUpdatePolicy. 
        /// <para>
        /// The component update policy for the configuration deployment. This policy defines
        /// when it's safe to deploy the configuration to devices.
        /// </para>
        /// </summary>
        public DeploymentComponentUpdatePolicy ComponentUpdatePolicy
        {
            get { return this._componentUpdatePolicy; }
            set { this._componentUpdatePolicy = value; }
        }

        // Check to see if ComponentUpdatePolicy property is set
        internal bool IsSetComponentUpdatePolicy()
        {
            return this._componentUpdatePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationValidationPolicy. 
        /// <para>
        /// The configuration validation policy for the configuration deployment. This policy
        /// defines how long each component has to validate its configure updates.
        /// </para>
        /// </summary>
        public DeploymentConfigurationValidationPolicy ConfigurationValidationPolicy
        {
            get { return this._configurationValidationPolicy; }
            set { this._configurationValidationPolicy = value; }
        }

        // Check to see if ConfigurationValidationPolicy property is set
        internal bool IsSetConfigurationValidationPolicy()
        {
            return this._configurationValidationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property FailureHandlingPolicy. 
        /// <para>
        /// The failure handling policy for the configuration deployment. This policy defines
        /// what to do if the deployment fails.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>ROLLBACK</c> 
        /// </para>
        /// </summary>
        public DeploymentFailureHandlingPolicy FailureHandlingPolicy
        {
            get { return this._failureHandlingPolicy; }
            set { this._failureHandlingPolicy = value; }
        }

        // Check to see if FailureHandlingPolicy property is set
        internal bool IsSetFailureHandlingPolicy()
        {
            return this._failureHandlingPolicy != null;
        }

    }
}