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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeEventBus operation.
    /// </summary>
    public partial class DescribeEventBusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the event bus was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Free-text description. Used by every resource type that has one: event buses, subscribers,
        /// and event sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Encryption configuration for an event bus.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EventBusArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an event bus.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time the event bus was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of an event bus. The first character must be alphanumeric; the remaining characters
        /// may also include '.', '-', and '_'. The grammar matches the name segment of EventBusArn
        /// (event-busv2/&lt;name&gt;/&lt;id&gt;), so every valid name can be represented in the
        /// bus's ARN. The same type is used everywhere a bus name appears.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Lifecycle state of an event bus.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING: Bus creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED: Bus creation failed; see StateReason. The bus cannot be recovered or
        /// recreated in place: delete it with DeleteEventBus, then create a new bus.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE: Bus is fully operational and can accept events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING: Bus update is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATE_FAILED: Bus update failed; the bus remains operational with its previous configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING: Bus deletion is actively in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED: Bus deletion failed; see StateReason. Retry DeleteEventBus after removing
        /// subscribers and event sources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BusState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Human-readable explanation of why an event bus is in its current State. Omitted when
        /// the bus is in a normal operational state (ACTIVE). It stands in for the error response
        /// an asynchronous failure cannot return, so it applies only to resources with an asynchronous
        /// lifecycle: event buses. EventSources and subscribers are provisioned synchronously
        /// and report failures directly on the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// Event storage configuration of an event bus, as returned on reads.
        /// </para>
        /// </summary>
        public StorageConfigurationOutput StorageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfiguration property is set.
        /// </summary>
        internal bool IsSetStorageConfiguration() => this.StorageConfiguration != null;
    }
}
