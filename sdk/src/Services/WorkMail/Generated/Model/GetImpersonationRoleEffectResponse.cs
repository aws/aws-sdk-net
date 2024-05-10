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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetImpersonationRoleEffect operation.
    /// </summary>
    public partial class GetImpersonationRoleEffectResponse : AmazonWebServiceResponse
    {
        private AccessEffect _effect;
        private List<ImpersonationMatchedRule> _matchedRules = AWSConfigs.InitializeCollections ? new List<ImpersonationMatchedRule>() : null;
        private ImpersonationRoleType _type;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        ///  <code/>Effect of the impersonation role on the target user based on its rules. Available
        /// effects are <c>ALLOW</c> or <c>DENY</c>.
        /// </para>
        /// </summary>
        public AccessEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property MatchedRules. 
        /// <para>
        /// A list of the rules that match the input and produce the configured effect.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<ImpersonationMatchedRule> MatchedRules
        {
            get { return this._matchedRules; }
            set { this._matchedRules = value; }
        }

        // Check to see if MatchedRules property is set
        internal bool IsSetMatchedRules()
        {
            return this._matchedRules != null && (this._matchedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The impersonation role type.
        /// </para>
        /// </summary>
        public ImpersonationRoleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}