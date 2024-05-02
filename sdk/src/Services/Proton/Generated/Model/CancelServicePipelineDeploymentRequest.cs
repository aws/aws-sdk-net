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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CancelServicePipelineDeployment operation.
    /// Attempts to cancel a service pipeline deployment on an <a>UpdateServicePipeline</a>
    /// action, if the deployment is <c>IN_PROGRESS</c>. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-svc-pipeline-update.html">Update
    /// a service pipeline</a> in the <i>Proton User guide</i>.
    /// 
    ///  
    /// <para>
    /// The following list includes potential cancellation scenarios.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the cancellation attempt succeeds, the resulting deployment state is <c>CANCELLED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the cancellation attempt fails, the resulting deployment state is <c>FAILED</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the current <a>UpdateServicePipeline</a> action succeeds before the cancellation
    /// attempt starts, the resulting deployment state is <c>SUCCEEDED</c> and the cancellation
    /// attempt has no effect.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CancelServicePipelineDeploymentRequest : AmazonProtonRequest
    {
        private string _serviceName;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service with the service pipeline deployment to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

    }
}