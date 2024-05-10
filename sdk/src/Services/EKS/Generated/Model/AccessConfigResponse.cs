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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The access configuration for the cluster.
    /// </summary>
    public partial class AccessConfigResponse
    {
        private AuthenticationMode _authenticationMode;
        private bool? _bootstrapClusterCreatorAdminPermissions;

        /// <summary>
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        /// The current authentication mode of the cluster.
        /// </para>
        /// </summary>
        public AuthenticationMode AuthenticationMode
        {
            get { return this._authenticationMode; }
            set { this._authenticationMode = value; }
        }

        // Check to see if AuthenticationMode property is set
        internal bool IsSetAuthenticationMode()
        {
            return this._authenticationMode != null;
        }

        /// <summary>
        /// Gets and sets the property BootstrapClusterCreatorAdminPermissions. 
        /// <para>
        /// Specifies whether or not the cluster creator IAM principal was set as a cluster admin
        /// access entry during cluster creation time.
        /// </para>
        /// </summary>
        public bool? BootstrapClusterCreatorAdminPermissions
        {
            get { return this._bootstrapClusterCreatorAdminPermissions; }
            set { this._bootstrapClusterCreatorAdminPermissions = value; }
        }

        // Check to see if BootstrapClusterCreatorAdminPermissions property is set
        internal bool IsSetBootstrapClusterCreatorAdminPermissions()
        {
            return this._bootstrapClusterCreatorAdminPermissions.HasValue; 
        }

    }
}