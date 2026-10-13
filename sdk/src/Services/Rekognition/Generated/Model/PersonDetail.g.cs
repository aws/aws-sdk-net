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
    /// Details about a person detected in a video analysis request.
    /// </summary>
    public partial class PersonDetail
    {
        /// <summary>
        /// Gets and sets the property BoundingBox. 
        /// <para>
        /// Bounding box around the detected person.
        /// </para>
        /// </summary>
        public BoundingBox BoundingBox { get; set; }

        /// <summary>
        /// Checks to see if the BoundingBox property is set.
        /// </summary>
        internal bool IsSetBoundingBox() => this.BoundingBox != null;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Face details for the detected person.
        /// </para>
        /// </summary>
        public FaceDetail Face { get; set; }

        /// <summary>
        /// Checks to see if the Face property is set.
        /// </summary>
        internal bool IsSetFace() => this.Face != null;

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// Identifier for the person detected person within a video. Use to keep track of the
        /// person throughout the video. The identifier is not stored by Amazon Rekognition.
        /// </para>
        /// </summary>
        public long? Index { get; set; }

        /// <summary>
        /// Checks to see if the Index property is set.
        /// </summary>
        internal bool IsSetIndex() => this.Index.HasValue;
    }
}
