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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The rule-based properties of an ID namespace. These properties define how the ID
    /// namespace can be used in an ID mapping workflow.
    /// </summary>
    public partial class NamespaceRuleBasedProperties
    {
        private AttributeMatchingModel _attributeMatchingModel;
        private List<string> _recordMatchingModels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ruleDefinitionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Gets and sets the property AttributeMatchingModel. 
        /// <para>
        /// The comparison type. You can either choose <c>ONE_TO_ONE</c> or <c>MANY_TO_MANY</c>
        /// as the <c>attributeMatchingModel</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>ONE_TO_ONE</c>, the system can only match attributes if the sub-types
        /// are an exact match. For example, for the <c>Email</c> attribute type, the system will
        /// only consider it a match if the value of the <c>Email</c> field of Profile A matches
        /// the value of the <c>Email</c> field of Profile B.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>MANY_TO_MANY</c>, the system can match attributes across the sub-types
        /// of an attribute type. For example, if the value of the <c>Email</c> field of Profile
        /// A matches the value of <c>BusinessEmail</c> field of Profile B, the two profiles are
        /// matched on the <c>Email</c> attribute type. 
        /// </para>
        /// </summary>
        public AttributeMatchingModel AttributeMatchingModel
        {
            get { return this._attributeMatchingModel; }
            set { this._attributeMatchingModel = value; }
        }

        // Check to see if AttributeMatchingModel property is set
        internal bool IsSetAttributeMatchingModel()
        {
            return this._attributeMatchingModel != null;
        }

        /// <summary>
        /// Gets and sets the property RecordMatchingModels. 
        /// <para>
        ///  The type of matching record that is allowed to be used in an ID mapping workflow.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>ONE_SOURCE_TO_ONE_TARGET</c>, only one record in the source
        /// is matched to one record in the target. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>MANY_SOURCE_TO_ONE_TARGET</c>, all matching records in the
        /// source are matched to one record in the target.
        /// </para>
        /// </summary>
        public List<string> RecordMatchingModels
        {
            get { return this._recordMatchingModels; }
            set { this._recordMatchingModels = value; }
        }

        // Check to see if RecordMatchingModels property is set
        internal bool IsSetRecordMatchingModels()
        {
            return this._recordMatchingModels != null && (this._recordMatchingModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleDefinitionTypes. 
        /// <para>
        ///  The sets of rules you can use in an ID mapping workflow. The limitations specified
        /// for the source and target must be compatible.
        /// </para>
        /// </summary>
        public List<string> RuleDefinitionTypes
        {
            get { return this._ruleDefinitionTypes; }
            set { this._ruleDefinitionTypes = value; }
        }

        // Check to see if RuleDefinitionTypes property is set
        internal bool IsSetRuleDefinitionTypes()
        {
            return this._ruleDefinitionTypes != null && (this._ruleDefinitionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  The rules for the ID namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}