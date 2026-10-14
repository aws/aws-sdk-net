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
    /// Summary information about a network connector returned by <c>ListNetworkConnectors</c>.
    /// Contains identifying fields and current state. To retrieve full configuration details,
    /// use <c>GetNetworkConnector</c>.
    /// </summary>
    public partial class NetworkConnectorSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the network connector.
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
        /// The date and time when the connector was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The version number of the connector's latest version. Each configuration update creates
        /// a new immutable version; this attribute exposes the most recent one.
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
        /// The qualified ARN of the connector's latest version, including the immutable version
        /// suffix.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the network connector (<c>VPC_EGRESS</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NetworkConnectorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
