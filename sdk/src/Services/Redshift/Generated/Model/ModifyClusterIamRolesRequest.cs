/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterIamRoles operation.
    /// Modifies the list of AWS Identity and Access Management (IAM) roles that can be used
    /// by the cluster to access other AWS services.
    /// 
    ///  
    /// <para>
    /// A cluster can have up to 10 IAM roles associated at any time.
    /// </para>
    /// </summary>
    public partial class ModifyClusterIamRolesRequest : AmazonRedshiftRequest
    {
        private List<string> _addIamRoles = new List<string>();
        private string _clusterIdentifier;
        private List<string> _removeIamRoles = new List<string>();

        /// <summary>
        /// Gets and sets the property AddIamRoles. 
        /// <para>
        /// Zero or more IAM roles to associate with the cluster. The roles must be in their Amazon
        /// Resource Name (ARN) format. You can associate up to 10 IAM roles with a single cluster
        /// in a single request.
        /// </para>
        /// </summary>
        public List<string> AddIamRoles
        {
            get { return this._addIamRoles; }
            set { this._addIamRoles = value; }
        }

        // Check to see if AddIamRoles property is set
        internal bool IsSetAddIamRoles()
        {
            return this._addIamRoles != null && this._addIamRoles.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster for which you want to associate or disassociate
        /// IAM roles.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveIamRoles. 
        /// <para>
        /// Zero or more IAM roles in ARN format to disassociate from the cluster. You can disassociate
        /// up to 10 IAM roles from a single cluster in a single request.
        /// </para>
        /// </summary>
        public List<string> RemoveIamRoles
        {
            get { return this._removeIamRoles; }
            set { this._removeIamRoles = value; }
        }

        // Check to see if RemoveIamRoles property is set
        internal bool IsSetRemoveIamRoles()
        {
            return this._removeIamRoles != null && this._removeIamRoles.Count > 0; 
        }

    }
}