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
    /// Container for the parameters to the GetAttachedFile operation.
    /// Provides a pre-signed URL for download of an approved attached file. This API also
    /// returns metadata about the attached file. It will only return a downloadURL if the
    /// status of the attached file is <c>APPROVED</c>.
    /// </summary>
    public partial class GetAttachedFileRequest : AmazonConnectRequest
    {
        private string _associatedResourceArn;
        private string _fileId;
        private string _instanceId;
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
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the attached file resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FileId
        {
            get { return this._fileId; }
            set { this._fileId = value; }
        }

        // Check to see if FileId property is set
        internal bool IsSetFileId()
        {
            return this._fileId != null;
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
        /// Gets and sets the property UrlExpiryInSeconds. 
        /// <para>
        /// Optional override for the expiry of the pre-signed S3 URL in seconds. The default
        /// value is 300.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=300)]
        public int UrlExpiryInSeconds
        {
            get { return this._urlExpiryInSeconds.GetValueOrDefault(); }
            set { this._urlExpiryInSeconds = value; }
        }

        // Check to see if UrlExpiryInSeconds property is set
        internal bool IsSetUrlExpiryInSeconds()
        {
            return this._urlExpiryInSeconds.HasValue; 
        }

    }
}