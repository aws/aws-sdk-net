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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Represents a single entity in the health status check for a WhatsApp Flow.
    /// </summary>
    public partial class MetaFlowHealthEntity
    {
        /// <summary>
        /// Gets and sets the property CanSendMessage. 
        /// <para>
        /// The messaging availability status for this entity (for example, AVAILABLE, LIMITED,
        /// or BLOCKED).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string CanSendMessage { get; set; }

        /// <summary>
        /// Checks to see if the CanSendMessage property is set.
        /// </summary>
        internal bool IsSetCanSendMessage() => this.CanSendMessage != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of entity (for example, FLOW, WABA, BUSINESS, or APP).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
