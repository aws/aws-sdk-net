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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the content of a particular audit event.
    /// </summary>
    public partial class AuditEvent
    {
        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// Unique identifier of a case audit history event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A list of Case Audit History event fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AuditEventField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditEventField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PerformedBy. 
        /// <para>
        /// Information of the user which performed the audit.
        /// </para>
        /// </summary>
        public AuditEventPerformedBy PerformedBy { get; set; }

        /// <summary>
        /// Checks to see if the PerformedBy property is set.
        /// </summary>
        internal bool IsSetPerformedBy() => this.PerformedBy != null;

        /// <summary>
        /// Gets and sets the property PerformedTime. 
        /// <para>
        /// Time at which an Audit History event took place.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? PerformedTime { get; set; }

        /// <summary>
        /// Checks to see if the PerformedTime property is set.
        /// </summary>
        internal bool IsSetPerformedTime() => this.PerformedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RelatedItemType. 
        /// <para>
        /// The Type of the related item.
        /// </para>
        /// </summary>
        public RelatedItemType RelatedItemType { get; set; }

        /// <summary>
        /// Checks to see if the RelatedItemType property is set.
        /// </summary>
        internal bool IsSetRelatedItemType() => this.RelatedItemType != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of audit history event.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Case.Created</c> | <c>Case.Updated</c> | <c>RelatedItem.Created</c>
        /// | <c>RelatedItem.Updated</c> | <c>RelatedItem.Deleted</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuditEventType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
