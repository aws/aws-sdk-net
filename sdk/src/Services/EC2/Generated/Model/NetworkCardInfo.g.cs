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
    /// Describes the network card support of the instance type.
    /// </summary>
    public partial class NetworkCardInfo
    {
        /// <summary>
        /// Gets and sets the property AdditionalFlexibleNetworkInterfaces. 
        /// <para>
        /// The number of additional network interfaces that can be attached to an instance when
        /// using flexible Elastic Network Adapter (ENA) queues. This number is in addition to
        /// the base number specified by <c>maximumNetworkInterfaces</c>.
        /// </para>
        /// </summary>
        public int? AdditionalFlexibleNetworkInterfaces { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalFlexibleNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetAdditionalFlexibleNetworkInterfaces() => this.AdditionalFlexibleNetworkInterfaces.HasValue;

        /// <summary>
        /// Gets and sets the property BaselineBandwidthInGbps. 
        /// <para>
        /// The baseline network performance of the network card, in Gbps.
        /// </para>
        /// </summary>
        public double? BaselineBandwidthInGbps { get; set; }

        /// <summary>
        /// Checks to see if the BaselineBandwidthInGbps property is set.
        /// </summary>
        internal bool IsSetBaselineBandwidthInGbps() => this.BaselineBandwidthInGbps.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultEnaQueueCountPerInterface. 
        /// <para>
        /// The default number of the ENA queues for each interface.
        /// </para>
        /// </summary>
        public int? DefaultEnaQueueCountPerInterface { get; set; }

        /// <summary>
        /// Checks to see if the DefaultEnaQueueCountPerInterface property is set.
        /// </summary>
        internal bool IsSetDefaultEnaQueueCountPerInterface() => this.DefaultEnaQueueCountPerInterface.HasValue;

        /// <summary>
        /// Gets and sets the property InterfaceTypes. 
        /// <para>
        /// The supported interface types for the network card.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InterfaceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InterfaceTypes property is set.
        /// </summary>
        internal bool IsSetInterfaceTypes() => this.InterfaceTypes != null && (this.InterfaceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaximumEnaQueueCount. 
        /// <para>
        /// The maximum number of the ENA queues.
        /// </para>
        /// </summary>
        public int? MaximumEnaQueueCount { get; set; }

        /// <summary>
        /// Checks to see if the MaximumEnaQueueCount property is set.
        /// </summary>
        internal bool IsSetMaximumEnaQueueCount() => this.MaximumEnaQueueCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumEnaQueueCountPerInterface. 
        /// <para>
        /// The maximum number of the ENA queues for each interface.
        /// </para>
        /// </summary>
        public int? MaximumEnaQueueCountPerInterface { get; set; }

        /// <summary>
        /// Checks to see if the MaximumEnaQueueCountPerInterface property is set.
        /// </summary>
        internal bool IsSetMaximumEnaQueueCountPerInterface() => this.MaximumEnaQueueCountPerInterface.HasValue;

        /// <summary>
        /// Gets and sets the property MaximumNetworkInterfaces. 
        /// <para>
        /// The maximum number of network interfaces for the network card.
        /// </para>
        /// </summary>
        public int? MaximumNetworkInterfaces { get; set; }

        /// <summary>
        /// Checks to see if the MaximumNetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetMaximumNetworkInterfaces() => this.MaximumNetworkInterfaces.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkCardIndex. 
        /// <para>
        /// The index of the network card.
        /// </para>
        /// </summary>
        public int? NetworkCardIndex { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCardIndex property is set.
        /// </summary>
        internal bool IsSetNetworkCardIndex() => this.NetworkCardIndex.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkPerformance. 
        /// <para>
        /// The network performance of the network card.
        /// </para>
        /// </summary>
        public string NetworkPerformance { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformance property is set.
        /// </summary>
        internal bool IsSetNetworkPerformance() => this.NetworkPerformance != null;

        /// <summary>
        /// Gets and sets the property PeakBandwidthInGbps. 
        /// <para>
        /// The peak (burst) network performance of the network card, in Gbps.
        /// </para>
        /// </summary>
        public double? PeakBandwidthInGbps { get; set; }

        /// <summary>
        /// Checks to see if the PeakBandwidthInGbps property is set.
        /// </summary>
        internal bool IsSetPeakBandwidthInGbps() => this.PeakBandwidthInGbps.HasValue;
    }
}
