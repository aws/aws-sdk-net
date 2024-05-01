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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the SearchUsersByImage operation.
    /// Searches for UserIDs using a supplied image. It first detects the largest face in
    /// the image, and then searches a specified collection for matching UserIDs. 
    /// 
    ///  
    /// <para>
    /// The operation returns an array of UserIDs that match the face in the supplied image,
    /// ordered by similarity score with the highest similarity first. It also returns a bounding
    /// box for the face found in the input image. 
    /// </para>
    ///  
    /// <para>
    /// Information about faces detected in the supplied image, but not used for the search,
    /// is returned in an array of <c>UnsearchedFace</c> objects. If no valid face is detected
    /// in the image, the response will contain an empty <c>UserMatches</c> list and no <c>SearchedFace</c>
    /// object. 
    /// </para>
    /// </summary>
    public partial class SearchUsersByImageRequest : AmazonRekognitionRequest
    {
        private string _collectionId;
        private Image _image;
        private int? _maxUsers;
        private QualityFilter _qualityFilter;
        private float? _userMatchThreshold;

        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of an existing collection containing the UserID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string CollectionId
        {
            get { return this._collectionId; }
            set { this._collectionId = value; }
        }

        // Check to see if CollectionId property is set
        internal bool IsSetCollectionId()
        {
            return this._collectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Image.
        /// </summary>
        [AWSProperty(Required=true)]
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property MaxUsers. 
        /// <para>
        /// Maximum number of UserIDs to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? MaxUsers
        {
            get { return this._maxUsers; }
            set { this._maxUsers = value; }
        }

        // Check to see if MaxUsers property is set
        internal bool IsSetMaxUsers()
        {
            return this._maxUsers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualityFilter. 
        /// <para>
        /// A filter that specifies a quality bar for how much filtering is done to identify faces.
        /// Filtered faces aren't searched for in the collection. The default value is NONE.
        /// </para>
        /// </summary>
        public QualityFilter QualityFilter
        {
            get { return this._qualityFilter; }
            set { this._qualityFilter = value; }
        }

        // Check to see if QualityFilter property is set
        internal bool IsSetQualityFilter()
        {
            return this._qualityFilter != null;
        }

        /// <summary>
        /// Gets and sets the property UserMatchThreshold. 
        /// <para>
        /// Specifies the minimum confidence in the UserID match to return. Default value is 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? UserMatchThreshold
        {
            get { return this._userMatchThreshold; }
            set { this._userMatchThreshold = value; }
        }

        // Check to see if UserMatchThreshold property is set
        internal bool IsSetUserMatchThreshold()
        {
            return this._userMatchThreshold.HasValue; 
        }

    }
}