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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterIamRoles operation.
    /// Modifies the list of Identity and Access Management (IAM) roles that can be used by
    /// the cluster to access other Amazon Web Services services.
    /// 
    ///  
    /// <para>
    /// The maximum number of IAM roles that you can associate is subject to a quota. For
    /// more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Quotas
    /// and limits</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyClusterIamRolesRequest : AmazonRedshiftRequest
    {
        private List<string> _addIamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _clusterIdentifier;
        private string _defaultIamRoleArn;
        private List<string> _removeIamRoles = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AddIamRoles. 
        /// <para>
        /// Zero or more IAM roles to associate with the cluster. The roles must be in their Amazon
        /// Resource Name (ARN) format. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AddIamRoles
        {
            get { return this._addIamRoles; }
            set { this._addIamRoles = value; }
        }

        // Check to see if AddIamRoles property is set
        internal bool IsSetAddIamRoles()
        {
            return this._addIamRoles != null && (this._addIamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster for which you want to associate or disassociate
        /// IAM roles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property DefaultIamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the IAM role that was set as default for the cluster
        /// when the cluster was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string DefaultIamRoleArn
        {
            get { return this._defaultIamRoleArn; }
            set { this._defaultIamRoleArn = value; }
        }

        // Check to see if DefaultIamRoleArn property is set
        internal bool IsSetDefaultIamRoleArn()
        {
            return this._defaultIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveIamRoles. 
        /// <para>
        /// Zero or more IAM roles in ARN format to disassociate from the cluster. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveIamRoles
        {
            get { return this._removeIamRoles; }
            set { this._removeIamRoles = value; }
        }

        // Check to see if RemoveIamRoles property is set
        internal bool IsSetRemoveIamRoles()
        {
            return this._removeIamRoles != null && (this._removeIamRoles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}