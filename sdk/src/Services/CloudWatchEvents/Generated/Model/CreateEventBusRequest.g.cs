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

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventBus operation. Creates a new event
    /// bus within your account. This can be a custom event bus which you can use to receive
    /// events from your custom applications and services, or it can be a partner event bus
    /// which can be matched to a partner event source.
    /// </summary>
    public partial class CreateEventBusRequest : AmazonCloudWatchEventsRequest
    {
        /// <summary>
        /// Gets and sets the property EventSourceName. 
        /// <para>
        /// If you are creating a partner event bus, this specifies the partner event source that
        /// the new event bus will be matched with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// Checks to see if the EventSourceName property is set.
        /// </summary>
        internal bool IsSetEventSourceName() => this.EventSourceName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new event bus. 
        /// </para>
        ///  
        /// <para>
        /// Event bus names cannot contain the / character. You can't use the name <c>default</c>
        /// for a custom event bus, as this name is already used for your account's default event
        /// bus.
        /// </para>
        ///  
        /// <para>
        /// If this is a partner event bus, the name must exactly match the name of the partner
        /// event source that this event bus is matched to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the event bus.
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
