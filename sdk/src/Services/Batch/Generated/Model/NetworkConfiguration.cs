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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The network configuration for jobs running on Fargate resources. Jobs running on EC2
    /// resources must not specify this parameter.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private AssignPublicIp _assignPublicIp;

        /// <summary>
        /// Gets and sets the property AssignPublicIp. 
        /// <para>
        /// Indicates whether the job should have a public IP address. For a job running on Fargate
        /// resources in a private subnet to send outbound traffic to the internet (for example,
        /// in order to pull container images), the private subnet requires a NAT gateway be attached
        /// to route requests to the internet. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-networking.html">Amazon
        /// ECS task networking</a>. The default value is "DISABLED".
        /// </para>
        /// </summary>
        public AssignPublicIp AssignPublicIp
        {
            get { return this._assignPublicIp; }
            set { this._assignPublicIp = value; }
        }

        // Check to see if AssignPublicIp property is set
        internal bool IsSetAssignPublicIp()
        {
            return this._assignPublicIp != null;
        }

    }
}