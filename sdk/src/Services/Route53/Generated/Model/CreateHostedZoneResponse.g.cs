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
    /// This is the response object from the CreateHostedZone operation.
    /// </summary>
    public partial class CreateHostedZoneResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HostedZone. 
        /// <para>
        /// A complex type that contains general information about the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HostedZone HostedZone { get; set; }

        /// <summary>
        /// Checks to see if the HostedZone property is set.
        /// </summary>
        internal bool IsSetHostedZone() => this.HostedZone != null;

        /// <summary>
        /// Gets and sets the property ChangeInfo. 
        /// <para>
        /// A complex type that contains information about the <c>CreateHostedZone</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeInfo ChangeInfo { get; set; }

        /// <summary>
        /// Checks to see if the ChangeInfo property is set.
        /// </summary>
        internal bool IsSetChangeInfo() => this.ChangeInfo != null;

        /// <summary>
        /// Gets and sets the property DelegationSet. 
        /// <para>
        /// A complex type that describes the name servers for this hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DelegationSet DelegationSet { get; set; }

        /// <summary>
        /// Checks to see if the DelegationSet property is set.
        /// </summary>
        internal bool IsSetDelegationSet() => this.DelegationSet != null;

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// A complex type that contains information about an Amazon VPC that you associated with
        /// this hosted zone.
        /// </para>
        /// </summary>
        public VPC VPC { get; set; }

        /// <summary>
        /// Checks to see if the VPC property is set.
        /// </summary>
        internal bool IsSetVPC() => this.VPC != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The unique URL representing the new hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;
    }
}
