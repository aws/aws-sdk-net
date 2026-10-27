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
    /// Container for the parameters to the CreatePresignedUrl operation. Creates a presigned
    /// URL for an S3 POST operation to upload a file. You can use this URL to set a default
    /// file for a <c>FileUploadCard</c> in a Q App definition or to provide a file for a
    /// single Q App run. The <c>scope</c> parameter determines how the file will be used,
    /// either at the app definition level or the app session level. <note> <para> The IAM
    /// permissions are derived from the <c>qapps:ImportDocument</c> action. For more information
    /// on the IAM policy for Amazon Q Apps, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/deploy-q-apps-iam-permissions.html">IAM
    /// permissions for using Amazon Q Apps</a>. </para> </note>
    /// </summary>
    public partial class CreatePresignedUrlRequest : AmazonQAppsRequest
    {
        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        /// The unique identifier of the Q App the file is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppId { get; set; }

        /// <summary>
        /// Checks to see if the AppId property is set.
        /// </summary>
        internal bool IsSetAppId() => this.AppId != null;

        /// <summary>
        /// Gets and sets the property CardId. 
        /// <para>
        /// The unique identifier of the card the file is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CardId { get; set; }

        /// <summary>
        /// Checks to see if the CardId property is set.
        /// </summary>
        internal bool IsSetCardId() => this.CardId != null;

        /// <summary>
        /// Gets and sets the property FileContentsSha256. 
        /// <para>
        /// The Base64-encoded SHA-256 digest of the contents of the file to be uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileContentsSha256 { get; set; }

        /// <summary>
        /// Checks to see if the FileContentsSha256 property is set.
        /// </summary>
        internal bool IsSetFileContentsSha256() => this.FileContentsSha256 != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file to be uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application environment instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Whether the file is associated with a Q App definition or a specific Q App session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the Q App session the file is associated with, if applicable.
        /// </para>
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
