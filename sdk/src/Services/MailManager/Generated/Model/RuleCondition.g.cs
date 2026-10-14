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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property BooleanExpression. 
        /// <para>
        /// The condition applies to a boolean expression passed in this field.
        /// </para>
        /// </summary>
        public RuleBooleanExpression BooleanExpression { get; set; }

        /// <summary>
        /// Checks to see if the BooleanExpression property is set.
        /// </summary>
        internal bool IsSetBooleanExpression() => this.BooleanExpression != null;

        /// <summary>
        /// Gets and sets the property DmarcExpression. 
        /// <para>
        /// The condition applies to a DMARC policy expression passed in this field.
        /// </para>
        /// </summary>
        public RuleDmarcExpression DmarcExpression { get; set; }

        /// <summary>
        /// Checks to see if the DmarcExpression property is set.
        /// </summary>
        internal bool IsSetDmarcExpression() => this.DmarcExpression != null;

        /// <summary>
        /// Gets and sets the property IpExpression. 
        /// <para>
        /// The condition applies to an IP address expression passed in this field.
        /// </para>
        /// </summary>
        public RuleIpExpression IpExpression { get; set; }

        /// <summary>
        /// Checks to see if the IpExpression property is set.
        /// </summary>
        internal bool IsSetIpExpression() => this.IpExpression != null;

        /// <summary>
        /// Gets and sets the property NumberExpression. 
        /// <para>
        /// The condition applies to a number expression passed in this field.
        /// </para>
        /// </summary>
        public RuleNumberExpression NumberExpression { get; set; }

        /// <summary>
        /// Checks to see if the NumberExpression property is set.
        /// </summary>
        internal bool IsSetNumberExpression() => this.NumberExpression != null;

        /// <summary>
        /// Gets and sets the property StringExpression. 
        /// <para>
        /// The condition applies to a string expression passed in this field.
        /// </para>
        /// </summary>
        public RuleStringExpression StringExpression { get; set; }

        /// <summary>
        /// Checks to see if the StringExpression property is set.
        /// </summary>
        internal bool IsSetStringExpression() => this.StringExpression != null;

        /// <summary>
        /// Gets and sets the property VerdictExpression. 
        /// <para>
        /// The condition applies to a verdict expression passed in this field.
        /// </para>
        /// </summary>
        public RuleVerdictExpression VerdictExpression { get; set; }

        /// <summary>
        /// Checks to see if the VerdictExpression property is set.
        /// </summary>
        internal bool IsSetVerdictExpression() => this.VerdictExpression != null;
    }
}
