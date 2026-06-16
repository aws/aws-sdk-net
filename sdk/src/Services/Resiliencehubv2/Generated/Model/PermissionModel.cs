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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Defines the permission model for a service.
    /// </summary>
    public partial class PermissionModel
    {
        private List<CrossAccountRole> _crossAccountRoles = AWSConfigs.InitializeCollections ? new List<CrossAccountRole>() : null;
        private string _invokerRoleName;

        /// <summary>
        /// Gets and sets the property CrossAccountRoles. 
        /// <para>
        /// The list of cross-account IAM role ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<CrossAccountRole> CrossAccountRoles
        {
            get { return this._crossAccountRoles; }
            set { this._crossAccountRoles = value; }
        }

        // Check to see if CrossAccountRoles property is set
        internal bool IsSetCrossAccountRoles()
        {
            return this._crossAccountRoles != null && (this._crossAccountRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InvokerRoleName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InvokerRoleName
        {
            get { return this._invokerRoleName; }
            set { this._invokerRoleName = value; }
        }

        // Check to see if InvokerRoleName property is set
        internal bool IsSetInvokerRoleName()
        {
            return this._invokerRoleName != null;
        }

    }
}