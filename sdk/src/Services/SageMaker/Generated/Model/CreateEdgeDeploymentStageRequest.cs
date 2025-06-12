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
    /// Container for the parameters to the CreateEdgeDeploymentStage operation.
    /// Creates a new stage in an existing edge deployment plan.
    /// </summary>
    public partial class CreateEdgeDeploymentStageRequest : AmazonSageMakerRequest
    {
        private string _edgeDeploymentPlanName;
        private List<DeploymentStage> _stages = AWSConfigs.InitializeCollections ? new List<DeploymentStage>() : null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeDeploymentPlanName
        {
            get { return this._edgeDeploymentPlanName; }
            set { this._edgeDeploymentPlanName = value; }
        }

        // Check to see if EdgeDeploymentPlanName property is set
        internal bool IsSetEdgeDeploymentPlanName()
        {
            return this._edgeDeploymentPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// List of stages to be added to the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DeploymentStage> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && (this._stages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}