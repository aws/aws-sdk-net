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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the CreatePresignedUrl operation.
    /// </summary>
    public partial class CreatePresignedUrlResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier assigned to the file to be uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileId { get; set; }

        /// <summary>
        /// Checks to see if the FileId property is set.
        /// </summary>
        internal bool IsSetFileId() => this.FileId != null;

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// The URL for a presigned S3 POST operation used to upload a file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PresignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrl property is set.
        /// </summary>
        internal bool IsSetPresignedUrl() => this.PresignedUrl != null;

        /// <summary>
        /// Gets and sets the property PresignedUrlExpiration. 
        /// <para>
        /// The date and time that the presigned URL will expire in ISO 8601 format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? PresignedUrlExpiration { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrlExpiration property is set.
        /// </summary>
        internal bool IsSetPresignedUrlExpiration() => this.PresignedUrlExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property PresignedUrlFields. 
        /// <para>
        /// The form fields to include in the presigned S3 POST operation used to upload a file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, string> PresignedUrlFields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PresignedUrlFields property is set.
        /// </summary>
        internal bool IsSetPresignedUrlFields() => this.PresignedUrlFields != null && (this.PresignedUrlFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
