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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
    /// Container for the parameters to the ExportStreamSessionFiles operation.
    /// Export the files that your application modifies or generates in a stream session,
    /// which can help you debug or verify your application. When your application runs, it
    /// generates output files such as logs, diagnostic information, crash dumps, save files,
    /// user data, screenshots, and so on. The files can be defined by the engine or frameworks
    /// that your application uses, or information that you've programmed your application
    /// to output. 
    /// 
    ///  
    /// <para>
    ///  You can only call this action on a stream session that is in progress, specifically
    /// in one of the following statuses <c>ACTIVE</c>, <c>CONNECTED</c>, <c>PENDING_CLIENT_RECONNECTION</c>,
    /// and <c>RECONNECTING</c>. You must provide an Amazon Simple Storage Service (Amazon
    /// S3) bucket to store the files in. When the session ends, Amazon GameLift Streams produces
    /// a compressed folder that contains all of the files and directories that were modified
    /// or created by the application during the stream session. AWS uses your security credentials
    /// to authenticate and authorize access to your Amazon S3 bucket. 
    /// </para>
    ///  
    /// <para>
    /// Amazon GameLift Streams collects the following generated and modified files. Find
    /// them in the corresponding folders in the <c>.zip</c> archive.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>application/</c>: The folder where your application or game is stored. 
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    ///  <c>profile/</c>: The user profile folder.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>temp/</c>: The system temp folder.
    /// </para>
    ///  </li> </ul>  
    /// <para>
    /// To verify the status of the exported files, use GetStreamSession. 
    /// </para>
    ///  
    /// <para>
    /// To delete the files, delete the object in the S3 bucket. 
    /// </para>
    /// </summary>
    public partial class ExportStreamSessionFilesRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;
        private string _outputUri;
        private string _streamSessionIdentifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property OutputUri. 
        /// <para>
        ///  The S3 bucket URI where Amazon GameLift Streams uploads the set of compressed exported
        /// files for this stream session. Amazon GameLift Streams generates a ZIP file name based
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
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string OutputUri
        {
            get { return this._outputUri; }
            set { this._outputUri = value; }
        }

        // Check to see if OutputUri property is set
        internal bool IsSetOutputUri()
        {
            return this._outputUri != null;
        }

        /// <summary>
        /// Gets and sets the property StreamSessionIdentifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream session resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamsession/sg-1AB2C3De4/ABC123def4567</c>.
        /// Example ID: <c>ABC123def4567</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StreamSessionIdentifier
        {
            get { return this._streamSessionIdentifier; }
            set { this._streamSessionIdentifier = value; }
        }

        // Check to see if StreamSessionIdentifier property is set
        internal bool IsSetStreamSessionIdentifier()
        {
            return this._streamSessionIdentifier != null;
        }

    }
}