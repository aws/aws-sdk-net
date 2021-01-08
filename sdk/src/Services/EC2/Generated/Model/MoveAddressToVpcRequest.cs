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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the MoveAddressToVpc operation.
    /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
    /// The Elastic IP address must be allocated to your account for more than 24 hours, and
    /// it must not be associated with an instance. After the Elastic IP address is moved,
    /// it is no longer available for use in the EC2-Classic platform, unless you move it
    /// back using the <a>RestoreAddressToClassic</a> request. You cannot move an Elastic
    /// IP address that was originally allocated for use in the EC2-VPC platform to the EC2-Classic
    /// platform.
    /// </summary>
    public partial class MoveAddressToVpcRequest : AmazonEC2Request
    {
        private string _publicIp;

        /// <summary>
        /// Gets and sets the property PublicIp. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublicIp
        {
            get { return this._publicIp; }
            set { this._publicIp = value; }
        }

        // Check to see if PublicIp property is set
        internal bool IsSetPublicIp()
        {
            return this._publicIp != null;
        }

    }
}