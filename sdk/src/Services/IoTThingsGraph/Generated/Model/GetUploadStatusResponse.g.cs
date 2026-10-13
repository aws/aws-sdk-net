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

namespace Amazon.IoTThingsGraph.Model
{
    /// <summary>
    /// This is the response object from the GetUploadStatus operation.
    /// </summary>
    public partial class GetUploadStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date at which the upload was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for an upload failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReason { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null && (this.FailureReason.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The ARN of the upload.
        /// </para>
        /// </summary>
        public string NamespaceArn { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceArn property is set.
        /// </summary>
        internal bool IsSetNamespaceArn() => this.NamespaceArn != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the upload's namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long? NamespaceVersion { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceVersion property is set.
        /// </summary>
        internal bool IsSetNamespaceVersion() => this.NamespaceVersion.HasValue;

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The ID of the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 40)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;

        /// <summary>
        /// Gets and sets the property UploadStatus. 
        /// <para>
        /// The status of the upload. The initial status is <c>IN_PROGRESS</c>. The response show
        /// all validation failures if the upload fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public UploadStatus UploadStatus { get; set; }

        /// <summary>
        /// Checks to see if the UploadStatus property is set.
        /// </summary>
        internal bool IsSetUploadStatus() => this.UploadStatus != null;
    }
}
