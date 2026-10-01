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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Detailed information about a single request field that failed validation, including
    /// the field's location, the reason it failed, and a human-readable message.
    /// </summary>
    public partial class ValidationExceptionField
    {
        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The change type the failing field applies to, if the field is part of a change request.
        /// For example, <c>AddDeliveryOptions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ChangeType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeType property is set.
        /// </summary>
        internal bool IsSetChangeType() => this.ChangeType != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity identifier the failing field applies to, if the field is on a specific
        /// entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The entity type the failing field applies to, if the field is on a specific entity.
        /// For example, <c>AmiProduct@1.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of the request field that failed validation, expressed as a JSON path (for
        /// example, <c>Details.DeliveryOptions[0].Type</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing why the field failed validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the field failed validation.
        /// </para>
        /// </summary>
        public ValidationExceptionReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
