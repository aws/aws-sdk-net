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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The deployment configuration for an endpoint that hosts inference components. The
    /// configuration includes the desired deployment strategy and rollback settings.
    /// </summary>
    public partial class InferenceComponentDeploymentConfig
    {
        private AutoRollbackConfig _autoRollbackConfiguration;
        private InferenceComponentRollingUpdatePolicy _rollingUpdatePolicy;

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration.
        /// </summary>
        public AutoRollbackConfig AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RollingUpdatePolicy. 
        /// <para>
        /// Specifies a rolling deployment strategy for updating a SageMaker AI endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceComponentRollingUpdatePolicy RollingUpdatePolicy
        {
            get { return this._rollingUpdatePolicy; }
            set { this._rollingUpdatePolicy = value; }
        }

        // Check to see if RollingUpdatePolicy property is set
        internal bool IsSetRollingUpdatePolicy()
        {
            return this._rollingUpdatePolicy != null;
        }

    }
}