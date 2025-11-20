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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteExpressGatewayService operation.
    /// Deletes an Express service and removes all associated Amazon Web Services resources.
    /// This operation stops service tasks, removes the Application Load Balancer, target
    /// groups, security groups, auto-scaling policies, and other managed infrastructure components.
    /// 
    ///  
    /// <para>
    /// The service enters a <c>DRAINING</c> state where existing tasks complete current requests
    /// without starting new tasks. After all tasks stop, the service and infrastructure are
    /// permanently removed.
    /// </para>
    ///  
    /// <para>
    /// This operation cannot be reversed. Back up important data and verify the service is
    /// no longer needed before deletion.
    /// </para>
    /// </summary>
    public partial class DeleteExpressGatewayServiceRequest : AmazonECSRequest
    {
        private string _serviceArn;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Express service to delete. The ARN uniquely
        /// identifies the service within your Amazon Web Services account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

    }
}