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
    /// This is the response object from the CreateLibraryItem operation.
    /// </summary>
    public partial class CreateLibraryItemResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private bool? _isVerified;
        private string _libraryItemId;
        private int? _ratingCount;
        private string _status;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the library item was created.
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
        /// The user who created the library item.
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
        /// The unique identifier of the new library item.
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
        /// The number of ratings the library item has received from users.
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
        /// The status of the new library item, such as "Published".
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

    }
}