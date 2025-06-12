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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
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
namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Metadata about a rule. Rule metadata includes an ID, a name, a list of tags, and a
    /// short and long description. CodeGuru Reviewer uses rules to analyze code. A rule's
    /// recommendation is included in analysis results if code is detected that violates the
    /// rule.
    /// </summary>
    public partial class RuleMetadata
    {
        private string _longDescription;
        private string _ruleId;
        private string _ruleName;
        private List<string> _ruleTags = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _shortDescription;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// A long description of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string LongDescription
        {
            get { return this._longDescription; }
            set { this._longDescription = value; }
        }

        // Check to see if LongDescription property is set
        internal bool IsSetLongDescription()
        {
            return this._longDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The ID of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property RuleTags. 
        /// <para>
        /// Tags that are associated with the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> RuleTags
        {
            get { return this._ruleTags; }
            set { this._ruleTags = value; }
        }

        // Check to see if RuleTags property is set
        internal bool IsSetRuleTags()
        {
            return this._ruleTags != null && (this._ruleTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// A short description of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ShortDescription
        {
            get { return this._shortDescription; }
            set { this._shortDescription = value; }
        }

        // Check to see if ShortDescription property is set
        internal bool IsSetShortDescription()
        {
            return this._shortDescription != null;
        }

    }
}