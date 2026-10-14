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
    /// Container for the parameters to the SearchUsers operation. Searches for UserIDs within
    /// a collection based on a <c>FaceId</c> or <c>UserId</c>. This API can be used to find
    /// the closest UserID (with a highest similarity) to associate a face. The request must
    /// be provided with either <c>FaceId</c> or <c>UserId</c>. The operation returns an array
    /// of UserID that match the <c>FaceId</c> or <c>UserId</c>, ordered by similarity score
    /// with the highest similarity first.
    /// </summary>
    public partial class SearchUsersRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property CollectionId. 
        /// <para>
        /// The ID of an existing collection containing the UserID, used with a UserId or FaceId.
        /// If a FaceId is provided, UserId isn’t required to be present in the Collection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CollectionId { get; set; }

        /// <summary>
        /// Checks to see if the CollectionId property is set.
        /// </summary>
        internal bool IsSetCollectionId() => this.CollectionId != null;

        /// <summary>
        /// Gets and sets the property FaceId. 
        /// <para>
        /// ID for the existing face.
        /// </para>
        /// </summary>
        public string FaceId { get; set; }

        /// <summary>
        /// Checks to see if the FaceId property is set.
        /// </summary>
        internal bool IsSetFaceId() => this.FaceId != null;

        /// <summary>
        /// Gets and sets the property MaxUsers. 
        /// <para>
        /// Maximum number of identities to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxUsers { get; set; }

        /// <summary>
        /// Checks to see if the MaxUsers property is set.
        /// </summary>
        internal bool IsSetMaxUsers() => this.MaxUsers.HasValue;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// ID for the existing User.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserMatchThreshold. 
        /// <para>
        /// Optional value that specifies the minimum confidence in the matched UserID to return.
        /// Default value of 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? UserMatchThreshold { get; set; }

        /// <summary>
        /// Checks to see if the UserMatchThreshold property is set.
        /// </summary>
        internal bool IsSetUserMatchThreshold() => this.UserMatchThreshold.HasValue;
    }
}
