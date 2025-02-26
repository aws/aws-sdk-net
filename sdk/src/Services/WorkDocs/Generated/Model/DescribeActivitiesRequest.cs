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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
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
    /// Container for the parameters to the DescribeActivities operation.
    /// Describes the user activities in a specified time period.
    /// </summary>
    public partial class DescribeActivitiesRequest : AmazonWorkDocsRequest
    {
        private string _activityTypes;
        private string _authenticationToken;
        private DateTime? _endTime;
        private bool? _includeIndirectActivities;
        private int? _limit;
        private string _marker;
        private string _organizationId;
        private string _resourceId;
        private DateTime? _startTime;
        private string _userId;

        /// <summary>
        /// Gets and sets the property ActivityTypes. 
        /// <para>
        /// Specifies which activity types to include in the response. If this field is left empty,
        /// all activity types are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ActivityTypes
        {
            get { return this._activityTypes; }
            set { this._activityTypes = value; }
        }

        // Check to see if ActivityTypes property is set
        internal bool IsSetActivityTypes()
        {
            return this._activityTypes != null;
        }

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that determines the end time of the activities. The response includes
        /// the activities performed before the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeIndirectActivities. 
        /// <para>
        /// Includes indirect activities. An indirect activity results from a direct activity
        /// performed on a parent resource. For example, sharing a parent folder (the direct activity)
        /// shares all of the subfolders and documents within the parent folder (the indirect
        /// activity).
        /// </para>
        /// </summary>
        public bool? IncludeIndirectActivities
        {
            get { return this._includeIndirectActivities; }
            set { this._includeIndirectActivities = value; }
        }

        // Check to see if IncludeIndirectActivities property is set
        internal bool IsSetIncludeIndirectActivities()
        {
            return this._includeIndirectActivities.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12288)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization. This is a mandatory parameter when using administrative
        /// API (SigV4) requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The document or folder ID for which to describe activity types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that determines the starting time of the activities. The response includes
        /// the activities performed after the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user who performed the action. The response includes activities pertaining
        /// to this user. This is an optional parameter and is only applicable for administrative
        /// API (SigV4) requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}