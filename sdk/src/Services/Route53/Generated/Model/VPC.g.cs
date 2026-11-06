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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// (Private hosted zones only) A complex type that contains information about an Amazon
    /// VPC.
    /// 
    ///  
    /// <para>
    /// If you associate a private hosted zone with an Amazon VPC when you make a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_CreateHostedZone.html">CreateHostedZone</a>
    /// request, the following parameters are also required.
    /// </para>
    /// </summary>
    public partial class VPC
    {
        /// <summary>
        /// Gets and sets the property VPCRegion. 
        /// <para>
        /// (Private hosted zones only) The region that an Amazon VPC was created in.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public VPCRegion VPCRegion { get; set; }

        /// <summary>
        /// Checks to see if the VPCRegion property is set.
        /// </summary>
        internal bool IsSetVPCRegion() => this.VPCRegion != null;

        /// <summary>
        /// Gets and sets the property VPCId.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string VPCId { get; set; }

        /// <summary>
        /// Checks to see if the VPCId property is set.
        /// </summary>
        internal bool IsSetVPCId() => this.VPCId != null;
    }
}
