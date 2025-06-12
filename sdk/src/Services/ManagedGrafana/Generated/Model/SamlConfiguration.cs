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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
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
namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure containing information about how this workspace works with SAML.
    /// </summary>
    public partial class SamlConfiguration
    {
        private List<string> _allowedOrganizations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AssertionAttributes _assertionAttributes;
        private IdpMetadata _idpMetadata;
        private int? _loginValidityDuration;
        private RoleValues _roleValues;

        /// <summary>
        /// Gets and sets the property AllowedOrganizations. 
        /// <para>
        /// Lists which organizations defined in the SAML assertion are allowed to use the Amazon
        /// Managed Grafana workspace. If this is empty, all organizations in the assertion attribute
        /// have access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedOrganizations
        {
            get { return this._allowedOrganizations; }
            set { this._allowedOrganizations = value; }
        }

        // Check to see if AllowedOrganizations property is set
        internal bool IsSetAllowedOrganizations()
        {
            return this._allowedOrganizations != null && (this._allowedOrganizations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AssertionAttributes. 
        /// <para>
        /// A structure that defines which attributes in the SAML assertion are to be used to
        /// define information about the users authenticated by that IdP to use the workspace.
        /// </para>
        /// </summary>
        public AssertionAttributes AssertionAttributes
        {
            get { return this._assertionAttributes; }
            set { this._assertionAttributes = value; }
        }

        // Check to see if AssertionAttributes property is set
        internal bool IsSetAssertionAttributes()
        {
            return this._assertionAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property IdpMetadata. 
        /// <para>
        /// A structure containing the identity provider (IdP) metadata used to integrate the
        /// identity provider with this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdpMetadata IdpMetadata
        {
            get { return this._idpMetadata; }
            set { this._idpMetadata = value; }
        }

        // Check to see if IdpMetadata property is set
        internal bool IsSetIdpMetadata()
        {
            return this._idpMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property LoginValidityDuration. 
        /// <para>
        /// How long a sign-on session by a SAML user is valid, before the user has to sign on
        /// again.
        /// </para>
        /// </summary>
        public int? LoginValidityDuration
        {
            get { return this._loginValidityDuration; }
            set { this._loginValidityDuration = value; }
        }

        // Check to see if LoginValidityDuration property is set
        internal bool IsSetLoginValidityDuration()
        {
            return this._loginValidityDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleValues. 
        /// <para>
        /// A structure containing arrays that map group names in the SAML assertion to the Grafana
        /// <c>Admin</c> and <c>Editor</c> roles in the workspace.
        /// </para>
        /// </summary>
        public RoleValues RoleValues
        {
            get { return this._roleValues; }
            set { this._roleValues = value; }
        }

        // Check to see if RoleValues property is set
        internal bool IsSetRoleValues()
        {
            return this._roleValues != null;
        }

    }
}