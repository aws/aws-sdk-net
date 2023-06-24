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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Contains metadata like FaceId, UserID, and Reasons, for a face that was unsuccessfully
    /// associated.
    /// </summary>
    public partial class UnsuccessfulFaceAssociation
    {
        private float? _confidence;
        private string _faceId;
        private List<string> _reasons = new List<string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Match confidence with the UserID, provides information regarding if a face association
        /// was unsuccessful because it didn't meet UserMatchThreshold.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FaceId. 
        /// <para>
        /// A unique identifier assigned to the face. 
        /// </para>
        /// </summary>
        public string FaceId
        {
            get { return this._faceId; }
            set { this._faceId = value; }
        }

        // Check to see if FaceId property is set
        internal bool IsSetFaceId()
        {
            return this._faceId != null;
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        ///  The reason why the association was unsuccessful. 
        /// </para>
        /// </summary>
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && this._reasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// A provided ID for the UserID. Unique within the collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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