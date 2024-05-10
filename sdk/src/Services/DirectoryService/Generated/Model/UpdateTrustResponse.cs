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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// This is the response object from the UpdateTrust operation.
    /// </summary>
    public partial class UpdateTrustResponse : AmazonWebServiceResponse
    {
        private string _requestId;
        private string _trustId;

        /// <summary>
        /// Gets and sets the property RequestId.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// Identifier of the trust relationship.
        /// </para>
        /// </summary>
        public string TrustId
        {
            get { return this._trustId; }
            set { this._trustId = value; }
        }

        // Check to see if TrustId property is set
        internal bool IsSetTrustId()
        {
            return this._trustId != null;
        }

    }
}