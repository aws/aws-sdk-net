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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the CustomPolicyDetails, the rule owner (<c>Amazon Web Services</c> for managed
    /// rules, <c>CUSTOM_POLICY</c> for Custom Policy rules, and <c>CUSTOM_LAMBDA</c> for
    /// Custom Lambda rules), the rule identifier, and the events that cause the evaluation
    /// of your Amazon Web Services resources.
    /// </summary>
    public partial class Source
    {
        private CustomPolicyDetails _customPolicyDetails;
        private Owner _owner;
        private List<SourceDetail> _sourceDetails = AWSConfigs.InitializeCollections ? new List<SourceDetail>() : null;
        private string _sourceIdentifier;

        /// <summary>
        /// Gets and sets the property CustomPolicyDetails. 
        /// <para>
        /// Provides the runtime system, policy definition, and whether debug logging is enabled.
        /// Required when owner is set to <c>CUSTOM_POLICY</c>.
        /// </para>
        /// </summary>
        public CustomPolicyDetails CustomPolicyDetails
        {
            get { return this._customPolicyDetails; }
            set { this._customPolicyDetails = value; }
        }

        // Check to see if CustomPolicyDetails property is set
        internal bool IsSetCustomPolicyDetails()
        {
            return this._customPolicyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Indicates whether Amazon Web Services or the customer owns and manages the Config
        /// rule.
        /// </para>
        ///  
        /// <para>
        /// Config Managed Rules are predefined rules owned by Amazon Web Services. For more information,
        /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">Config
        /// Managed Rules</a> in the <i>Config developer guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Config Custom Rules are rules that you can develop either with Guard (<c>CUSTOM_POLICY</c>)
        /// or Lambda (<c>CUSTOM_LAMBDA</c>). For more information, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_develop-rules.html">Config
        /// Custom Rules </a> in the <i>Config developer guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Owner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property SourceDetails. 
        /// <para>
        /// Provides the source and the message types that cause Config to evaluate your Amazon
        /// Web Services resources against a rule. It also provides the frequency with which you
        /// want Config to run evaluations for the rule if the trigger type is periodic.
        /// </para>
        ///  
        /// <para>
        /// If the owner is set to <c>CUSTOM_POLICY</c>, the only acceptable values for the Config
        /// rule trigger message type are <c>ConfigurationItemChangeNotification</c> and <c>OversizedConfigurationItemChangeNotification</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<SourceDetail> SourceDetails
        {
            get { return this._sourceDetails; }
            set { this._sourceDetails = value; }
        }

        // Check to see if SourceDetails property is set
        internal bool IsSetSourceDetails()
        {
            return this._sourceDetails != null && (this._sourceDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// For Config Managed rules, a predefined identifier from a list. For example, <c>IAM_PASSWORD_POLICY</c>
        /// is a managed rule. To reference a managed rule, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/managed-rules-by-aws-config.html">List
        /// of Config Managed Rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For Config Custom Lambda rules, the identifier is the Amazon Resource Name (ARN) of
        /// the rule's Lambda function, such as <c>arn:aws:lambda:us-east-2:123456789012:function:custom_rule_name</c>.
        /// </para>
        ///  
        /// <para>
        /// For Config Custom Policy rules, this field will be ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

    }
}