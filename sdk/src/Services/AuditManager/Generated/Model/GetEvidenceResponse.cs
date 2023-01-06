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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the GetEvidence operation.
    /// </summary>
    public partial class GetEvidenceResponse : AmazonWebServiceResponse
    {
        private Evidence _evidence;

        /// <summary>
        /// Gets and sets the property Evidence. 
        /// <para>
        ///  The evidence that the <code>GetEvidence</code> API returned. 
        /// </para>
        /// </summary>
        public Evidence Evidence
        {
            get { return this._evidence; }
            set { this._evidence = value; }
        }

        // Check to see if Evidence property is set
        internal bool IsSetEvidence()
        {
            return this._evidence != null;
        }

    }
}