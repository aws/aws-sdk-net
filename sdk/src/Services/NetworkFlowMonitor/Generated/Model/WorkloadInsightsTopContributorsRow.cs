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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
        private string _accountId;
        private string _localAz;
        private string _localRegion;
        private string _localSubnetArn;
        private string _localSubnetId;
        private string _localVpcArn;
        private string _localVpcId;
        private string _remoteIdentifier;
        private long? _value;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for a specific row of data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalAz. 
        /// <para>
        /// The identifier for the Availability Zone where the local resource is located.
        /// </para>
        /// </summary>
        public string LocalAz
        {
            get { return this._localAz; }
            set { this._localAz = value; }
        }

        // Check to see if LocalAz property is set
        internal bool IsSetLocalAz()
        {
            return this._localAz != null;
        }

        /// <summary>
        /// Gets and sets the property LocalRegion. 
        /// <para>
        /// The Amazon Web Services Region where the local resource is located.
        /// </para>
        /// </summary>
        public string LocalRegion
        {
            get { return this._localRegion; }
            set { this._localRegion = value; }
        }

        // Check to see if LocalRegion property is set
        internal bool IsSetLocalRegion()
        {
            return this._localRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LocalSubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local subnet.
        /// </para>
        /// </summary>
        public string LocalSubnetArn
        {
            get { return this._localSubnetArn; }
            set { this._localSubnetArn = value; }
        }

        // Check to see if LocalSubnetArn property is set
        internal bool IsSetLocalSubnetArn()
        {
            return this._localSubnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalSubnetId. 
        /// <para>
        /// The subnet identifier for the local resource.
        /// </para>
        /// </summary>
        public string LocalSubnetId
        {
            get { return this._localSubnetId; }
            set { this._localSubnetId = value; }
        }

        // Check to see if LocalSubnetId property is set
        internal bool IsSetLocalSubnetId()
        {
            return this._localSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVpcArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a local VPC.
        /// </para>
        /// </summary>
        public string LocalVpcArn
        {
            get { return this._localVpcArn; }
            set { this._localVpcArn = value; }
        }

        // Check to see if LocalVpcArn property is set
        internal bool IsSetLocalVpcArn()
        {
            return this._localVpcArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVpcId. 
        /// <para>
        /// The identifier for the VPC for the local resource.
        /// </para>
        /// </summary>
        public string LocalVpcId
        {
            get { return this._localVpcId; }
            set { this._localVpcId = value; }
        }

        // Check to see if LocalVpcId property is set
        internal bool IsSetLocalVpcId()
        {
            return this._localVpcId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteIdentifier. 
        /// <para>
        /// The identifier of a remote resource. For a VPC or subnet, this identifier is the VPC
        /// Amazon Resource Name (ARN) or subnet ARN. For an Availability Zone, this identifier
        /// is the AZ name, for example, us-west-2b. For an Amazon Web Services Region , this
        /// identifier is the Region name, for example, us-west-2.
        /// </para>
        /// </summary>
        public string RemoteIdentifier
        {
            get { return this._remoteIdentifier; }
            set { this._remoteIdentifier = value; }
        }

        // Check to see if RemoteIdentifier property is set
        internal bool IsSetRemoteIdentifier()
        {
            return this._remoteIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for a metric.
        /// </para>
        /// </summary>
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}