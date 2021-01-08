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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// This is the response object from the GenerateServiceLastAccessedDetails operation.
    /// </summary>
    public partial class GenerateServiceLastAccessedDetailsResponse : AmazonWebServiceResponse
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The <code>JobId</code> that you can use in the <a>GetServiceLastAccessedDetails</a>
        /// or <a>GetServiceLastAccessedDetailsWithEntities</a> operations. The <code>JobId</code>
        /// returned by <code>GenerateServiceLastAccessedDetail</code> must be used by the same
        /// role within a session, or by the same user when used to call <code>GetServiceLastAccessedDetail</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}