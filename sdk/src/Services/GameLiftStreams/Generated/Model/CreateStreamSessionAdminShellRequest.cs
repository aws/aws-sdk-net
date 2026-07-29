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
    /// Container for the parameters to the CreateStreamSessionAdminShell operation.
    /// Creates an administrative terminal session with full access to the live runtime environment
    /// of the Amazon GameLift Streams stream session. Use the returned credentials (<c>SessionId</c>,
    /// <c>StreamUrl</c> and <c>TokenValue</c>) with the Amazon Web Services Systems Manager
    /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/session-manager-working-with-install-plugin.html">Session
    /// Manager plugin</a> for the CLI to access the terminal session.
    /// 
    ///  
    /// <para>
    /// The stream session must be in one of the following statuses: <c>ACTIVE</c>, <c>CONNECTED</c>,
    /// <c>PENDING_CLIENT_RECONNECTION</c>, or <c>RECONNECTING</c>.
    /// </para>
    ///  
    /// <para>
    /// The <c>StreamUrl</c> is valid for 60 seconds. After it expires, call this operation
    /// again to get a new URL.
    /// </para>
    ///  <important> 
    /// <para>
    /// The returned credentials grant full access to the live runtime environment of the
    /// Amazon GameLift Streams stream session. The operator who connects to the terminal
    /// session has the same level of access that your Amazon GameLift Streams applications
    /// have, including potentially user input, screen images, and application data files.
    /// Grant permissions to call this operation only to trusted IAM identities that require
    /// live runtime environment access.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateStreamSessionAdminShellRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;
        private string _streamSessionIdentifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The stream group that runs this stream session.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
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