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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about an update to a static policy.
    /// </summary>
    public partial class UpdateStaticPolicyDefinition
    {
        private string _description;
        private string _statement;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies the description to be added to or replaced on the static policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=150)]
        public string Description
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
        /// The <code>action</code> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any conditional clauses, such as <code>when</code> or <code>unless</code> clauses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You <b>can't</b> change the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Changing from <code>StaticPolicy</code> to <code>TemplateLinkedPolicy</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The effect (<code>permit</code> or <code>forbid</code>) of the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>principal</code> referenced by the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>resource</code> referenced by the policy.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}