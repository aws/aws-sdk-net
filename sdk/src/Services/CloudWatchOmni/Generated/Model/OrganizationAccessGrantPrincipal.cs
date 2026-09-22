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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The principal receiving an organization-level domain access grant. Specify principalId,
    /// principalAttributes, or both.
    /// </summary>
    public partial class OrganizationAccessGrantPrincipal
    {
        private List<AccessGrantPrincipalAttribute> _principalAttributes = AWSConfigs.InitializeCollections ? new List<AccessGrantPrincipalAttribute>() : null;
        private string _principalId;
        private OrganizationGrantPrincipalType _principalType;

        /// <summary>
        /// Gets and sets the property PrincipalAttributes. 
        /// <para>
        /// Attribute conditions for attribute-based access. When provided, the grant targets
        /// any principal matching all specified conditions. Supported only for IDC_USER principals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<AccessGrantPrincipalAttribute> PrincipalAttributes
        {
            get { return this._principalAttributes; }
            set { this._principalAttributes = value; }
        }

        // Check to see if PrincipalAttributes property is set
        internal bool IsSetPrincipalAttributes()
        {
            return this._principalAttributes != null && (this._principalAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The ID of the principal receiving the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PrincipalId
        {
            get { return this._principalId; }
            set { this._principalId = value; }
        }

        // Check to see if PrincipalId property is set
        internal bool IsSetPrincipalId()
        {
            return this._principalId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of principal receiving the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationGrantPrincipalType PrincipalType
        {
            get { return this._principalType; }
            set { this._principalType = value; }
        }

        // Check to see if PrincipalType property is set
        internal bool IsSetPrincipalType()
        {
            return this._principalType != null;
        }

    }
}