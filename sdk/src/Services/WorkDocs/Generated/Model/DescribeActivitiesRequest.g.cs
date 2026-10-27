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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeActivities operation. Describes the user
    /// activities in a specified time period.
    /// </summary>
    public partial class DescribeActivitiesRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property ActivityTypes. 
        /// <para>
        /// Specifies which activity types to include in the response. If this field is left empty,
        /// all activity types are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ActivityTypes { get; set; }

        /// <summary>
        /// Checks to see if the ActivityTypes property is set.
        /// </summary>
        internal bool IsSetActivityTypes() => this.ActivityTypes != null;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that determines the end time of the activities. The response includes
        /// the activities performed before the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeIndirectActivities. 
        /// <para>
        /// Includes indirect activities. An indirect activity results from a direct activity
        /// performed on a parent resource. For example, sharing a parent folder (the direct activity)
        /// shares all of the subfolders and documents within the parent folder (the indirect
        /// activity).
        /// </para>
        /// </summary>
        public bool? IncludeIndirectActivities { get; set; }

        /// <summary>
        /// Checks to see if the IncludeIndirectActivities property is set.
        /// </summary>
        internal bool IsSetIncludeIndirectActivities() => this.IncludeIndirectActivities.HasValue;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12288)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization. This is a mandatory parameter when using administrative
        /// API (SigV4) requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The document or folder ID for which to describe activity types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that determines the starting time of the activities. The response includes
        /// the activities performed after the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user who performed the action. The response includes activities pertaining
        /// to this user. This is an optional parameter and is only applicable for administrative
        /// API (SigV4) requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
