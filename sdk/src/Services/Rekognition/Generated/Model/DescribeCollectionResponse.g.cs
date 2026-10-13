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
    /// This is the response object from the DescribeCollection operation.
    /// </summary>
    public partial class DescribeCollectionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CollectionARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the collection.
        /// </para>
        /// </summary>
        public string CollectionARN { get; set; }

        /// <summary>
        /// Checks to see if the CollectionARN property is set.
        /// </summary>
        internal bool IsSetCollectionARN() => this.CollectionARN != null;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The number of milliseconds since the Unix epoch time until the creation of the collection.
        /// The Unix epoch time is 00:00:00 Coordinated Universal Time (UTC), Thursday, 1 January
        /// 1970.
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property FaceCount. 
        /// <para>
        /// The number of faces that are indexed into the collection. To index faces into a collection,
        /// use <a>IndexFaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FaceCount { get; set; }

        /// <summary>
        /// Checks to see if the FaceCount property is set.
        /// </summary>
        internal bool IsSetFaceCount() => this.FaceCount.HasValue;

        /// <summary>
        /// Gets and sets the property FaceModelVersion. 
        /// <para>
        /// The version of the face model that's used by the collection for face detection.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Model versioning in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        public string FaceModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the FaceModelVersion property is set.
        /// </summary>
        internal bool IsSetFaceModelVersion() => this.FaceModelVersion != null;

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of UserIDs assigned to the specified colleciton.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? UserCount { get; set; }

        /// <summary>
        /// Checks to see if the UserCount property is set.
        /// </summary>
        internal bool IsSetUserCount() => this.UserCount.HasValue;
    }
}
