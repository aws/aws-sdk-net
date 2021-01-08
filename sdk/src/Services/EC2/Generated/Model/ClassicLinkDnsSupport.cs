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
    /// Describes the ClassicLink DNS support status of a VPC.
    /// </summary>
    public partial class ClassicLinkDnsSupport
    {
        private bool? _classicLinkDnsSupported;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ClassicLinkDnsSupported. 
        /// <para>
        /// Indicates whether ClassicLink DNS support is enabled for the VPC.
        /// </para>
        /// </summary>
        public bool ClassicLinkDnsSupported
        {
            get { return this._classicLinkDnsSupported.GetValueOrDefault(); }
            set { this._classicLinkDnsSupported = value; }
        }

        // Check to see if ClassicLinkDnsSupported property is set
        internal bool IsSetClassicLinkDnsSupported()
        {
            return this._classicLinkDnsSupported.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}