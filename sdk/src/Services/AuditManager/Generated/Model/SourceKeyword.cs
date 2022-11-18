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
    /// The keyword to search for in CloudTrail logs, Config rules, Security Hub checks,
    /// and Amazon Web Services API names. 
    /// 
    ///  
    /// <para>
    ///  To learn more about the supported keywords that you can use when mapping a control
    /// data source, see the following pages in the <i>Audit Manager User Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-ash.html">Config
    /// rules supported by Audit Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-config.html">Security
    /// Hub controls supported by Audit Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-api.html">API
    /// calls supported by Audit Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-cloudtrail.html">CloudTrail
    /// event names supported by Audit Manager</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SourceKeyword
    {
        private KeywordInputType _keywordInputType;
        private string _keywordValue;

        /// <summary>
        /// Gets and sets the property KeywordInputType. 
        /// <para>
        ///  The input method for the keyword. 
        /// </para>
        /// </summary>
        public KeywordInputType KeywordInputType
        {
            get { return this._keywordInputType; }
            set { this._keywordInputType = value; }
        }

        // Check to see if KeywordInputType property is set
        internal bool IsSetKeywordInputType()
        {
            return this._keywordInputType != null;
        }

        /// <summary>
        /// Gets and sets the property KeywordValue. 
        /// <para>
        ///  The value of the keyword that's used when mapping a control data source. For example,
        /// this can be a CloudTrail event name, a rule name for Config, a Security Hub control,
        /// or the name of an Amazon Web Services API call. 
        /// </para>
        ///  
        /// <para>
        /// If you’re mapping a data source to a rule in Config, the <code>keywordValue</code>
        /// that you specify depends on the type of rule:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">managed
        /// rules</a>, you can use the rule identifier as the <code>keywordValue</code>. You can
        /// find the rule identifier from the <a href="https://docs.aws.amazon.com/config/latest/developerguide/managed-rules-by-aws-config.html">list
        /// of Config managed rules</a>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Managed rule name: <a href="https://docs.aws.amazon.com/config/latest/developerguide/s3-bucket-acl-prohibited.html">s3-bucket-acl-prohibited</a>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>keywordValue</code>: <code>S3_BUCKET_ACL_PROHIBITED</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_develop-rules.html">custom
        /// rules</a>, you form the <code>keywordValue</code> by adding the <code>Custom_</code>
        /// prefix to the rule name. This prefix distinguishes the rule from a managed rule.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Custom rule name: my-custom-config-rule
        /// </para>
        ///  
        /// <para>
        ///  <code>keywordValue</code>: <code>Custom_my-custom-config-rule</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/service-linked-awsconfig-rules.html">service-linked
        /// rules</a>, you form the <code>keywordValue</code> by adding the <code>Custom_</code>
        /// prefix to the rule name. In addition, you remove the suffix ID that appears at the
        /// end of the rule name.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service-linked rule name: CustomRuleForAccount-conformance-pack-szsm1uv0w
        /// </para>
        ///  
        /// <para>
        ///  <code>keywordValue</code>: <code>Custom_CustomRuleForAccount-conformance-pack</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service-linked rule name: OrgConfigRule-s3-bucket-versioning-enabled-dbgzf8ba
        /// </para>
        ///  
        /// <para>
        ///  <code>keywordValue</code>: <code>Custom_OrgConfigRule-s3-bucket-versioning-enabled</code>
        /// 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string KeywordValue
        {
            get { return this._keywordValue; }
            set { this._keywordValue = value; }
        }

        // Check to see if KeywordValue property is set
        internal bool IsSetKeywordValue()
        {
            return this._keywordValue != null;
        }

    }
}