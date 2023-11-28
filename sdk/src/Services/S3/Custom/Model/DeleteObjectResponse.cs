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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  DeleteObject response and response metadata.
    /// </summary>
    public class DeleteObjectResponse : AmazonWebServiceResponse
    {
        private string deleteMarker;
        private string versionId;
        private RequestCharged requestCharged;

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Indicates whether the specified object version that was permanently deleted was (true)
        /// or was not (false) a delete marker before deletion. In a simple DELETE, this header
        /// indicates whether (true) or not (false) the current version of the object is a delete
        /// marker.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DeleteMarker
        {
            get { return this.deleteMarker; }
            set { this.deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this.deleteMarker != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Returns the version ID of the delete marker created as a result of the DELETE operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

        /// <summary>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }
    }
}
    
