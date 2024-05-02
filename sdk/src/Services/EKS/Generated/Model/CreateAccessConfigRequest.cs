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
    /// The access configuration information for the cluster.
    /// </summary>
    public partial class CreateAccessConfigRequest
    {
        private AuthenticationMode _authenticationMode;
        private bool? _bootstrapClusterCreatorAdminPermissions;

        /// <summary>
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        /// The desired authentication mode for the cluster. If you create a cluster by using
        /// the EKS API, Amazon Web Services SDKs, or CloudFormation, the default is <c>CONFIG_MAP</c>.
        /// If you create the cluster by using the Amazon Web Services Management Console, the
        /// default value is <c>API_AND_CONFIG_MAP</c>.
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
        /// access entry during cluster creation time. The default value is <c>true</c>.
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