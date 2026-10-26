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
    /// The Amazon Web Services account that a partner event source has been offered to.
    /// </summary>
    public partial class PartnerEventSourceAccount
    {
        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The Amazon Web Services account ID that the partner event source was offered to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the event source was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationTime. 
        /// <para>
        /// The date and time that the event source will expire, if the Amazon Web Services account
        /// doesn't create a matching event bus for it.
        /// </para>
        /// </summary>
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationTime property is set.
        /// </summary>
        internal bool IsSetExpirationTime() => this.ExpirationTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the event source. If it is ACTIVE, you have already created a matching
        /// event bus for this event source, and that event bus is active. If it is PENDING, either
        /// you haven't yet created a matching event bus, or that event bus is deactivated. If
        /// it is DELETED, you have created a matching event bus, but the event source has since
        /// been deleted.
        /// </para>
        /// </summary>
        public EventSourceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
