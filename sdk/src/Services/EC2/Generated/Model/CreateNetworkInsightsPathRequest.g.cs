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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNetworkInsightsPath operation. Creates a
    /// path to analyze for reachability. <para> Reachability Analyzer enables you to analyze
    /// and debug network reachability between two resources in your virtual private cloud
    /// (VPC). For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/reachability/">Reachability
    /// Analyzer Guide</a>. </para>
    /// </summary>
    public partial class CreateNetworkInsightsPathRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The ID or ARN of the destination. If the resource is in another account, you must
        /// specify an ARN.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationIp. 
        /// <para>
        /// The IP address of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public string DestinationIp { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIp property is set.
        /// </summary>
        internal bool IsSetDestinationIp() => this.DestinationIp != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property FilterAtDestination. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the destination.
        /// If you specify this parameter, you can't specify the parameter for the destination
        /// IP address.
        /// </para>
        /// </summary>
        public PathRequestFilter FilterAtDestination { get; set; }

        /// <summary>
        /// Checks to see if the FilterAtDestination property is set.
        /// </summary>
        internal bool IsSetFilterAtDestination() => this.FilterAtDestination != null;

        /// <summary>
        /// Gets and sets the property FilterAtSource. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the source. If
        /// you specify this parameter, you can't specify the parameters for the source IP address
        /// or the destination port.
        /// </para>
        /// </summary>
        public PathRequestFilter FilterAtSource { get; set; }

        /// <summary>
        /// Checks to see if the FilterAtSource property is set.
        /// </summary>
        internal bool IsSetFilterAtSource() => this.FilterAtSource != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The ID or ARN of the source. If the resource is in another account, you must specify
        /// an ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 15)]
        public string SourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SourceIp property is set.
        /// </summary>
        internal bool IsSetSourceIp() => this.SourceIp != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to add to the path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
