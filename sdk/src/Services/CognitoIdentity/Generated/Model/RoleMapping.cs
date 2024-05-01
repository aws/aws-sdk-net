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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
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
namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// A role mapping.
    /// </summary>
    public partial class RoleMapping
    {
        private AmbiguousRoleResolutionType _ambiguousRoleResolution;
        private RulesConfigurationType _rulesConfiguration;
        private RoleMappingType _type;

        /// <summary>
        /// Gets and sets the property AmbiguousRoleResolution. 
        /// <para>
        /// If you specify Token or Rules as the <c>Type</c>, <c>AmbiguousRoleResolution</c> is
        /// required.
        /// </para>
        ///  
        /// <para>
        /// Specifies the action to be taken if either no rules match the claim value for the
        /// <c>Rules</c> type, or there is no <c>cognito:preferred_role</c> claim and there are
        /// multiple <c>cognito:roles</c> matches for the <c>Token</c> type.
        /// </para>
        /// </summary>
        public AmbiguousRoleResolutionType AmbiguousRoleResolution
        {
            get { return this._ambiguousRoleResolution; }
            set { this._ambiguousRoleResolution = value; }
        }

        // Check to see if AmbiguousRoleResolution property is set
        internal bool IsSetAmbiguousRoleResolution()
        {
            return this._ambiguousRoleResolution != null;
        }

        /// <summary>
        /// Gets and sets the property RulesConfiguration. 
        /// <para>
        /// The rules to be used for mapping users to roles.
        /// </para>
        ///  
        /// <para>
        /// If you specify Rules as the role mapping type, <c>RulesConfiguration</c> is required.
        /// </para>
        /// </summary>
        public RulesConfigurationType RulesConfiguration
        {
            get { return this._rulesConfiguration; }
            set { this._rulesConfiguration = value; }
        }

        // Check to see if RulesConfiguration property is set
        internal bool IsSetRulesConfiguration()
        {
            return this._rulesConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The role mapping type. Token will use <c>cognito:roles</c> and <c>cognito:preferred_role</c>
        /// claims from the Cognito identity provider token to map groups to roles. Rules will
        /// attempt to match claims from the token to map to a role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RoleMappingType Type
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