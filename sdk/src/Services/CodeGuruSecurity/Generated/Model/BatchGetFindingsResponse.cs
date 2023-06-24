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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// This is the response object from the BatchGetFindings operation.
    /// </summary>
    public partial class BatchGetFindingsResponse : AmazonWebServiceResponse
    {
        private List<BatchGetFindingsError> _failedFindings = new List<BatchGetFindingsError>();
        private List<Finding> _findings = new List<Finding>();

        /// <summary>
        /// Gets and sets the property FailedFindings. 
        /// <para>
        /// A list of errors for individual findings which were not fetched. Each BatchGetFindingsError
        /// contains the <code>scanName</code>, <code>findingId</code>, <code>errorCode</code>
        /// and error <code>message</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchGetFindingsError> FailedFindings
        {
            get { return this._failedFindings; }
            set { this._failedFindings = value; }
        }

        // Check to see if FailedFindings property is set
        internal bool IsSetFailedFindings()
        {
            return this._failedFindings != null && this._failedFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        ///  A list of all requested findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Finding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && this._findings.Count > 0; 
        }

    }
}