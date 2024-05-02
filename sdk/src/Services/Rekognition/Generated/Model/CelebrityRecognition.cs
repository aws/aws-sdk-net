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
    /// Information about a detected celebrity and the time the celebrity was detected in
    /// a stored video. For more information, see GetCelebrityRecognition in the Amazon Rekognition
    /// Developer Guide.
    /// </summary>
    public partial class CelebrityRecognition
    {
        private CelebrityDetail _celebrity;
        private long? _timestamp;

        /// <summary>
        /// Gets and sets the property Celebrity. 
        /// <para>
        /// Information about a recognized celebrity.
        /// </para>
        /// </summary>
        public CelebrityDetail Celebrity
        {
            get { return this._celebrity; }
            set { this._celebrity = value; }
        }

        // Check to see if Celebrity property is set
        internal bool IsSetCelebrity()
        {
            return this._celebrity != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time, in milliseconds from the start of the video, that the celebrity was recognized.
        /// Note that <c>Timestamp</c> is not guaranteed to be accurate to the individual frame
        /// where the celebrity first appears.
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