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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A keyword that relates to the control data source.
    /// 
    ///  
    /// <para>
    /// For manual evidence, this keyword indicates if the manual evidence is a file or text.
    /// </para>
    ///  
    /// <para>
    /// For automated evidence, this keyword identifies a specific CloudTrail event, Config
    /// rule, Security Hub control, or Amazon Web Services API name. 
    /// </para>
    ///  
    /// <para>
    ///  To learn more about the supported keywords that you can use when mapping a control
    /// data source, see the following pages in the <i>Audit Manager User Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-config.html">Config
    /// rules supported by Audit Manager</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-ash.html">Security
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
        ///  <ul> <li> 
        /// <para>
        ///  <c>SELECT_FROM_LIST</c> is used when mapping a data source for automated evidence.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <c>keywordInputType</c> is <c>SELECT_FROM_LIST</c>, a keyword must be selected
        /// to collect automated evidence. For example, this keyword can be a CloudTrail event
        /// name, a rule name for Config, a Security Hub control, or the name of an Amazon Web
        /// Services API call.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>UPLOAD_FILE</c> and <c>INPUT_TEXT</c> are only used when mapping a data source
        /// for manual evidence.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When <c>keywordInputType</c> is <c>UPLOAD_FILE</c>, a file must be uploaded as manual
        /// evidence.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When <c>keywordInputType</c> is <c>INPUT_TEXT</c>, text must be entered as manual
        /// evidence.
        /// </para>
        ///  </li> </ul> </li> </ul>
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
        /// If you’re mapping a data source to a rule in Config, the <c>keywordValue</c> that
        /// you specify depends on the type of rule:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">managed
        /// rules</a>, you can use the rule identifier as the <c>keywordValue</c>. You can find
        /// the rule identifier from the <a href="https://docs.aws.amazon.com/config/latest/developerguide/managed-rules-by-aws-config.html">list
        /// of Config managed rules</a>. For some rules, the rule identifier is different from
        /// the rule name. For example, the rule name <c>restricted-ssh</c> has the following
        /// rule identifier: <c>INCOMING_SSH_DISABLED</c>. Make sure to use the rule identifier,
        /// not the rule name. 
        /// </para>
        ///  
        /// <para>
        /// Keyword example for managed rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Managed rule name: <a href="https://docs.aws.amazon.com/config/latest/developerguide/s3-bucket-acl-prohibited.html">s3-bucket-acl-prohibited</a>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>keywordValue</c>: <c>S3_BUCKET_ACL_PROHIBITED</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_develop-rules.html">custom
        /// rules</a>, you form the <c>keywordValue</c> by adding the <c>Custom_</c> prefix to
        /// the rule name. This prefix distinguishes the custom rule from a managed rule. 
        /// </para>
        ///  
        /// <para>
        /// Keyword example for custom rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Custom rule name: my-custom-config-rule
        /// </para>
        ///  
        /// <para>
        ///  <c>keywordValue</c>: <c>Custom_my-custom-config-rule</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/config/latest/developerguide/service-linked-awsconfig-rules.html">service-linked
        /// rules</a>, you form the <c>keywordValue</c> by adding the <c>Custom_</c> prefix to
        /// the rule name. In addition, you remove the suffix ID that appears at the end of the
        /// rule name. 
        /// </para>
        ///  
        /// <para>
        /// Keyword examples for service-linked rules:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service-linked rule name: CustomRuleForAccount-conformance-pack-szsm1uv0w
        /// </para>
        ///  
        /// <para>
        ///  <c>keywordValue</c>: <c>Custom_CustomRuleForAccount-conformance-pack</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service-linked rule name: OrgConfigRule-s3-bucket-versioning-enabled-dbgzf8ba
        /// </para>
        ///  
        /// <para>
        ///  <c>keywordValue</c>: <c>Custom_OrgConfigRule-s3-bucket-versioning-enabled</c> 
        /// </para>
        ///  </li> </ul> </li> </ul> <important> 
        /// <para>
        /// The <c>keywordValue</c> is case sensitive. If you enter a value incorrectly, Audit
        /// Manager might not recognize the data source mapping. As a result, you might not successfully
        /// collect evidence from that data source as intended. 
        /// </para>
        ///  
        /// <para>
        /// Keep in mind the following requirements, depending on the data source type that you're
        /// using. 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// For Config: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For managed rules, make sure that the <c>keywordValue</c> is the rule identifier in
        /// <c>ALL_CAPS_WITH_UNDERSCORES</c>. For example, <c>CLOUDWATCH_LOG_GROUP_ENCRYPTED</c>.
        /// For accuracy, we recommend that you reference the list of <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-config.html">supported
        /// Config managed rules</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For custom rules, make sure that the <c>keywordValue</c> has the <c>Custom_</c> prefix
        /// followed by the custom rule name. The format of the custom rule name itself may vary.
        /// For accuracy, we recommend that you visit the <a href="https://console.aws.amazon.com/config/">Config
        /// console</a> to verify your custom rule name.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For Security Hub: The format varies for Security Hub control names. For accuracy,
        /// we recommend that you reference the list of <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-ash.html">supported
        /// Security Hub controls</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon Web Services API calls: Make sure that the <c>keywordValue</c> is written
        /// as <c>serviceprefix_ActionName</c>. For example, <c>iam_ListGroups</c>. For accuracy,
        /// we recommend that you reference the list of <a href="https://docs.aws.amazon.com/audit-manager/latest/userguide/control-data-sources-api.html">supported
        /// API calls</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For CloudTrail: Make sure that the <c>keywordValue</c> is written as <c>serviceprefix_ActionName</c>.
        /// For example, <c>cloudtrail_StartLogging</c>. For accuracy, we recommend that you review
        /// the Amazon Web Services service prefix and action names in the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Service
        /// Authorization Reference</a>.
        /// </para>
        ///  </li> </ol> </important>
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