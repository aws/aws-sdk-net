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
    /// Container for the parameters to the CreateInternetGateway operation.
    /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
    /// you attach it to a VPC using <a>AttachInternetGateway</a>.
    /// 
    ///  
    /// <para>
    /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/vpc/latest/userguide/">Amazon
    /// Virtual Private Cloud User Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateInternetGatewayRequest : AmazonEC2Request
    {
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the internet gateway.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}