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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the CancelTraceRetrieval operation.
    /// Cancels an ongoing trace retrieval job initiated by <c>StartTraceRetrieval</c> using
    /// the provided <c>RetrievalToken</c>. A successful cancellation will return an HTTP
    /// 200 response.
    /// </summary>
    public partial class CancelTraceRetrievalRequest : AmazonXRayRequest
    {
        private string _retrievalToken;

        /// <summary>
        /// Gets and sets the property RetrievalToken. 
        /// <para>
        ///  Retrieval token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1020)]
        public string RetrievalToken
        {
            get { return this._retrievalToken; }
            set { this._retrievalToken = value; }
        }

        // Check to see if RetrievalToken property is set
        internal bool IsSetRetrievalToken()
        {
            return this._retrievalToken != null;
        }

    }
}