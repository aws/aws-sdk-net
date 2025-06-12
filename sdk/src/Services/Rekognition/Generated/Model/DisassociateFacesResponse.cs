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
    /// This is the response object from the DisassociateFaces operation.
    /// </summary>
    public partial class DisassociateFacesResponse : AmazonWebServiceResponse
    {
        private List<DisassociatedFace> _disassociatedFaces = AWSConfigs.InitializeCollections ? new List<DisassociatedFace>() : null;
        private List<UnsuccessfulFaceDisassociation> _unsuccessfulFaceDisassociations = AWSConfigs.InitializeCollections ? new List<UnsuccessfulFaceDisassociation>() : null;
        private UserStatus _userStatus;

        /// <summary>
        /// Gets and sets the property DisassociatedFaces. 
        /// <para>
        /// An array of DissociatedFace objects containing FaceIds that are successfully disassociated
        /// with the UserID is returned. Returned if the DisassociatedFaces action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<DisassociatedFace> DisassociatedFaces
        {
            get { return this._disassociatedFaces; }
            set { this._disassociatedFaces = value; }
        }

        // Check to see if DisassociatedFaces property is set
        internal bool IsSetDisassociatedFaces()
        {
            return this._disassociatedFaces != null && (this._disassociatedFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFaceDisassociations. 
        /// <para>
        /// An array of UnsuccessfulDisassociation objects containing FaceIds that are not successfully
        /// associated, along with the reasons for the failure to associate. Returned if the DisassociateFaces
        /// action is successful.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<UnsuccessfulFaceDisassociation> UnsuccessfulFaceDisassociations
        {
            get { return this._unsuccessfulFaceDisassociations; }
            set { this._unsuccessfulFaceDisassociations = value; }
        }

        // Check to see if UnsuccessfulFaceDisassociations property is set
        internal bool IsSetUnsuccessfulFaceDisassociations()
        {
            return this._unsuccessfulFaceDisassociations != null && (this._unsuccessfulFaceDisassociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The status of an update made to a User. Reflects if the User has been updated for
        /// every requested change.
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