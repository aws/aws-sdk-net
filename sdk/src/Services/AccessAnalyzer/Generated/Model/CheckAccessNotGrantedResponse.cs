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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the CheckAccessNotGranted operation.
    /// </summary>
    public partial class CheckAccessNotGrantedResponse : AmazonWebServiceResponse
    {
        private string _message;
        private List<ReasonSummary> _reasons = AWSConfigs.InitializeCollections ? new List<ReasonSummary>() : null;
        private CheckAccessNotGrantedResult _result;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message indicating whether the specified access is allowed.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Reasons. 
        /// <para>
        /// A description of the reasoning of the result.
        /// </para>
        /// </summary>
        public List<ReasonSummary> Reasons
        {
            get { return this._reasons; }
            set { this._reasons = value; }
        }

        // Check to see if Reasons property is set
        internal bool IsSetReasons()
        {
            return this._reasons != null && (this._reasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the check for whether the access is allowed. If the result is <c>PASS</c>,
        /// the specified policy doesn't allow any of the specified permissions in the access
        /// object. If the result is <c>FAIL</c>, the specified policy might allow some or all
        /// of the permissions in the access object.
        /// </para>
        /// </summary>
        public CheckAccessNotGrantedResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

    }
}