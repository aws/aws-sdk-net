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
    /// This is the response object from the AssociateFaces operation.
    /// </summary>
    public partial class AssociateFacesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedFaces. 
        /// <para>
        /// An array of AssociatedFace objects containing FaceIDs that have been successfully
        /// associated with the UserID. Returned if the AssociateFaces action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AssociatedFace> AssociatedFaces { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedFace>() : null;

        /// <summary>
        /// Checks to see if the AssociatedFaces property is set.
        /// </summary>
        internal bool IsSetAssociatedFaces() => this.AssociatedFaces != null && (this.AssociatedFaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnsuccessfulFaceAssociations. 
        /// <para>
        /// An array of UnsuccessfulAssociation objects containing FaceIDs that are not successfully
        /// associated along with the reasons. Returned if the AssociateFaces action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public List<UnsuccessfulFaceAssociation> UnsuccessfulFaceAssociations { get; set; } = AWSConfigs.InitializeCollections ? new List<UnsuccessfulFaceAssociation>() : null;

        /// <summary>
        /// Checks to see if the UnsuccessfulFaceAssociations property is set.
        /// </summary>
        internal bool IsSetUnsuccessfulFaceAssociations() => this.UnsuccessfulFaceAssociations != null && (this.UnsuccessfulFaceAssociations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The status of an update made to a UserID. Reflects if the UserID has been updated
        /// for every requested change.
        /// </para>
        /// </summary>
        public UserStatus UserStatus { get; set; }

        /// <summary>
        /// Checks to see if the UserStatus property is set.
        /// </summary>
        internal bool IsSetUserStatus() => this.UserStatus != null;
    }
}
