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
    /// This is the response object from the GetDeployments operation.
    /// </summary>
    public partial class GetDeploymentsResponse : AmazonWebServiceResponse
    {
        private List<EdgeDeployment> _deployments = AWSConfigs.InitializeCollections ? new List<EdgeDeployment>() : null;

        /// <summary>
        /// Gets and sets the property Deployments. 
        /// <para>
        /// Returns a list of the configurations of the active deployments on the device.
        /// </para>
        /// </summary>
        public List<EdgeDeployment> Deployments
        {
            get { return this._deployments; }
            set { this._deployments = value; }
        }

        // Check to see if Deployments property is set
        internal bool IsSetDeployments()
        {
            return this._deployments != null && (this._deployments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}