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
    /// <para>
    /// The metadata table configuration for the general purpose bucket.
    /// </para>
    /// </summary>
    public class GetBucketMetadataTableConfigurationResult
    {
        private MetadataTableConfigurationResult metadataTableConfigurationResult;
        private string metadataTableStatus;
        private ErrorDetails errorDetails;

        /// <summary>
        /// <para>
        /// The metadata table configuration for a general purpose bucket.
        /// </para>
        /// </summary>
        public MetadataTableConfigurationResult MetadataTableConfigurationResult
        {
            get { return this.metadataTableConfigurationResult; }
            set { this.metadataTableConfigurationResult = value; }
        }

        /// <summary>
        /// <para>
        ///       The status of the metadata table. The status values are:
        ///       </para>
        ///          <ul>
        ///             <li>
        ///                <para>
        ///                   <c>CREATING</c> - The metadata table is in the process of being created in the 
        ///                specified table bucket.</para>
        ///             </li>
        ///             <li>
        ///                <para>
        ///                   <c>ACTIVE</c> - The metadata table has been created successfully and records 
        ///                are being delivered to the table.
        ///             </para>
        ///             </li>
        ///             <li>
        ///                <para>
        ///                   <c>FAILED</c> - Amazon S3 is unable to create the metadata table, or Amazon S3 is unable to deliver 
        ///                records. See <c>ErrorDetails</c> for details.</para>
        ///             </li>
        ///          </ul>
        /// </summary>
        public string Status
        {
            get { return this.metadataTableStatus; }
            set { this.metadataTableStatus = value; }
        }

        /// <summary>
        /// <para>
        /// If the<c> CreateBucketMetadataTableConfiguration</c> request succeeds, but S3 Metadata was 
        /// unable to create the table, this structure contains the error code and error message.
        /// </para>
        /// </summary>
        public ErrorDetails Error
        {
            get { return this.errorDetails; }
            set { this.errorDetails = value; }
        }
    }
}

