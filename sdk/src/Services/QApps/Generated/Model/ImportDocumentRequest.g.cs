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
    /// Container for the parameters to the ImportDocument operation. Uploads a file that
    /// can then be used either as a default in a <c>FileUploadCard</c> from Q App definition
    /// or as a file that is used inside a single Q App run. The purpose of the document is
    /// determined by a scope parameter that indicates whether it is at the app definition
    /// level or at the app session level.
    /// </summary>
    public partial class ImportDocumentRequest : AmazonQAppsRequest
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
        /// Gets and sets the property FileContentsBase64. 
        /// <para>
        /// The base64-encoded contents of the file to upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileContentsBase64 { get; set; }

        /// <summary>
        /// Checks to see if the FileContentsBase64 property is set.
        /// </summary>
        internal bool IsSetFileContentsBase64() => this.FileContentsBase64 != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file being uploaded.
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
