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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the content of a particular audit event.
    /// </summary>
    public partial class AuditEvent
    {
        private string _eventId;
        private List<AuditEventField> _fields = AWSConfigs.InitializeCollections ? new List<AuditEventField>() : null;
        private AuditEventPerformedBy _performedBy;
        private DateTime? _performedTime;
        private RelatedItemType _relatedItemType;
        private AuditEventType _type;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// Unique identifier of a case audit history event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A list of Case Audit History event fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AuditEventField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// Information of the user which performed the audit.
        /// </para>
        /// </summary>
        public AuditEventPerformedBy PerformedBy
        {
            get { return this._performedBy; }
            set { this._performedBy = value; }
        }

        // Check to see if PerformedBy property is set
        internal bool IsSetPerformedBy()
        {
            return this._performedBy != null;
        }

        /// <summary>
        /// Gets and sets the property PerformedTime. 
        /// <para>
        /// Time at which an Audit History event took place.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? PerformedTime
        {
            get { return this._performedTime; }
            set { this._performedTime = value; }
        }

        // Check to see if PerformedTime property is set
        internal bool IsSetPerformedTime()
        {
            return this._performedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelatedItemType. 
        /// <para>
        /// The Type of the related item.
        /// </para>
        /// </summary>
        public RelatedItemType RelatedItemType
        {
            get { return this._relatedItemType; }
            set { this._relatedItemType = value; }
        }

        // Check to see if RelatedItemType property is set
        internal bool IsSetRelatedItemType()
        {
            return this._relatedItemType != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Type of an audit history event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuditEventType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}