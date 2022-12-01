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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// This structure specifies the network configuration for an Amazon ECS task.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private AwsVpcConfiguration _awsvpcConfiguration;

        /// <summary>
        /// Gets and sets the property AwsvpcConfiguration. 
        /// <para>
        /// Use this structure to specify the VPC subnets and security groups for the task, and
        /// whether a public IP address is to be used. This structure is relevant only for ECS
        /// tasks that use the <code>awsvpc</code> network mode.
        /// </para>
        /// </summary>
        public AwsVpcConfiguration AwsvpcConfiguration
        {
            get { return this._awsvpcConfiguration; }
            set { this._awsvpcConfiguration = value; }
        }

        // Check to see if AwsvpcConfiguration property is set
        internal bool IsSetAwsvpcConfiguration()
        {
            return this._awsvpcConfiguration != null;
        }

    }
}