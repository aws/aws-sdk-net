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

namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Provides details about the stream session's exported files.
    /// </summary>
    public partial class ExportFilesMetadata
    {
        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        ///  The S3 bucket URI where Amazon GameLift Streams uploaded the set of compressed exported
        /// files for a stream session. Amazon GameLift Streams generates a ZIP file name based
        /// on the stream session metadata. Alternatively, you can provide a custom file name
        /// with a <c>.zip</c> file extension.
        /// </para>
        ///  
        /// <para>
        ///  Example 1: If you provide an S3 URI called <c>s3://amzn-s3-demo-destination-bucket/MyGame_Session1.zip</c>,
        /// then Amazon GameLift Streams will save the files at that location. 
        /// </para>
        ///  
        /// <para>
        ///  Example 2: If you provide an S3 URI called <c>s3://amzn-s3-demo-destination-bucket/MyGameSessions_ExportedFiles/</c>,
        /// then Amazon GameLift Streams will save the files at <c>s3://amzn-s3-demo-destination-bucket/MyGameSessions_ExportedFiles/YYYYMMDD-HHMMSS-appId-sg-Id-sessionId.zip</c>
        /// or another similar name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OutputUri { get; set; }

        /// <summary>
        /// Checks to see if the OutputUri property is set.
        /// </summary>
        internal bool IsSetOutputUri() => this.OutputUri != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result of the <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_ExportStreamSessionFiles.html">ExportStreamSessionFiles</a>
        /// operation.
        /// </para>
        /// </summary>
        public ExportFilesStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short description of the reason the export is in <c>FAILED</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
