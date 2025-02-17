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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcBlockPublicAccessOptions operation.
    /// </summary>
    public partial class DescribeVpcBlockPublicAccessOptionsResponse : AmazonWebServiceResponse
    {
        private VpcBlockPublicAccessOptions _vpcBlockPublicAccessOptions;

        /// <summary>
        /// Gets and sets the property VpcBlockPublicAccessOptions. 
        /// <para>
        /// Details related to the options.
        /// </para>
        /// </summary>
        public VpcBlockPublicAccessOptions VpcBlockPublicAccessOptions
        {
            get { return this._vpcBlockPublicAccessOptions; }
            set { this._vpcBlockPublicAccessOptions = value; }
        }

        // Check to see if VpcBlockPublicAccessOptions property is set
        internal bool IsSetVpcBlockPublicAccessOptions()
        {
            return this._vpcBlockPublicAccessOptions != null;
        }

    }
}