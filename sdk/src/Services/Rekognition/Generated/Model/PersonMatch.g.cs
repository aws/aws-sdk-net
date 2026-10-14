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
        /// <summary>
        /// Gets and sets the property FaceMatches. 
        /// <para>
        /// Information about the faces in the input collection that match the face of a person
        /// in the video.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FaceMatch> FaceMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<FaceMatch>() : null;

        /// <summary>
        /// Checks to see if the FaceMatches property is set.
        /// </summary>
        internal bool IsSetFaceMatches() => this.FaceMatches != null && (this.FaceMatches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Person. 
        /// <para>
        /// Information about the matched person.
        /// </para>
        /// </summary>
        public PersonDetail Person { get; set; }

        /// <summary>
        /// Checks to see if the Person property is set.
        /// </summary>
        internal bool IsSetPerson() => this.Person != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time, in milliseconds from the beginning of the video, that the person was matched
        /// in the video.
        /// </para>
        /// </summary>
        public long? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
