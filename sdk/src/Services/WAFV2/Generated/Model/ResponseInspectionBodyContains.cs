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
    /// Configures inspection of the response body. WAF can inspect the first 65,536 bytes
    /// (64 KB) of the response body. This is part of the <c>ResponseInspection</c> configuration
    /// for <c>AWSManagedRulesATPRuleSet</c> and <c>AWSManagedRulesACFPRuleSet</c>. 
    /// 
    ///  <note> 
    /// <para>
    /// Response inspection is available only in web ACLs that protect Amazon CloudFront distributions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResponseInspectionBodyContains
    {
        private List<string> _failureStrings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _successStrings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FailureStrings. 
        /// <para>
        /// Strings in the body of the response that indicate a failed login or account creation
        /// attempt. To be counted as a failure, the string can be anywhere in the body and must
        /// be an exact match, including case. Each string must be unique among the success and
        /// failure strings. 
        /// </para>
        ///  
        /// <para>
        /// JSON example: <c>"FailureStrings": [ "Request failed" ]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> FailureStrings
        {
            get { return this._failureStrings; }
            set { this._failureStrings = value; }
        }

        // Check to see if FailureStrings property is set
        internal bool IsSetFailureStrings()
        {
            return this._failureStrings != null && (this._failureStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessStrings. 
        /// <para>
        /// Strings in the body of the response that indicate a successful login or account creation
        /// attempt. To be counted as a success, the string can be anywhere in the body and must
        /// be an exact match, including case. Each string must be unique among the success and
        /// failure strings. 
        /// </para>
        ///  
        /// <para>
        /// JSON examples: <c>"SuccessStrings": [ "Login successful" ]</c> and <c>"SuccessStrings":
        /// [ "Account creation successful", "Welcome to our site!" ]</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> SuccessStrings
        {
            get { return this._successStrings; }
            set { this._successStrings = value; }
        }

        // Check to see if SuccessStrings property is set
        internal bool IsSetSuccessStrings()
        {
            return this._successStrings != null && (this._successStrings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}