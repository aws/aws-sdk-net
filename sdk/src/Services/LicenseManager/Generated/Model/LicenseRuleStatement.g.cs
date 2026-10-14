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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// License rule statement.
    /// </summary>
    public partial class LicenseRuleStatement
    {
        /// <summary>
        /// Gets and sets the property AndRuleStatement. 
        /// <para>
        /// AND rule statement.
        /// </para>
        /// </summary>
        public AndRuleStatement AndRuleStatement { get; set; }

        /// <summary>
        /// Checks to see if the AndRuleStatement property is set.
        /// </summary>
        internal bool IsSetAndRuleStatement() => this.AndRuleStatement != null;

        /// <summary>
        /// Gets and sets the property MatchingRuleStatement. 
        /// <para>
        /// Matching rule statement.
        /// </para>
        /// </summary>
        public MatchingRuleStatement MatchingRuleStatement { get; set; }

        /// <summary>
        /// Checks to see if the MatchingRuleStatement property is set.
        /// </summary>
        internal bool IsSetMatchingRuleStatement() => this.MatchingRuleStatement != null;

        /// <summary>
        /// Gets and sets the property OrRuleStatement. 
        /// <para>
        /// OR rule statement.
        /// </para>
        /// </summary>
        public OrRuleStatement OrRuleStatement { get; set; }

        /// <summary>
        /// Checks to see if the OrRuleStatement property is set.
        /// </summary>
        internal bool IsSetOrRuleStatement() => this.OrRuleStatement != null;
    }
}
