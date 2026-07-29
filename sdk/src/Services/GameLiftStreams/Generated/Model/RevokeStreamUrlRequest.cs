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
    /// Container for the parameters to the RevokeStreamUrl operation.
    /// Revokes a stream URL so that it can no longer start new stream sessions. By default,
    /// stream sessions that are already running continue until they end on their own. To
    /// also end running sessions, set <c>RevocationMode</c> to <c>REVOKE_AND_TERMINATE_SESSIONS</c>.
    /// 
    ///  
    /// <para>
    /// Revoking a stream URL is permanent. The status of the stream URL changes to <c>REVOKED</c>.
    /// </para>
    /// </summary>
    public partial class RevokeStreamUrlRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;
        private RevocationMode _revocationMode;
        private string _streamUrlIdentifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
        /// </para>
        ///  
        /// <para>
        /// This is the stream group that owns the stream URL.
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
        /// Gets and sets the property RevocationMode. 
        /// <para>
        /// Controls what happens to running stream sessions when you revoke the stream URL. If
        /// you do not specify a value, the default is <c>REVOKE_URL</c>. Possible values include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REVOKE_URL</c>: Stops the stream URL from starting new stream sessions. Running
        /// sessions continue until they end.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVOKE_AND_TERMINATE_SESSIONS</c>: Stops new stream sessions and ends any running
        /// stream sessions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RevocationMode RevocationMode
        {
            get { return this._revocationMode; }
            set { this._revocationMode = value; }
        }

        // Check to see if RevocationMode property is set
        internal bool IsSetRevocationMode()
        {
            return this._revocationMode != null;
        }

        /// <summary>
        /// Gets and sets the property StreamUrlIdentifier. 
        /// <para>
        /// The unique identifier of the stream URL to revoke. Specify a stream URL ID or Amazon
        /// Resource Name (ARN). Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamurl/sg-1AB2C3De4/su-1AB2C3De4</c>.
        /// Example ID: <c>su-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StreamUrlIdentifier
        {
            get { return this._streamUrlIdentifier; }
            set { this._streamUrlIdentifier = value; }
        }

        // Check to see if StreamUrlIdentifier property is set
        internal bool IsSetStreamUrlIdentifier()
        {
            return this._streamUrlIdentifier != null;
        }

    }
}