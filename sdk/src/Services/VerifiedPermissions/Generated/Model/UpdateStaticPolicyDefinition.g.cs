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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about an update to a static policy.
    /// </summary>
    public partial class UpdateStaticPolicyDefinition
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies the description to be added to or replaced on the static policy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 150)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// Specifies the Cedar policy language text to be added to or replaced on the static
        /// policy.
        /// </para>
        ///  <important> 
        /// <para>
        /// You can change only the following elements from the original content:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>action</c> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any conditional clauses, such as <c>when</c> or <c>unless</c> clauses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You <b>can't</b> change the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changing from <c>StaticPolicy</c> to <c>TemplateLinkedPolicy</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The effect (<c>permit</c> or <c>forbid</c>) of the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>principal</c> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>resource</c> referenced by the policy.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string Statement { get; set; }

        /// <summary>
        /// Checks to see if the Statement property is set.
        /// </summary>
        internal bool IsSetStatement() => this.Statement != null;
    }
}
