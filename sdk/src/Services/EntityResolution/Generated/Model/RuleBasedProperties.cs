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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object which defines the list of matching rules to run and has a field <code>Rules</code>,
    /// which is a list of rule objects.
    /// </summary>
    public partial class RuleBasedProperties
    {
        private AttributeMatchingModel _attributeMatchingModel;
        private List<Rule> _rules = new List<Rule>();

        /// <summary>
        /// Gets and sets the property AttributeMatchingModel. 
        /// <para>
        /// The comparison type. You can either choose <code>ONE_TO_ONE</code> or <code>MANY_TO_MANY</code>
        /// as the AttributeMatchingModel. When choosing <code>MANY_TO_MANY</code>, the system
        /// can match attributes across the sub-types of an attribute type. For example, if the
        /// value of the <code>Email</code> field of Profile A and the value of <code>BusinessEmail</code>
        /// field of Profile B matches, the two profiles are matched on the <code>Email</code>
        /// type. When choosing <code>ONE_TO_ONE</code> ,the system can only match if the sub-types
        /// are exact matches. For example, only when the value of the <code>Email</code> field
        /// of Profile A and the value of the <code>Email</code> field of Profile B matches, the
        /// two profiles are matched on the <code>Email</code> type.
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// A list of <code>Rule</code> objects, each of which have fields <code>RuleName</code>
        /// and <code>MatchingKeys</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}