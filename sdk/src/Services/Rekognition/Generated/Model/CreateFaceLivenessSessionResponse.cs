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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the CreateFaceLivenessSession operation.
    /// </summary>
    public partial class CreateFaceLivenessSessionResponse : AmazonWebServiceResponse
    {
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique 128-bit UUID identifying a Face Liveness session. A new sessionID must be
        /// used for every Face Liveness check. If a given sessionID is used for subsequent Face
        /// Liveness checks, the checks will fail. Additionally, a SessionId expires 3 minutes
        /// after it's sent, making all Liveness data associated with the session (e.g., sessionID,
        /// reference image, audit images, etc.) unavailable. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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

    }
}