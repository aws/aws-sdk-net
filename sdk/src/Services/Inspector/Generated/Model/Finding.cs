/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Contains information about an Inspector finding.
    /// 
    ///  
    /// <para>
    /// This data type is used as the response element in the <a>DescribeFinding</a> action.
    /// </para>
    /// </summary>
    public partial class Finding
    {
        private string _agentId;
        private List<Attribute> _attributes = new List<Attribute>();
        private string _autoScalingGroup;
        private LocalizedText _description;
        private string _findingArn;
        private LocalizedText _recommendation;
        private string _ruleName;
        private string _rulesPackageArn;
        private string _runArn;
        private string _severity;
        private LocalizedText _title;
        private List<Attribute> _userAttributes = new List<Attribute>();

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The EC2 instance ID where the agent is installed that is used during the assessment
        /// that generates the finding. 
        /// </para>
        /// </summary>
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The system-defined attributes for the finding. 
        /// </para>
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroup. 
        /// <para>
        /// The autoscaling group of the EC2 instance where the agent is installed that is used
        /// during the assessment that generates the finding.
        /// </para>
        /// </summary>
        public string AutoScalingGroup
        {
            get { return this._autoScalingGroup; }
            set { this._autoScalingGroup = value; }
        }

        // Check to see if AutoScalingGroup property is set
        internal bool IsSetAutoScalingGroup()
        {
            return this._autoScalingGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        public LocalizedText Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The ARN specifying the finding.
        /// </para>
        /// </summary>
        public string FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommendation for the finding. 
        /// </para>
        /// </summary>
        public LocalizedText Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The rule name that is used to generate the finding.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property RulesPackageArn. 
        /// <para>
        /// The ARN of the rules package that is used to generate the finding.
        /// </para>
        /// </summary>
        public string RulesPackageArn
        {
            get { return this._rulesPackageArn; }
            set { this._rulesPackageArn = value; }
        }

        // Check to see if RulesPackageArn property is set
        internal bool IsSetRulesPackageArn()
        {
            return this._rulesPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property RunArn. 
        /// <para>
        /// The ARN of the assessment run that generated the finding.
        /// </para>
        /// </summary>
        public string RunArn
        {
            get { return this._runArn; }
            set { this._runArn = value; }
        }

        // Check to see if RunArn property is set
        internal bool IsSetRunArn()
        {
            return this._runArn != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The finding severity. Values can be set to <i>High</i>, <i>Medium</i>, <i>Low</i>,
        /// and <i>Informational</i>.
        /// </para>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short description that identifies the finding.
        /// </para>
        /// </summary>
        public LocalizedText Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttributes. 
        /// <para>
        /// The user-defined attributes that are assigned to the finding.
        /// </para>
        /// </summary>
        public List<Attribute> UserAttributes
        {
            get { return this._userAttributes; }
            set { this._userAttributes = value; }
        }

        // Check to see if UserAttributes property is set
        internal bool IsSetUserAttributes()
        {
            return this._userAttributes != null && this._userAttributes.Count > 0; 
        }

    }
}