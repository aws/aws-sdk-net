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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// A policy that matched during evaluation, referenced by URI. The URI corresponds to
    /// a policy in the top-level policies list.
    /// </summary>
    public partial class MatchedPolicy
    {
        private List<MatchedStatement> _matchedStatements = AWSConfigs.InitializeCollections ? new List<MatchedStatement>() : null;
        private string _uri;

        /// <summary>
        /// Gets and sets the property MatchedStatements. 
        /// <para>
        /// The statements within the policy that matched during the evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MatchedStatement> MatchedStatements
        {
            get { return this._matchedStatements; }
            set { this._matchedStatements = value; }
        }

        // Check to see if MatchedStatements property is set
        internal bool IsSetMatchedStatements()
        {
            return this._matchedStatements != null && (this._matchedStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The URI of the policy. This cross-references an entry in the top-level policies list.
        /// The value depends on the policy type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For managed policies, this is the policy ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For inline policies, this is an opaque identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}