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
    /// The summarized description of the association.
    /// 
    ///  
    /// <para>
    /// Each summary is simplified by removing these fields compared to the full <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_PodIdentityAssociation.html">
    /// <c>PodIdentityAssociation</c> </a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The IAM role: <c>roleArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The timestamp that the association was created at: <c>createdAt</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The most recent timestamp that the association was modified at:. <c>modifiedAt</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The tags on the association: <c>tags</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PodIdentityAssociationSummary
    {
        private string _associationArn;
        private string _associationId;
        private string _clusterName;
        private string _awsNamespace;
        private string _ownerArn;
        private string _serviceAccount;

        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        public string AssociationArn
        {
            get { return this._associationArn; }
            set { this._associationArn = value; }
        }

        // Check to see if AssociationArn property is set
        internal bool IsSetAssociationArn()
        {
            return this._associationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the association is in.
        /// </para>
        /// </summary>
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster to create the association
        /// in. The service account and the Pods that use the service account must be in this
        /// namespace.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// If defined, the association is owned by an Amazon EKS add-on.
        /// </para>
        /// </summary>
        public string OwnerArn
        {
            get { return this._ownerArn; }
            set { this._ownerArn = value; }
        }

        // Check to see if OwnerArn property is set
        internal bool IsSetOwnerArn()
        {
            return this._ownerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account inside the cluster to associate the IAM
        /// credentials with.
        /// </para>
        /// </summary>
        public string ServiceAccount
        {
            get { return this._serviceAccount; }
            set { this._serviceAccount = value; }
        }

        // Check to see if ServiceAccount property is set
        internal bool IsSetServiceAccount()
        {
            return this._serviceAccount != null;
        }

    }
}