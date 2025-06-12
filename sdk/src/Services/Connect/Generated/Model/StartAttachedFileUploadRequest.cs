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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartAttachedFileUpload operation.
    /// Provides a pre-signed Amazon S3 URL in response for uploading your content.
    /// 
    ///  <important> 
    /// <para>
    /// You may only use this API to upload attachments to an <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_connect-cases_CreateCase.html">Amazon
    /// Connect Case</a> or <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-email-channel.html">Amazon
    /// Connect Email</a>. 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class StartAttachedFileUploadRequest : AmazonConnectRequest
    {
        private string _associatedResourceArn;
        private string _clientToken;
        private CreatedByInfo _createdBy;
        private string _fileName;
        private long? _fileSizeInBytes;
        private FileUseCaseType _fileUseCaseType;
        private string _instanceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _urlExpiryInSeconds;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The resource to which the attached file is (being) uploaded to. The supported resources
        /// are <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cases.html">Cases</a>
        /// and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-email-channel.html">Email</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value must be a valid ARN.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociatedResourceArn
        {
            get { return this._associatedResourceArn; }
            set { this._associatedResourceArn = value; }
        }

        // Check to see if AssociatedResourceArn property is set
        internal bool IsSetAssociatedResourceArn()
        {
            return this._associatedResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Represents the identity that created the file.
        /// </para>
        /// </summary>
        public CreatedByInfo CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// A case-sensitive name of the attached file being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property FileSizeInBytes. 
        /// <para>
        /// The size of the attached file in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? FileSizeInBytes
        {
            get { return this._fileSizeInBytes; }
            set { this._fileSizeInBytes = value; }
        }

        // Check to see if FileSizeInBytes property is set
        internal bool IsSetFileSizeInBytes()
        {
            return this._fileSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileUseCaseType. 
        /// <para>
        /// The use case for the file.
        /// </para>
        ///  <important> 
        /// <para>
        ///  Only <c>ATTACHMENTS</c> are supported.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileUseCaseType FileUseCaseType
        {
            get { return this._fileUseCaseType; }
            set { this._fileUseCaseType = value; }
        }

        // Check to see if FileUseCaseType property is set
        internal bool IsSetFileUseCaseType()
        {
            return this._fileUseCaseType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// <c>{ "Tags": {"key1":"value1", "key2":"value2"} }</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UrlExpiryInSeconds. 
        /// <para>
        /// Optional override for the expiry of the pre-signed S3 URL in seconds. The default
        /// value is 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int? UrlExpiryInSeconds
        {
            get { return this._urlExpiryInSeconds; }
            set { this._urlExpiryInSeconds = value; }
        }

        // Check to see if UrlExpiryInSeconds property is set
        internal bool IsSetUrlExpiryInSeconds()
        {
            return this._urlExpiryInSeconds.HasValue; 
        }

    }
}