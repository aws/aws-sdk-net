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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the ResumeSession operation.
    /// </summary>
    public partial class ResumeSessionResponse : AmazonWebServiceResponse
    {
        private string _sessionId;
        private string _streamUrl;
        private string _tokenValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=96)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamUrl. 
        /// <para>
        /// A URL back to SSM Agent on the managed node that the Session Manager client uses to
        /// send commands and receive output from the managed node. Format: <c>wss://ssmmessages.<b>region</b>.amazonaws.com/v1/data-channel/<b>session-id</b>?stream=(input|output)</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>region</b> represents the Region identifier for an Amazon Web Services Region
        /// supported by Amazon Web Services Systems Manager, such as <c>us-east-2</c> for the
        /// US East (Ohio) Region. For a list of supported <b>region</b> values, see the <b>Region</b>
        /// column in <a href="https://docs.aws.amazon.com/general/latest/gr/ssm.html#ssm_region">Systems
        /// Manager service endpoints</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>session-id</b> represents the ID of a Session Manager session, such as <c>1a2b3c4dEXAMPLE</c>.
        /// </para>
        /// </summary>
        public string StreamUrl
        {
            get { return this._streamUrl; }
            set { this._streamUrl = value; }
        }

        // Check to see if StreamUrl property is set
        internal bool IsSetStreamUrl()
        {
            return this._streamUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TokenValue. 
        /// <para>
        /// An encrypted token value containing session and caller information. Used to authenticate
        /// the connection to the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string TokenValue
        {
            get { return this._tokenValue; }
            set { this._tokenValue = value; }
        }

        // Check to see if TokenValue property is set
        internal bool IsSetTokenValue()
        {
            return this._tokenValue != null;
        }

    }
}