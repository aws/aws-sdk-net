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
    /// This is the response object from the AssociateFaces operation.
    /// </summary>
    public partial class AssociateFacesResponse : AmazonWebServiceResponse
    {
        private List<AssociatedFace> _associatedFaces = AWSConfigs.InitializeCollections ? new List<AssociatedFace>() : null;
        private List<UnsuccessfulFaceAssociation> _unsuccessfulFaceAssociations = AWSConfigs.InitializeCollections ? new List<UnsuccessfulFaceAssociation>() : null;
        private UserStatus _userStatus;

        /// <summary>
        /// Gets and sets the property AssociatedFaces. 
        /// <para>
        /// An array of AssociatedFace objects containing FaceIDs that have been successfully
        /// associated with the UserID. Returned if the AssociateFaces action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AssociatedFace> AssociatedFaces
        {
            get { return this._associatedFaces; }
            set { this._associatedFaces = value; }
        }

        // Check to see if AssociatedFaces property is set
        internal bool IsSetAssociatedFaces()
        {
            return this._associatedFaces != null && (this._associatedFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFaceAssociations. 
        /// <para>
        /// An array of UnsuccessfulAssociation objects containing FaceIDs that are not successfully
        /// associated along with the reasons. Returned if the AssociateFaces action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<UnsuccessfulFaceAssociation> UnsuccessfulFaceAssociations
        {
            get { return this._unsuccessfulFaceAssociations; }
            set { this._unsuccessfulFaceAssociations = value; }
        }

        // Check to see if UnsuccessfulFaceAssociations property is set
        internal bool IsSetUnsuccessfulFaceAssociations()
        {
            return this._unsuccessfulFaceAssociations != null && (this._unsuccessfulFaceAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The status of an update made to a UserID. Reflects if the UserID has been updated
        /// for every requested change.
        /// </para>
        /// </summary>
        public UserStatus UserStatus
        {
            get { return this._userStatus; }
            set { this._userStatus = value; }
        }

        // Check to see if UserStatus property is set
        internal bool IsSetUserStatus()
        {
            return this._userStatus != null;
        }

    }
}