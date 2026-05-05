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
    /// A condition that matches requests based on the caller's identity.
    /// </summary>
    public partial class MatchPrincipals
    {
        private List<MatchPrincipalEntry> _anyOf = AWSConfigs.InitializeCollections ? new List<MatchPrincipalEntry>() : null;

        /// <summary>
        /// Gets and sets the property AnyOf. 
        /// <para>
        /// A list of principal entries. The condition is met if any of the entries match the
        /// caller's identity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<MatchPrincipalEntry> AnyOf
        {
            get { return this._anyOf; }
            set { this._anyOf = value; }
        }

        // Check to see if AnyOf property is set
        internal bool IsSetAnyOf()
        {
            return this._anyOf != null && (this._anyOf.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}