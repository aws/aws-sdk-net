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
    /// Contains metadata like FaceId, UserID, and Reasons, for a face that was unsuccessfully
    /// deleted.
    /// </summary>
    public partial class UnsuccessfulFaceDeletion
    {
        /// <summary>
        /// Gets and sets the property FaceId. 
        /// <para>
        ///  A unique identifier assigned to the face.
        /// </para>
        /// </summary>
        public string FaceId { get; set; }

        /// <summary>
        /// Checks to see if the FaceId property is set.
        /// </summary>
        internal bool IsSetFaceId() => this.FaceId != null;

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// The reason why the deletion was unsuccessful. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Reasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Reasons property is set.
        /// </summary>
        internal bool IsSetReasons() => this.Reasons != null && (this.Reasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  A provided ID for the UserID. Unique within the collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
