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
    /// Contains metadata like FaceId, UserID, and Reasons, for a face that was unsuccessfully
    /// deleted.
    /// </summary>
    public partial class UnsuccessfulFaceDeletion
    {
        private string _faceId;
        private List<string> _reasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userId;

        /// <summary>
        /// Gets and sets the property FaceId. 
        /// <para>
        ///  A unique identifier assigned to the face.
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
        /// The reason why the deletion was unsuccessful. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && (this._reasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  A provided ID for the UserID. Unique within the collection. 
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