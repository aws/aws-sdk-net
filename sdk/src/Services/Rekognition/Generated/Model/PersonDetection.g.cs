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
    /// Details and path tracking information for a single time a person's path is tracked
    /// in a video. Amazon Rekognition operations that track people's paths return an array
    /// of <c>PersonDetection</c> objects with elements for each time a person's path is tracked
    /// in a video. 
    /// 
    ///  
    /// <para>
    /// For more information, see GetPersonTracking in the Amazon Rekognition Developer Guide.
    /// 
    /// </para>
    /// </summary>
    public partial class PersonDetection
    {
        /// <summary>
        /// Gets and sets the property Person. 
        /// <para>
        /// Details about a person whose path was tracked in a video.
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
        /// The time, in milliseconds from the start of the video, that the person's path was
        /// tracked. Note that <c>Timestamp</c> is not guaranteed to be accurate to the individual
        /// frame where the person's path first appears.
        /// </para>
        /// </summary>
        public long? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
