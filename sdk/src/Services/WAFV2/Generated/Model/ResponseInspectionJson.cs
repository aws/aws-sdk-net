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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Configures inspection of the response JSON. WAF can inspect the first 65,536 bytes
    /// (64 KB) of the response JSON. This is part of the <c>ResponseInspection</c> configuration
    /// for <c>AWSManagedRulesATPRuleSet</c> and <c>AWSManagedRulesACFPRuleSet</c>. 
    /// 
    ///  <note> 
    /// <para>
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResponseInspectionJson
    {
        private List<string> _failureValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;
        private List<string> _successValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FailureValues. 
        /// <para>
        /// Values for the specified identifier in the response JSON that indicate a failed login
        /// or account creation attempt. To be counted as a failure, the value must be an exact
        /// match, including case. Each value must be unique among the success and failure values.
        /// 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <c>"FailureValues": [ "False", "Failed" ]</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> FailureValues
        {
            get { return this._failureValues; }
            set { this._failureValues = value; }
        }

        // Check to see if FailureValues property is set
        internal bool IsSetFailureValues()
        {
            return this._failureValues != null && (this._failureValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier for the value to match against in the JSON. The identifier must be
        /// an exact match, including case.
        /// </para>
        ///  
        /// <para>
        /// JSON examples: <c>"Identifier": [ "/login/success" ]</c> and <c>"Identifier": [ "/sign-up/success"
        /// ]</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessValues. 
        /// <para>
        /// Values for the specified identifier in the response JSON that indicate a successful
        /// login or account creation attempt. To be counted as a success, the value must be an
        /// exact match, including case. Each value must be unique among the success and failure
        /// values. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <c>"SuccessValues": [ "True", "Succeeded" ]</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SuccessValues
        {
            get { return this._successValues; }
            set { this._successValues = value; }
        }

        // Check to see if SuccessValues property is set
        internal bool IsSetSuccessValues()
        {
            return this._successValues != null && (this._successValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}