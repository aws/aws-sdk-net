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
    /// The configuration for automatic patching of the instance group. When configured, the
    /// system automatically applies security patch AMI updates to the instance group.
    /// </summary>
    public partial class ClusterAutoPatchConfig
    {
        private DeploymentConfiguration _deploymentConfig;
        private ClusterPatchingStrategy _patchingStrategy;
        private ClusterPatchSchedule _patchSchedule;

        /// <summary>
        /// Gets and sets the property DeploymentConfig. 
        /// <para>
        /// The deployment configuration for rolling patch updates, including rollback settings
        /// and batch sizes. Only applicable when using a rolling patching strategy.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfig
        {
            get { return this._deploymentConfig; }
            set { this._deploymentConfig = value; }
        }

        // Check to see if DeploymentConfig property is set
        internal bool IsSetDeploymentConfig()
        {
            return this._deploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PatchingStrategy. 
        /// <para>
        /// The strategy for applying patches to instances in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterPatchingStrategy PatchingStrategy
        {
            get { return this._patchingStrategy; }
            set { this._patchingStrategy = value; }
        }

        // Check to see if PatchingStrategy property is set
        internal bool IsSetPatchingStrategy()
        {
            return this._patchingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property PatchSchedule. 
        /// <para>
        /// The schedule for automatic patching, including the next patch date.
        /// </para>
        /// </summary>
        public ClusterPatchSchedule PatchSchedule
        {
            get { return this._patchSchedule; }
            set { this._patchSchedule = value; }
        }

        // Check to see if PatchSchedule property is set
        internal bool IsSetPatchSchedule()
        {
            return this._patchSchedule != null;
        }

    }
}