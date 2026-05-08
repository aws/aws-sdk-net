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
    /// Container for the parameters to the UpdateAttachedFilesConfiguration operation.
    /// Updates the attached files configuration for the specified Amazon Connect instance
    /// and attachment scope.
    /// 
    ///  
    /// <para>
    /// If no instance-specific configuration exists, this operation creates one. Partial
    /// updates are supported—only specified fields are updated, while unspecified fields
    /// retain their current values.
    /// </para>
    /// </summary>
    public partial class UpdateAttachedFilesConfigurationRequest : AmazonConnectRequest
    {
        private AttachmentScope _attachmentScope;
        private ExtensionConfiguration _extensionConfiguration;
        private string _instanceId;
        private long? _maximumSizeLimitInBytes;

        /// <summary>
        /// Gets and sets the property AttachmentScope. 
        /// <para>
        /// The scope of the attachment. Valid values are <c>EMAIL</c>, <c>CHAT</c>, <c>CASE</c>,
        /// and <c>TASK</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AttachmentScope AttachmentScope
        {
            get { return this._attachmentScope; }
            set { this._attachmentScope = value; }
        }

        // Check to see if AttachmentScope property is set
        internal bool IsSetAttachmentScope()
        {
            return this._attachmentScope != null;
        }

        /// <summary>
        /// Gets and sets the property ExtensionConfiguration. 
        /// <para>
        /// The configuration for allowed file extensions.
        /// </para>
        /// </summary>
        public ExtensionConfiguration ExtensionConfiguration
        {
            get { return this._extensionConfiguration; }
            set { this._extensionConfiguration = value; }
        }

        // Check to see if ExtensionConfiguration property is set
        internal bool IsSetExtensionConfiguration()
        {
            return this._extensionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
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
        /// Gets and sets the property MaximumSizeLimitInBytes. 
        /// <para>
        /// The maximum size limit for attached files in bytes. The minimum value is 1 and the
        /// maximum value is 104857600 (100 MB).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=104857600)]
        public long? MaximumSizeLimitInBytes
        {
            get { return this._maximumSizeLimitInBytes; }
            set { this._maximumSizeLimitInBytes = value; }
        }

        // Check to see if MaximumSizeLimitInBytes property is set
        internal bool IsSetMaximumSizeLimitInBytes()
        {
            return this._maximumSizeLimitInBytes.HasValue; 
        }

    }
}