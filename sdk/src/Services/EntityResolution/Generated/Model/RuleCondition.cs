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
    /// An object that defines the <c>ruleCondition</c> and the <c>ruleName</c> to use in
    /// a matching workflow.
    /// </summary>
    public partial class RuleCondition
    {
        private string _condition;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A statement that specifies the conditions for a matching rule.
        /// </para>
        ///  
        /// <para>
        /// If your data is accurate, use an Exact matching function: <c>Exact</c> or <c>ExactManyToMany</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If your data has variations in spelling or pronunciation, use a Fuzzy matching function:
        /// <c>Cosine</c>, <c>Levenshtein</c>, or <c>Soundex</c>. 
        /// </para>
        ///  
        /// <para>
        /// Use operators if you want to combine (<c>AND</c>), separate (<c>OR</c>), or group
        /// matching functions <c>(...)</c>.
        /// </para>
        ///  
        /// <para>
        /// For example: <c>(Cosine(a, 10) AND Exact(b, true)) OR ExactManyToMany(c, d)</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A name for the matching rule.
        /// </para>
        ///  
        /// <para>
        /// For example: <c>Rule1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
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

    }
}