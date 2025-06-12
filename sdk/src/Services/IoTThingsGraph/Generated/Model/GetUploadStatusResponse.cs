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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
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
        private DateTime? _createdDate;
        private List<string> _failureReason = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _namespaceArn;
        private string _namespaceName;
        private long? _namespaceVersion;
        private string _uploadId;
        private UploadStatus _uploadStatus;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date at which the upload was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for an upload failure.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null && (this._failureReason.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamespaceArn. 
        /// <para>
        /// The ARN of the upload.
        /// </para>
        /// </summary>
        public string NamespaceArn
        {
            get { return this._namespaceArn; }
            set { this._namespaceArn = value; }
        }

        // Check to see if NamespaceArn property is set
        internal bool IsSetNamespaceArn()
        {
            return this._namespaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the upload's namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceVersion. 
        /// <para>
        /// The version of the user's namespace. Defaults to the latest version of the user's
        /// namespace.
        /// </para>
        /// </summary>
        public long? NamespaceVersion
        {
            get { return this._namespaceVersion; }
            set { this._namespaceVersion = value; }
        }

        // Check to see if NamespaceVersion property is set
        internal bool IsSetNamespaceVersion()
        {
            return this._namespaceVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The ID of the upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

        /// <summary>
        /// Gets and sets the property UploadStatus. 
        /// <para>
        /// The status of the upload. The initial status is <c>IN_PROGRESS</c>. The response show
        /// all validation failures if the upload fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UploadStatus UploadStatus
        {
            get { return this._uploadStatus; }
            set { this._uploadStatus = value; }
        }

        // Check to see if UploadStatus property is set
        internal bool IsSetUploadStatus()
        {
            return this._uploadStatus != null;
        }

    }
}