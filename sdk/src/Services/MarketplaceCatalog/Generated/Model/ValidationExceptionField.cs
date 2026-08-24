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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
        private string _changeType;
        private string _entityId;
        private string _entityType;
        private string _field;
        private string _message;
        private ValidationExceptionReason _reason;

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// The change type the failing field applies to, if the field is part of a change request.
        /// For example, <c>AddDeliveryOptions</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity identifier the failing field applies to, if the field is on a specific
        /// entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The entity type the failing field applies to, if the field is on a specific entity.
        /// For example, <c>AmiProduct@1.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The name of the request field that failed validation, expressed as a JSON path (for
        /// example, <c>Details.DeliveryOptions[0].Type</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing why the field failed validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason the field failed validation.
        /// </para>
        /// </summary>
        public ValidationExceptionReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}