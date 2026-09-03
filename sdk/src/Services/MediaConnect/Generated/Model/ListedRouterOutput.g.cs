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

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a router output, including its name, type, ARN, ID, state, routed state,
    /// and other key details. This structure is used in the response of the ListRouterOutputs
    /// operation.
    /// </summary>
    public partial class ListedRouterOutput
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the router output was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MaintenanceSchedule. 
        /// <para>
        /// The details of the maintenance schedule for the listed router output.
        /// </para>
        /// </summary>
        public MaintenanceSchedule MaintenanceSchedule { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceSchedule property is set.
        /// </summary>
        internal bool IsSetMaintenanceSchedule() => this.MaintenanceSchedule != null;

        /// <summary>
        /// Gets and sets the property MaintenanceScheduleType. 
        /// <para>
        /// The type of maintenance schedule currently associated with the listed router output.
        /// </para>
        /// </summary>
        public MaintenanceScheduleType MaintenanceScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceScheduleType property is set.
        /// </summary>
        internal bool IsSetMaintenanceScheduleType() => this.MaintenanceScheduleType != null;

        /// <summary>
        /// Gets and sets the property MaximumBitrate. 
        /// <para>
        /// The maximum bitrate of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaximumBitrate { get; set; }

        /// <summary>
        /// Checks to see if the MaximumBitrate property is set.
        /// </summary>
        internal bool IsSetMaximumBitrate() => this.MaximumBitrate.HasValue;

        /// <summary>
        /// Gets and sets the property MessageCount. 
        /// <para>
        /// The number of messages associated with the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MessageCount { get; set; }

        /// <summary>
        /// Checks to see if the MessageCount property is set.
        /// </summary>
        internal bool IsSetMessageCount() => this.MessageCount.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArn. 
        /// <para>
        /// The ARN of the network interface associated with the router output.
        /// </para>
        /// </summary>
        public string NetworkInterfaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceArn property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceArn() => this.NetworkInterfaceArn != null;

        /// <summary>
        /// Gets and sets the property OutputType. 
        /// <para>
        /// The type of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputType OutputType { get; set; }

        /// <summary>
        /// Checks to see if the OutputType property is set.
        /// </summary>
        internal bool IsSetOutputType() => this.OutputType != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The AAmazon Web Services Region where the router output is located.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property RoutedInputArn. 
        /// <para>
        /// The ARN of the router input associated with the output.
        /// </para>
        /// </summary>
        public string RoutedInputArn { get; set; }

        /// <summary>
        /// Checks to see if the RoutedInputArn property is set.
        /// </summary>
        internal bool IsSetRoutedInputArn() => this.RoutedInputArn != null;

        /// <summary>
        /// Gets and sets the property RoutedState. 
        /// <para>
        /// The current state of the association between the router output and its input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputRoutedState RoutedState { get; set; }

        /// <summary>
        /// Checks to see if the RoutedState property is set.
        /// </summary>
        internal bool IsSetRoutedState() => this.RoutedState != null;

        /// <summary>
        /// Gets and sets the property RoutingScope. 
        /// <para>
        /// Indicates whether the router output is configured for Regional or global routing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RoutingScope RoutingScope { get; set; }

        /// <summary>
        /// Checks to see if the RoutingScope property is set.
        /// </summary>
        internal bool IsSetRoutingScope() => this.RoutingScope != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The overall state of the router output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouterOutputState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the router output was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
