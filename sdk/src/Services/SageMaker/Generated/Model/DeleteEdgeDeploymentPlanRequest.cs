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
    /// Container for the parameters to the DeleteEdgeDeploymentPlan operation.
    /// Deletes an edge deployment plan if (and only if) all the stages in the plan are inactive
    /// or there are no stages in the plan.
    /// </summary>
    public partial class DeleteEdgeDeploymentPlanRequest : AmazonSageMakerRequest
    {
        private string _edgeDeploymentPlanName;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan to delete.
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

    }
}