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
    /// This is the response object from the DeleteFaces operation.
    /// </summary>
    public partial class DeleteFacesResponse : AmazonWebServiceResponse
    {
        private List<string> _deletedFaces = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<UnsuccessfulFaceDeletion> _unsuccessfulFaceDeletions = AWSConfigs.InitializeCollections ? new List<UnsuccessfulFaceDeletion>() : null;

        /// <summary>
        /// Gets and sets the property DeletedFaces. 
        /// <para>
        /// An array of strings (face IDs) of the faces that were deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public List<string> DeletedFaces
        {
            get { return this._deletedFaces; }
            set { this._deletedFaces = value; }
        }

        // Check to see if DeletedFaces property is set
        internal bool IsSetDeletedFaces()
        {
            return this._deletedFaces != null && (this._deletedFaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulFaceDeletions. 
        /// <para>
        /// An array of any faces that weren't deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public List<UnsuccessfulFaceDeletion> UnsuccessfulFaceDeletions
        {
            get { return this._unsuccessfulFaceDeletions; }
            set { this._unsuccessfulFaceDeletions = value; }
        }

        // Check to see if UnsuccessfulFaceDeletions property is set
        internal bool IsSetUnsuccessfulFaceDeletions()
        {
            return this._unsuccessfulFaceDeletions != null && (this._unsuccessfulFaceDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}