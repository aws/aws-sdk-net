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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// A condition that determines when a gateway rule applies. Conditions can match on principals
    /// or request paths.
    /// </summary>
    public partial class Condition
    {
        private MatchPaths _matchPaths;
        private MatchPrincipals _matchPrincipals;

        /// <summary>
        /// Gets and sets the property MatchPaths. 
        /// <para>
        /// A condition that matches on the request path.
        /// </para>
        /// </summary>
        public MatchPaths MatchPaths
        {
            get { return this._matchPaths; }
            set { this._matchPaths = value; }
        }

        // Check to see if MatchPaths property is set
        internal bool IsSetMatchPaths()
        {
            return this._matchPaths != null;
        }

        /// <summary>
        /// Gets and sets the property MatchPrincipals. 
        /// <para>
        /// A condition that matches on the identity of the caller making the request.
        /// </para>
        /// </summary>
        public MatchPrincipals MatchPrincipals
        {
            get { return this._matchPrincipals; }
            set { this._matchPrincipals = value; }
        }

        // Check to see if MatchPrincipals property is set
        internal bool IsSetMatchPrincipals()
        {
            return this._matchPrincipals != null;
        }

    }
}