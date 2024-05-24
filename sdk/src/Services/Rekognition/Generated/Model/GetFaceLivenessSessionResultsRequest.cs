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
    /// Container for the parameters to the GetFaceLivenessSessionResults operation.
    /// Retrieves the results of a specific Face Liveness session. It requires the <c>sessionId</c>
    /// as input, which was created using <c>CreateFaceLivenessSession</c>. Returns the corresponding
    /// Face Liveness confidence score, a reference image that includes a face bounding box,
    /// and audit images that also contain face bounding boxes. The Face Liveness confidence
    /// score ranges from 0 to 100. 
    /// 
    ///  
    /// <para>
    /// The number of audit images returned by <c>GetFaceLivenessSessionResults</c> is defined
    /// by the <c>AuditImagesLimit</c> paramater when calling <c>CreateFaceLivenessSession</c>.
    /// Reference images are always returned when possible.
    /// </para>
    /// </summary>
    public partial class GetFaceLivenessSessionResultsRequest : AmazonRekognitionRequest
    {
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// A unique 128-bit UUID. This is used to uniquely identify the session and also acts
        /// as an idempotency token for all operations associated with the session.
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