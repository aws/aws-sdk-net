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
    /// The configuration to use when updating the AMI versions.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private List<AlarmDetails> _autoRollbackConfiguration = AWSConfigs.InitializeCollections ? new List<AlarmDetails>() : null;
        private RollingDeploymentPolicy _rollingUpdatePolicy;
        private int? _waitIntervalInSeconds;

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration. 
        /// <para>
        /// An array that contains the alarms that SageMaker monitors to know whether to roll
        /// back the AMI update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<AlarmDetails> AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null && (this._autoRollbackConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RollingUpdatePolicy. 
        /// <para>
        /// The policy that SageMaker uses when updating the AMI versions of the cluster. 
        /// </para>
        /// </summary>
        public RollingDeploymentPolicy RollingUpdatePolicy
        {
            get { return this._rollingUpdatePolicy; }
            set { this._rollingUpdatePolicy = value; }
        }

        // Check to see if RollingUpdatePolicy property is set
        internal bool IsSetRollingUpdatePolicy()
        {
            return this._rollingUpdatePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property WaitIntervalInSeconds. 
        /// <para>
        /// The duration in seconds that SageMaker waits before updating more instances in the
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3600)]
        public int? WaitIntervalInSeconds
        {
            get { return this._waitIntervalInSeconds; }
            set { this._waitIntervalInSeconds = value; }
        }

        // Check to see if WaitIntervalInSeconds property is set
        internal bool IsSetWaitIntervalInSeconds()
        {
            return this._waitIntervalInSeconds.HasValue; 
        }

    }
}