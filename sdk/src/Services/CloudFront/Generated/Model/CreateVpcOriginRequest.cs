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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcOrigin operation.
    /// Create an Amazon CloudFront VPC origin.
    /// </summary>
    public partial class CreateVpcOriginRequest : AmazonCloudFrontRequest
    {
        private Tags _tags;
        private VpcOriginEndpointConfig _vpcOriginEndpointConfig;

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

        /// <summary>
        /// Gets and sets the property VpcOriginEndpointConfig. 
        /// <para>
        /// The VPC origin endpoint configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcOriginEndpointConfig VpcOriginEndpointConfig
        {
            get { return this._vpcOriginEndpointConfig; }
            set { this._vpcOriginEndpointConfig = value; }
        }

        // Check to see if VpcOriginEndpointConfig property is set
        internal bool IsSetVpcOriginEndpointConfig()
        {
            return this._vpcOriginEndpointConfig != null;
        }

    }
}