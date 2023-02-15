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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Configures inspection of the response status code. This is part of the <code>ResponseInspection</code>
    /// configuration for <code>AWSManagedRulesATPRuleSet</code>.
    /// </summary>
    public partial class ResponseInspectionStatusCode
    {
        private List<int> _failureCodes = new List<int>();
        private List<int> _successCodes = new List<int>();

        /// <summary>
        /// Gets and sets the property FailureCodes. 
        /// <para>
        /// Status codes in the response that indicate a failed login attempt. To be counted as
        /// a failed login, the response status code must match one of these. Each code must be
        /// unique among the success and failure status codes. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"FailureCodes": [ 400, 404 ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<int> FailureCodes
        {
            get { return this._failureCodes; }
            set { this._failureCodes = value; }
        }

        // Check to see if FailureCodes property is set
        internal bool IsSetFailureCodes()
        {
            return this._failureCodes != null && this._failureCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessCodes. 
        /// <para>
        /// Status codes in the response that indicate a successful login attempt. To be counted
        /// as a successful login, the response status code must match one of these. Each code
        /// must be unique among the success and failure status codes. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"SuccessCodes": [ 200, 201 ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<int> SuccessCodes
        {
            get { return this._successCodes; }
            set { this._successCodes = value; }
        }

        // Check to see if SuccessCodes property is set
        internal bool IsSetSuccessCodes()
        {
            return this._successCodes != null && this._successCodes.Count > 0; 
        }

    }
}