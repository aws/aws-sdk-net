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

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRotation operation. Creates a rotation in
    /// an on-call schedule.
    /// </summary>
    public partial class CreateRotationRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property ContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts to add to the rotation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the <c>PERSONAL</c> contact type is supported. The contact types <c>ESCALATION</c>
        /// and <c>ONCALL_SCHEDULE</c> are not supported for this operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The order that you list the contacts in is their shift order in the rotation schedule.
        /// To change the order of the contact's shifts, use the <a>UpdateRotation</a> operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public List<string> ContactIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ContactIds property is set.
        /// </summary>
        internal bool IsSetContactIds() => this.ContactIds != null && (this.ContactIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token that ensures that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Information about the rule that specifies when a shift's team members rotate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecurrenceSettings Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time that the rotation goes into effect.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata to assign to the rotation. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For more information,
        /// see <a href="https://docs.aws.amazon.com/incident-manager/latest/userguide/tagging.html">Tagging
        /// Incident Manager resources</a> in the <i>Incident Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone to base the rotation’s activity on in Internet Assigned Numbers Authority
        /// (IANA) format. For example: "America/Los_Angeles", "UTC", or "Asia/Seoul". For more
        /// information, see the <a href="https://www.iana.org/time-zones">Time Zone Database</a>
        /// on the IANA website.
        /// </para>
        ///  <note> 
        /// <para>
        /// Designators for time zones that don’t support Daylight Savings Time rules, such as
        /// Pacific Standard Time (PST), are not supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Checks to see if the TimeZoneId property is set.
        /// </summary>
        internal bool IsSetTimeZoneId() => this.TimeZoneId != null;
    }
}
