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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Used to create an S3 access point that accepts requests only from a virtual private
    /// cloud (VPC) to restrict data access to a private network.
    /// </summary>
    public partial class CreateAndAttachS3AccessPointS3Configuration
    {
        private string _policy;
        private S3AccessPointVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Specifies an access policy to associate with the S3 access point configuration. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-policies.html">Configuring
        /// IAM policies for using access points</a> in the Amazon Simple Storage Service User
        /// Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// If included, Amazon S3 restricts access to this S3 access point to requests made from
        /// the specified virtual private cloud (VPC).
        /// </para>
        /// </summary>
        public S3AccessPointVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}