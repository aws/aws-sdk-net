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
    /// Configures inspection of the response header. This is part of the <code>ResponseInspection</code>
    /// configuration for <code>AWSManagedRulesATPRuleSet</code>.
    /// </summary>
    public partial class ResponseInspectionHeader
    {
        private List<string> _failureValues = new List<string>();
        private string _name;
        private List<string> _successValues = new List<string>();

        /// <summary>
        /// Gets and sets the property FailureValues. 
        /// <para>
        /// Values in the response header with the specified name that indicate a failed login
        /// attempt. To be counted as a failed login, the value must be an exact match, including
        /// case. Each value must be unique among the success and failure values. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"FailureValues": [ "LoginFailed", "Failed login" ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> FailureValues
        {
            get { return this._failureValues; }
            set { this._failureValues = value; }
        }

        // Check to see if FailureValues property is set
        internal bool IsSetFailureValues()
        {
            return this._failureValues != null && this._failureValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the header to match against. The name must be an exact match, including
        /// case.
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"Name": [ "LoginResult" ]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessValues. 
        /// <para>
        /// Values in the response header with the specified name that indicate a successful login
        /// attempt. To be counted as a successful login, the value must be an exact match, including
        /// case. Each value must be unique among the success and failure values. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <code>"SuccessValues": [ "LoginPassed", "Successful login" ]</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> SuccessValues
        {
            get { return this._successValues; }
            set { this._successValues = value; }
        }

        // Check to see if SuccessValues property is set
        internal bool IsSetSuccessValues()
        {
            return this._successValues != null && this._successValues.Count > 0; 
        }

    }
}