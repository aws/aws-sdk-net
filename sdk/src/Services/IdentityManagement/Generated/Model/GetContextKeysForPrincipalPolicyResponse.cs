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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a>GetContextKeysForPrincipalPolicy</a> or <a>GetContextKeysForCustomPolicy</a>
    /// request.
    /// </summary>
    public partial class GetContextKeysForPrincipalPolicyResponse : AmazonWebServiceResponse
    {
        private List<string> _contextKeyNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ContextKeyNames. 
        /// <para>
        /// The list of context keys that are used in the <code>Condition</code> elements of the
        /// input policies.
        /// </para>
        /// </summary>
        public List<string> ContextKeyNames
        {
            get { return this._contextKeyNames; }
            set { this._contextKeyNames = value; }
        }

        // Check to see if ContextKeyNames property is set
        internal bool IsSetContextKeyNames()
        {
            return this._contextKeyNames != null && this._contextKeyNames.Count > 0; 
        }

    }
}