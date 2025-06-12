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
    /// Information about a person whose face matches a face(s) in an Amazon Rekognition collection.
    /// Includes information about the faces in the Amazon Rekognition collection (<a>FaceMatch</a>),
    /// information about the person (<a>PersonDetail</a>), and the time stamp for when the
    /// person was detected in a video. An array of <c>PersonMatch</c> objects is returned
    /// by <a>GetFaceSearch</a>.
    /// </summary>
    public partial class PersonMatch
    {
        private List<FaceMatch> _faceMatches = AWSConfigs.InitializeCollections ? new List<FaceMatch>() : null;
        private PersonDetail _person;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// Information about the faces in the input collection that match the face of a person
        /// in the video.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaceMatch> FaceMatches
        {
            get { return this._faceMatches; }
            set { this._faceMatches = value; }
        }

        // Check to see if FaceMatches property is set
        internal bool IsSetFaceMatches()
        {
            return this._faceMatches != null && (this._faceMatches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Person. 
        /// <para>
        /// Information about the matched person.
        /// </para>
        /// </summary>
        public PersonDetail Person
        {
            get { return this._person; }
            set { this._person = value; }
        }

        // Check to see if Person property is set
        internal bool IsSetPerson()
        {
            return this._person != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time, in milliseconds from the beginning of the video, that the person was matched
        /// in the video.
        /// </para>
        /// </summary>
        public long? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}