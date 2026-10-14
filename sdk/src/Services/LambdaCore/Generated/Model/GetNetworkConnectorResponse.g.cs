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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkConnector operation.
    /// </summary>
    public partial class GetNetworkConnectorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The network configuration of the connector, including VPC subnets and security groups.
        /// </para>
        /// </summary>
        public NetworkConnectorConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time when the connector configuration was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the most recent update operation (<c>Successful</c>, <c>Failed</c>,
        /// or <c>InProgress</c>).
        /// </para>
        /// </summary>
        public NetworkConnectorLastUpdateStatus LastUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatus property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatus() => this.LastUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReason. 
        /// <para>
        /// A human-readable explanation of the last update status.
        /// </para>
        /// </summary>
        public string LastUpdateStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatusReason property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatusReason() => this.LastUpdateStatusReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdateStatusReasonCode. 
        /// <para>
        /// A machine-readable code indicating the reason for the last update status. Use this
        /// for programmatic error handling.
        /// </para>
        /// </summary>
        public NetworkConnectorLastUpdateStatusReasonCode LastUpdateStatusReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatusReasonCode property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatusReasonCode() => this.LastUpdateStatusReasonCode != null;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The version number of the connector's latest active version. Each configuration update
        /// creates a new immutable version; this attribute exposes the most recent one. This
        /// field is returned only on a standard (unqualified) request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? LatestVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersion property is set.
        /// </summary>
        internal bool IsSetLatestVersion() => this.LatestVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersionArn. 
        /// <para>
        /// The qualified ARN of the connector's latest active version, including the immutable
        /// version suffix. This field is returned only on a standard (unqualified) request; when
        /// you supply a version-qualified identifier it is not returned, and <c>VersionArn</c>
        /// is returned instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string LatestVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionArn property is set.
        /// </summary>
        internal bool IsSetLatestVersionArn() => this.LatestVersionArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network connector.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OperatorRole. 
        /// <para>
        /// The ARN of the IAM role that Lambda uses to manage the underlying ENI resources for
        /// this connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string OperatorRole { get; set; }

        /// <summary>
        /// Checks to see if the OperatorRole property is set.
        /// </summary>
        internal bool IsSetOperatorRole() => this.OperatorRole != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the network connector.
        /// </para>
        /// </summary>
        public NetworkConnectorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A human-readable explanation of the current state, populated when the state is <c>FAILED</c>
        /// or <c>DELETE_FAILED</c>.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateReasonCode. 
        /// <para>
        /// A machine-readable code indicating the reason for the current state. Use this for
        /// programmatic error handling.
        /// </para>
        /// </summary>
        public NetworkConnectorStateReasonCode StateReasonCode { get; set; }

        /// <summary>
        /// Checks to see if the StateReasonCode property is set.
        /// </summary>
        internal bool IsSetStateReasonCode() => this.StateReasonCode != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the network connector. On a standard (unqualified) request,
        /// this is the connector's current version; each configuration update increments it.
        /// When you supply a version-qualified identifier, this is the specific version you requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;

        /// <summary>
        /// Gets and sets the property VersionArn. 
        /// <para>
        /// The qualified ARN of the specific connector version returned by this request, including
        /// the immutable version suffix. This is populated only when you supply a version-qualified
        /// identifier. On a standard (unqualified) request, this field is not populated; the
        /// connector's latest active version is returned instead through the <c>LatestVersionArn</c>
        /// and <c>LatestVersion</c> fields described below.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 140)]
        public string VersionArn { get; set; }

        /// <summary>
        /// Checks to see if the VersionArn property is set.
        /// </summary>
        internal bool IsSetVersionArn() => this.VersionArn != null;
    }
}
