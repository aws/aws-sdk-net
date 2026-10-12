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
    /// Summary information about a single version of a network connector returned by <c>ListNetworkConnectorVersions</c>.
    /// Each configuration update creates a new immutable version; this shape describes one
    /// such version. To retrieve the full configuration of a version, call <c>GetNetworkConnector</c>
    /// with a version-qualified identifier.
    /// </summary>
    public partial class NetworkConnectorVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unqualified ARN of the network connector that this version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

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
        /// The date and time when this connector version was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of this connector version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkConnectorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// A human-readable explanation of the current state, populated when the state is <c>FAILED</c>.
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
        /// The version number of this connector version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;

        /// <summary>
        /// Gets and sets the property VersionArn. 
        /// <para>
        /// The qualified ARN of this connector version, including the immutable version suffix.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string VersionArn { get; set; }

        /// <summary>
        /// Checks to see if the VersionArn property is set.
        /// </summary>
        internal bool IsSetVersionArn() => this.VersionArn != null;
    }
}
