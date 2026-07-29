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
    /// Container for the parameters to the CreateAttachedFile operation.
    /// Creates an attached file for a completed voice contact by copying a recording from
    /// a source S3 URI into Connect Customer managed storage. Use this API to attach voice
    /// recordings to contacts for downstream processing such as conversational analytics.
    /// 
    ///  <important> 
    /// <para>
    /// The <c>AssociatedResourceArn</c> must be the ARN of a completed voice contact, <c>FileUseCaseType</c>
    /// must be set to <c>VOICE_RECORDING</c>, and <c>FileSourceUri</c> must be a valid S3
    /// URI.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// For example, you can call <c>CreateContact</c>, then <c>CreateAttachedFile</c>, then
    /// <c>StartContactConversationalAnalyticsJob</c> to create a contact, attach a recording,
    /// and run post-call analytics.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateAttachedFileRequest : AmazonConnectRequest
    {
        private string _associatedResourceArn;
        private string _clientToken;
        private string _fileSourceUri;
        private FileUseCaseType _fileUseCaseType;
        private string _instanceId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The ARN of the completed voice contact to attach the file to. Only voice contacts
        /// with Telephony subtype are supported.
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
        /// Gets and sets the property FileSourceUri. 
        /// <para>
        /// The S3 URI of the file to be attached. Only S3 source URIs are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string FileSourceUri
        {
            get { return this._fileSourceUri; }
            set { this._fileSourceUri = value; }
        }

        // Check to see if FileSourceUri property is set
        internal bool IsSetFileSourceUri()
        {
            return this._fileSourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property FileUseCaseType. 
        /// <para>
        /// The use case for the file.
        /// </para>
        ///  <important> 
        /// <para>
        /// Only <c>VOICE_RECORDING</c> is supported.
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
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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

    }
}