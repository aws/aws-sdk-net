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
    /// An object that defines the list of matching rules to run in an ID mapping workflow.
    /// </summary>
    public partial class IdMappingRuleBasedProperties
    {
        private AttributeMatchingModel _attributeMatchingModel;
        private RecordMatchingModel _recordMatchingModel;
        private IdMappingWorkflowRuleDefinitionType _ruleDefinitionType;
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
        /// A matches the value of the <c>BusinessEmail</c> field of Profile B, the two profiles
        /// are matched on the <c>Email</c> attribute type. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RecordMatchingModel. 
        /// <para>
        ///  The type of matching record that is allowed to be used in an ID mapping workflow.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>ONE_SOURCE_TO_ONE_TARGET</c>, only one record in the source
        /// can be matched to the same record in the target.
        /// </para>
        ///  
        /// <para>
        /// If the value is set to <c>MANY_SOURCE_TO_ONE_TARGET</c>, multiple records in the source
        /// can be matched to one record in the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecordMatchingModel RecordMatchingModel
        {
            get { return this._recordMatchingModel; }
            set { this._recordMatchingModel = value; }
        }

        // Check to see if RecordMatchingModel property is set
        internal bool IsSetRecordMatchingModel()
        {
            return this._recordMatchingModel != null;
        }

        /// <summary>
        /// Gets and sets the property RuleDefinitionType. 
        /// <para>
        ///  The set of rules you can use in an ID mapping workflow. The limitations specified
        /// for the source or target to define the match rules must be compatible.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdMappingWorkflowRuleDefinitionType RuleDefinitionType
        {
            get { return this._ruleDefinitionType; }
            set { this._ruleDefinitionType = value; }
        }

        // Check to see if RuleDefinitionType property is set
        internal bool IsSetRuleDefinitionType()
        {
            return this._ruleDefinitionType != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  The rules that can be used for ID mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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