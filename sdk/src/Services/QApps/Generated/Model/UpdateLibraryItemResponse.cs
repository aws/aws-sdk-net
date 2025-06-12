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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the UpdateLibraryItem operation.
    /// </summary>
    public partial class UpdateLibraryItemResponse : AmazonWebServiceResponse
    {
        private string _appId;
        private int? _appVersion;
        private List<Category> _categories = AWSConfigs.InitializeCollections ? new List<Category>() : null;
        private DateTime? _createdAt;
        private string _createdBy;
        private bool? _isRatedByUser;
        private bool? _isVerified;
        private string _libraryItemId;
        private int? _ratingCount;
        private string _status;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique identifier of the Q App associated with the library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the Q App associated with the library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2147483647)]
        public int? AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// The categories associated with the updated library item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3)]
        public List<Category> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && (this._categories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the library item was originally created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who originally created the library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property IsRatedByUser. 
        /// <para>
        /// Whether the current user has rated the library item.
        /// </para>
        /// </summary>
        public bool? IsRatedByUser
        {
            get { return this._isRatedByUser; }
            set { this._isRatedByUser = value; }
        }

        // Check to see if IsRatedByUser property is set
        internal bool IsSetIsRatedByUser()
        {
            return this._isRatedByUser.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsVerified. 
        /// <para>
        /// Indicates whether the library item has been verified.
        /// </para>
        /// </summary>
        public bool? IsVerified
        {
            get { return this._isVerified; }
            set { this._isVerified = value; }
        }

        // Check to see if IsVerified property is set
        internal bool IsSetIsVerified()
        {
            return this._isVerified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LibraryItemId. 
        /// <para>
        /// The unique identifier of the updated library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LibraryItemId
        {
            get { return this._libraryItemId; }
            set { this._libraryItemId = value; }
        }

        // Check to see if LibraryItemId property is set
        internal bool IsSetLibraryItemId()
        {
            return this._libraryItemId != null;
        }

        /// <summary>
        /// Gets and sets the property RatingCount. 
        /// <para>
        /// The number of ratings the library item has received.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? RatingCount
        {
            get { return this._ratingCount; }
            set { this._ratingCount = value; }
        }

        // Check to see if RatingCount property is set
        internal bool IsSetRatingCount()
        {
            return this._ratingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of the updated library item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the library item was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user who last updated the library item.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users who have the associated Q App.
        /// </para>
        /// </summary>
        public int? UserCount
        {
            get { return this._userCount; }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}