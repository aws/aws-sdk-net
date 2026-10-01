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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        public string AssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociationArn property is set.
        /// </summary>
        internal bool IsSetAssociationArn() => this.AssociationArn != null;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that the association is in.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The name of the Kubernetes namespace inside the cluster to create the association
        /// in. The service account and the Pods that use the service account must be in this
        /// namespace.
        /// </para>
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property OwnerArn. 
        /// <para>
        /// If defined, the association is owned by an Amazon EKS add-on.
        /// </para>
        /// </summary>
        public string OwnerArn { get; set; }

        /// <summary>
        /// Checks to see if the OwnerArn property is set.
        /// </summary>
        internal bool IsSetOwnerArn() => this.OwnerArn != null;

        /// <summary>
        /// Gets and sets the property ServiceAccount. 
        /// <para>
        /// The name of the Kubernetes service account inside the cluster to associate the IAM
        /// credentials with.
        /// </para>
        /// </summary>
        public string ServiceAccount { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccount property is set.
        /// </summary>
        internal bool IsSetServiceAccount() => this.ServiceAccount != null;
    }
}
