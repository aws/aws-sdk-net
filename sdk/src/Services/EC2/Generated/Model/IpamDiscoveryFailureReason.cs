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
    /// The discovery failure reason.
    /// </summary>
    public partial class IpamDiscoveryFailureReason
    {
        private IpamDiscoveryFailureCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The discovery failure code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>assume-role-failure</code> - IPAM could not assume the Amazon Web Services
        /// IAM service-linked role. This could be because of any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SLR has not been created yet and IPAM is still creating it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You have opted-out of the IPAM home Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Account you are using as your IPAM account has been suspended.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>throttling-failure</code> - IPAM account is already using the allotted transactions
        /// per second and IPAM is receiving a throttling error when assuming the Amazon Web Services
        /// IAM SLR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>unauthorized-failure</code> - Amazon Web Services account making the request
        /// is not authorized. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/errors-overview.html">AuthFailure</a>
        /// in the <i>Amazon Elastic Compute Cloud API Reference</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamDiscoveryFailureCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The discovery failure message.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}