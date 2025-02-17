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
namespace Amazon.S3.Model
{
    /// <summary>
    /// <p>
    /// The metadata table configuration for a general purpose bucket.
    /// </p>
    /// </summary>
    public class MetadataTableConfigurationResult
    {
        private S3TablesDestinationResult s3TablesDestinationResult;

        /// <summary>
        /// <para>
        /// The destination information for the metadata table configuration. The destination table bucket
        /// must be in the same Region and Amazon Web Services account as the general purpose bucket. The specified metadata
        /// table name must be unique within the <c>aws_s3_metadata</c> namespace in the destination 
        /// table bucket.
        /// </para>
        /// </summary>
        public S3TablesDestinationResult S3TablesDestinationResult
        {
            get { return this.s3TablesDestinationResult; }
            set { this.s3TablesDestinationResult = value; }
        }
    }
}