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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// Specifies the network configuration for an ECS task.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private AwsVpcConfiguration _awsvpcConfiguration;

        /// <summary>
        /// Gets and sets the property AwsvpcConfiguration. 
        /// <para>
        /// Specifies the Amazon VPC subnets and security groups for the task, and whether a public
        /// IP address is to be used. This structure is relevant only for ECS tasks that use the
        /// awsvpc network mode.
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