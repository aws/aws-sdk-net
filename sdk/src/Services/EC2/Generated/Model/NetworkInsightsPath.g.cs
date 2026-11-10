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
    /// Describes a path.
    /// </summary>
    public partial class NetworkInsightsPath
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The time stamp when the path was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string DestinationArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationArn property is set.
        /// </summary>
        internal bool IsSetDestinationArn() => this.DestinationArn != null;

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
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property FilterAtDestination. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the destination.
        /// </para>
        /// </summary>
        public PathFilter FilterAtDestination { get; set; }

        /// <summary>
        /// Checks to see if the FilterAtDestination property is set.
        /// </summary>
        internal bool IsSetFilterAtDestination() => this.FilterAtDestination != null;

        /// <summary>
        /// Gets and sets the property FilterAtSource. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the source.
        /// </para>
        /// </summary>
        public PathFilter FilterAtSource { get; set; }

        /// <summary>
        /// Checks to see if the FilterAtSource property is set.
        /// </summary>
        internal bool IsSetFilterAtSource() => this.FilterAtSource != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string NetworkInsightsPathArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsPathArn property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsPathArn() => this.NetworkInsightsPathArn != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path.
        /// </para>
        /// </summary>
        public string NetworkInsightsPathId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsPathId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsPathId() => this.NetworkInsightsPathId != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public Protocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The ID of the source.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
