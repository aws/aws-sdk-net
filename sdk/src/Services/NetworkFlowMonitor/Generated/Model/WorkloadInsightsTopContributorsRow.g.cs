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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A row for a top contributor for a scope.
    /// </summary>
    public partial class WorkloadInsightsTopContributorsRow
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for a specific row of data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property LocalAz. 
        /// <para>
        /// The identifier for the Availability Zone where the local resource is located.
        /// </para>
        /// </summary>
        public string LocalAz { get; set; }

        /// <summary>
        /// Checks to see if the LocalAz property is set.
        /// </summary>
        internal bool IsSetLocalAz() => this.LocalAz != null;

        /// <summary>
        /// Gets and sets the property LocalRegion. 
        /// <para>
        /// The Amazon Web Services Region where the local resource is located.
        /// </para>
        /// </summary>
        public string LocalRegion { get; set; }

        /// <summary>
        /// Checks to see if the LocalRegion property is set.
        /// </summary>
        internal bool IsSetLocalRegion() => this.LocalRegion != null;

        /// <summary>
        /// Gets and sets the property LocalSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local subnet.
        /// </para>
        /// </summary>
        public string LocalSubnetArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalSubnetArn property is set.
        /// </summary>
        internal bool IsSetLocalSubnetArn() => this.LocalSubnetArn != null;

        /// <summary>
        /// Gets and sets the property LocalSubnetId. 
        /// <para>
        /// The subnet identifier for the local resource.
        /// </para>
        /// </summary>
        public string LocalSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the LocalSubnetId property is set.
        /// </summary>
        internal bool IsSetLocalSubnetId() => this.LocalSubnetId != null;

        /// <summary>
        /// Gets and sets the property LocalVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local VPC.
        /// </para>
        /// </summary>
        public string LocalVpcArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalVpcArn property is set.
        /// </summary>
        internal bool IsSetLocalVpcArn() => this.LocalVpcArn != null;

        /// <summary>
        /// Gets and sets the property LocalVpcId. 
        /// <para>
        /// The identifier for the VPC for the local resource.
        /// </para>
        /// </summary>
        public string LocalVpcId { get; set; }

        /// <summary>
        /// Checks to see if the LocalVpcId property is set.
        /// </summary>
        internal bool IsSetLocalVpcId() => this.LocalVpcId != null;

        /// <summary>
        /// Gets and sets the property RemoteIdentifier. 
        /// <para>
        /// The identifier of a remote resource. For a VPC or subnet, this identifier is the VPC
        /// Amazon Resource Name (ARN) or subnet ARN. For an Availability Zone, this identifier
        /// is the AZ name, for example, us-west-2b. For an Amazon Web Services Region , this
        /// identifier is the Region name, for example, us-west-2.
        /// </para>
        /// </summary>
        public string RemoteIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RemoteIdentifier property is set.
        /// </summary>
        internal bool IsSetRemoteIdentifier() => this.RemoteIdentifier != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for a metric.
        /// </para>
        /// </summary>
        public long? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
