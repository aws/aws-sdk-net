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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about deployments related to the specified deployment.
    /// </summary>
    public partial class RelatedDeployments
    {
        private List<string> _autoUpdateOutdatedInstancesDeploymentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _autoUpdateOutdatedInstancesRootDeploymentId;

        /// <summary>
        /// Gets and sets the property AutoUpdateOutdatedInstancesDeploymentIds. 
        /// <para>
        /// The deployment IDs of 'auto-update outdated instances' deployments triggered by this
        /// deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoUpdateOutdatedInstancesDeploymentIds
        {
            get { return this._autoUpdateOutdatedInstancesDeploymentIds; }
            set { this._autoUpdateOutdatedInstancesDeploymentIds = value; }
        }

        // Check to see if AutoUpdateOutdatedInstancesDeploymentIds property is set
        internal bool IsSetAutoUpdateOutdatedInstancesDeploymentIds()
        {
            return this._autoUpdateOutdatedInstancesDeploymentIds != null && (this._autoUpdateOutdatedInstancesDeploymentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoUpdateOutdatedInstancesRootDeploymentId. 
        /// <para>
        /// The deployment ID of the root deployment that triggered this deployment.
        /// </para>
        /// </summary>
        public string AutoUpdateOutdatedInstancesRootDeploymentId
        {
            get { return this._autoUpdateOutdatedInstancesRootDeploymentId; }
            set { this._autoUpdateOutdatedInstancesRootDeploymentId = value; }
        }

        // Check to see if AutoUpdateOutdatedInstancesRootDeploymentId property is set
        internal bool IsSetAutoUpdateOutdatedInstancesRootDeploymentId()
        {
            return this._autoUpdateOutdatedInstancesRootDeploymentId != null;
        }

    }
}