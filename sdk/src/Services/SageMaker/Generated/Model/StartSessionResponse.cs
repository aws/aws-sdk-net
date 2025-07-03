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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the StartSession operation.
    /// </summary>
    public partial class StartSessionResponse : AmazonWebServiceResponse
    {
        private string _sessionId;
        private string _streamUrl;
        private string _tokenValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique identifier for the established remote connection session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// A WebSocket URL used to establish a SSH connection between the local IDE and remote
        /// SageMaker space.
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
        /// An encrypted token value containing session and caller information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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