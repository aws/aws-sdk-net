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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The conditional expression used to evaluate an email for determining if a rule action
    /// should be taken.
    /// </summary>
    public partial class RuleCondition
    {
        private RuleBooleanExpression _booleanExpression;
        private RuleDmarcExpression _dmarcExpression;
        private RuleIpExpression _ipExpression;
        private RuleNumberExpression _numberExpression;
        private RuleStringExpression _stringExpression;
        private RuleVerdictExpression _verdictExpression;

        /// <summary>
        /// Gets and sets the property BooleanExpression. 
        /// <para>
        /// The condition applies to a boolean expression passed in this field.
        /// </para>
        /// </summary>
        public RuleBooleanExpression BooleanExpression
        {
            get { return this._booleanExpression; }
            set { this._booleanExpression = value; }
        }

        // Check to see if BooleanExpression property is set
        internal bool IsSetBooleanExpression()
        {
            return this._booleanExpression != null;
        }

        /// <summary>
        /// Gets and sets the property DmarcExpression. 
        /// <para>
        /// The condition applies to a DMARC policy expression passed in this field.
        /// </para>
        /// </summary>
        public RuleDmarcExpression DmarcExpression
        {
            get { return this._dmarcExpression; }
            set { this._dmarcExpression = value; }
        }

        // Check to see if DmarcExpression property is set
        internal bool IsSetDmarcExpression()
        {
            return this._dmarcExpression != null;
        }

        /// <summary>
        /// Gets and sets the property IpExpression. 
        /// <para>
        /// The condition applies to an IP address expression passed in this field.
        /// </para>
        /// </summary>
        public RuleIpExpression IpExpression
        {
            get { return this._ipExpression; }
            set { this._ipExpression = value; }
        }

        // Check to see if IpExpression property is set
        internal bool IsSetIpExpression()
        {
            return this._ipExpression != null;
        }

        /// <summary>
        /// Gets and sets the property NumberExpression. 
        /// <para>
        /// The condition applies to a number expression passed in this field.
        /// </para>
        /// </summary>
        public RuleNumberExpression NumberExpression
        {
            get { return this._numberExpression; }
            set { this._numberExpression = value; }
        }

        // Check to see if NumberExpression property is set
        internal bool IsSetNumberExpression()
        {
            return this._numberExpression != null;
        }

        /// <summary>
        /// Gets and sets the property StringExpression. 
        /// <para>
        /// The condition applies to a string expression passed in this field.
        /// </para>
        /// </summary>
        public RuleStringExpression StringExpression
        {
            get { return this._stringExpression; }
            set { this._stringExpression = value; }
        }

        // Check to see if StringExpression property is set
        internal bool IsSetStringExpression()
        {
            return this._stringExpression != null;
        }

        /// <summary>
        /// Gets and sets the property VerdictExpression. 
        /// <para>
        /// The condition applies to a verdict expression passed in this field.
        /// </para>
        /// </summary>
        public RuleVerdictExpression VerdictExpression
        {
            get { return this._verdictExpression; }
            set { this._verdictExpression = value; }
        }

        // Check to see if VerdictExpression property is set
        internal bool IsSetVerdictExpression()
        {
            return this._verdictExpression != null;
        }

    }
}