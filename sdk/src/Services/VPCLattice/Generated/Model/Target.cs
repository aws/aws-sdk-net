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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes a target.
    /// </summary>
    public partial class Target
    {
        private string _id;
        private int? _port;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the target. If the target type of the target group is <code>INSTANCE</code>,
        /// this is an instance ID. If the target type is <code>IP</code> , this is an IP address.
        /// If the target type is <code>LAMBDA</code>, this is the ARN of the Lambda function.
        /// If the target type is <code>ALB</code>, this is the ARN of the Application Load Balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port on which the target is listening. For HTTP, the default is <code>80</code>.
        /// For HTTPS, the default is <code>443</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}