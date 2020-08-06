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

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  DeleteObjectTagging response and response metadata.
    /// </summary>
    public class DeleteObjectTaggingResponse : AmazonWebServiceResponse
    {
        private string versionId;

        /// <summary>
        /// Returns the version ID of the delete marker created as a result of the DELETE operation.
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        /// <summary>
        /// Check to see if VersionId property is set
        /// </summary>
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this.versionId);
        }
    }
}