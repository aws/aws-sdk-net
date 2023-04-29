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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The network configuration for a task or service.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private AwsVpcConfiguration _awsvpcConfiguration;

        /// <summary>
        /// Gets and sets the property AwsvpcConfiguration. 
        /// <para>
        /// The VPC subnets and security groups that are associated with a task.
        /// </para>
        ///  <note> 
        /// <para>
        /// All specified subnets and security groups must be from the same VPC.
        /// </para>
        ///  </note>
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