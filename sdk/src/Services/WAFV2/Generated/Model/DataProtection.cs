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
    /// Specifies the protection behavior for a field type. This is part of the data protection
    /// configuration for a web ACL.
    /// </summary>
    public partial class DataProtection
    {
        private DataProtectionAction _action;
        private bool? _excludeRateBasedDetails;
        private bool? _excludeRuleMatchDetails;
        private FieldToProtect _field;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies how to protect the field. WAF can apply a one-way hash to the field or hard
        /// code a string substitution. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One-way hash example: <c>ade099751dEXAMPLEHASH2ea9f3393f80dd5d3bEXAMPLEHASH966ae0d3cd5a1e</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Substitution example: <c>REDACTED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataProtectionAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeRateBasedDetails. 
        /// <para>
        /// Specifies whether to also exclude any rate-based rule details from the data protection
        /// you have enabled for a given field. If you specify this exception, RateBasedDetails
        /// will show the value of the field. For additional information, see the log field <c>rateBasedRuleList</c>
        /// at <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
        /// fields for web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>FALSE</c> 
        /// </para>
        /// </summary>
        public bool? ExcludeRateBasedDetails
        {
            get { return this._excludeRateBasedDetails; }
            set { this._excludeRateBasedDetails = value; }
        }

        // Check to see if ExcludeRateBasedDetails property is set
        internal bool IsSetExcludeRateBasedDetails()
        {
            return this._excludeRateBasedDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeRuleMatchDetails. 
        /// <para>
        /// Specifies whether to also exclude any rule match details from the data protection
        /// you have enabled for a given field. WAF logs these details for non-terminating matching
        /// rules and for the terminating matching rule. For additional information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/logging-fields.html">Log
        /// fields for web ACL traffic</a> in the <i>WAF Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>FALSE</c> 
        /// </para>
        /// </summary>
        public bool? ExcludeRuleMatchDetails
        {
            get { return this._excludeRuleMatchDetails; }
            set { this._excludeRuleMatchDetails = value; }
        }

        // Check to see if ExcludeRuleMatchDetails property is set
        internal bool IsSetExcludeRuleMatchDetails()
        {
            return this._excludeRuleMatchDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// Specifies the field type and optional keys to apply the protection behavior to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldToProtect Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

    }
}