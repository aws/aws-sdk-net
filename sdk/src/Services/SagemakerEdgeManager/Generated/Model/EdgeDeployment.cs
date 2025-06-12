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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// Information about a deployment on an edge device that is registered with SageMaker
    /// Edge Manager.
    /// </summary>
    public partial class EdgeDeployment
    {
        private List<Definition> _definitions = AWSConfigs.InitializeCollections ? new List<Definition>() : null;
        private string _deploymentName;
        private FailureHandlingPolicy _failureHandlingPolicy;
        private DeploymentType _type;

        /// <summary>
        /// Gets and sets the property Definitions. 
        /// <para>
        /// Returns a list of Definition objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Definition> Definitions
        {
            get { return this._definitions; }
            set { this._definitions = value; }
        }

        // Check to see if Definitions property is set
        internal bool IsSetDefinitions()
        {
            return this._definitions != null && (this._definitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name and unique ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }

        // Check to see if DeploymentName property is set
        internal bool IsSetDeploymentName()
        {
            return this._deploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property FailureHandlingPolicy. 
        /// <para>
        /// Determines whether to rollback to previous configuration if deployment fails.
        /// </para>
        /// </summary>
        public FailureHandlingPolicy FailureHandlingPolicy
        {
            get { return this._failureHandlingPolicy; }
            set { this._failureHandlingPolicy = value; }
        }

        // Check to see if FailureHandlingPolicy property is set
        internal bool IsSetFailureHandlingPolicy()
        {
            return this._failureHandlingPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the deployment.
        /// </para>
        /// </summary>
        public DeploymentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}