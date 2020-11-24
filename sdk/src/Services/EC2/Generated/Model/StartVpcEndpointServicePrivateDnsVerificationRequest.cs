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
    /// Container for the parameters to the StartVpcEndpointServicePrivateDnsVerification operation.
    /// Initiates the verification process to prove that the service provider owns the private
    /// DNS name domain for the endpoint service.
    /// 
    ///  
    /// <para>
    /// The service provider must successfully perform the verification before the consumer
    /// can use the name to access the service.
    /// </para>
    ///  
    /// <para>
    /// Before the service provider runs this command, they must add a record to the DNS server.
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/endpoint-services-dns-validation.html#add-dns-txt-record">Adding
    /// a TXT Record to Your Domain's DNS Server </a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartVpcEndpointServicePrivateDnsVerificationRequest : AmazonEC2Request
    {
        private string _serviceId;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the endpoint service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

    }
}