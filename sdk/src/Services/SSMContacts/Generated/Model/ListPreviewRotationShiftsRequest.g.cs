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
    /// Container for the parameters to the ListPreviewRotationShifts operation. Returns a
    /// list of shifts based on rotation configuration parameters. <note> <para> The Incident
    /// Manager primarily uses this operation to populate the <b>Preview</b> calendar. It
    /// is not typically run by end users. </para> </note>
    /// </summary>
    public partial class ListPreviewRotationShiftsRequest : AmazonSSMContactsRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time a rotation shift would end.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that can be specified in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The contacts that would be assigned to a rotation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public List<string> Members { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Members property is set.
        /// </summary>
        internal bool IsSetMembers() => this.Members != null && (this.Members.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. This token is used to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// Information about changes that would be made in a rotation override.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PreviewOverride> Overrides { get; set; } = AWSConfigs.InitializeCollections ? new List<PreviewOverride>() : null;

        /// <summary>
        /// Checks to see if the Overrides property is set.
        /// </summary>
        internal bool IsSetOverrides() => this.Overrides != null && (this.Overrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Recurrence. 
        /// <para>
        /// Information about how long a rotation would last before restarting at the beginning
        /// of the shift order.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecurrenceSettings Recurrence { get; set; }

        /// <summary>
        /// Checks to see if the Recurrence property is set.
        /// </summary>
        internal bool IsSetRecurrence() => this.Recurrence != null;

        /// <summary>
        /// Gets and sets the property RotationStartTime. 
        /// <para>
        /// The date and time a rotation would begin. The first shift is calculated from this
        /// date and time.
        /// </para>
        /// </summary>
        public DateTime? RotationStartTime { get; set; }

        /// <summary>
        /// Checks to see if the RotationStartTime property is set.
        /// </summary>
        internal bool IsSetRotationStartTime() => this.RotationStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Used to filter the range of calculated shifts before sending the response back to
        /// the user. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TimeZoneId. 
        /// <para>
        /// The time zone the rotation’s activity would be based on, in Internet Assigned Numbers
        /// Authority (IANA) format. For example: "America/Los_Angeles", "UTC", or "Asia/Seoul".
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Checks to see if the TimeZoneId property is set.
        /// </summary>
        internal bool IsSetTimeZoneId() => this.TimeZoneId != null;
    }
}
