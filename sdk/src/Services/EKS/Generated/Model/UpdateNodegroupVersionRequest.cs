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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNodegroupVersion operation.
    /// Updates the Kubernetes version or AMI version of an Amazon EKS managed node group.
    /// 
    ///  
    /// <para>
    /// You can update a node group using a launch template only if the node group was originally
    /// deployed with a launch template. If you need to update a custom AMI in a node group
    /// that was deployed with a launch template, then update your custom AMI, specify the
    /// new ID in a new version of the launch template, and then update the node group to
    /// the new version of the launch template.
    /// </para>
    ///  
    /// <para>
    /// If you update without a launch template, then you can update to the latest available
    /// AMI version of a node group's current Kubernetes version by not specifying a Kubernetes
    /// version in the request. You can update to the latest AMI version of your cluster's
    /// current Kubernetes version by specifying your cluster's Kubernetes version in the
    /// request. For information about Linux versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html">Amazon
    /// EKS optimized Amazon Linux AMI versions</a> in the <i>Amazon EKS User Guide</i>. For
    /// information about Windows versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-ami-versions-windows.html">Amazon
    /// EKS optimized Windows AMI versions</a> in the <i>Amazon EKS User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// You cannot roll back a node group to an earlier Kubernetes version or AMI version.
    /// </para>
    ///  
    /// <para>
    /// When a node in a managed node group is terminated due to a scaling action or update,
    /// the pods in that node are drained first. Amazon EKS attempts to drain the nodes gracefully
    /// and will fail if it is unable to do so. You can <code>force</code> the update if Amazon
    /// EKS is unable to drain the nodes as a result of a pod disruption budget issue.
    /// </para>
    /// </summary>
    public partial class UpdateNodegroupVersionRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private bool? _force;
        private LaunchTemplateSpecification _launchTemplate;
        private string _nodegroupName;
        private string _releaseVersion;
        private string _version;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster that is associated with the managed node group
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Force the update if the existing node group's pods are unable to be drained due to
        /// a pod disruption budget issue. If an update fails because pods could not be drained,
        /// you can force the update after it fails to terminate the old node whether or not any
        /// pods are running on the node.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// An object representing a node group's launch template specification. You can only
        /// update a node group using a launch template if the node group was originally deployed
        /// with a launch template.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name of the managed node group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodegroupName
        {
            get { return this._nodegroupName; }
            set { this._nodegroupName = value; }
        }

        // Check to see if NodegroupName property is set
        internal bool IsSetNodegroupName()
        {
            return this._nodegroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseVersion. 
        /// <para>
        /// The AMI version of the Amazon EKS optimized AMI to use for the update. By default,
        /// the latest available AMI version for the node group's Kubernetes version is used.
        /// For information about Linux versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-linux-ami-versions.html">Amazon
        /// EKS optimized Amazon Linux AMI versions</a> in the <i>Amazon EKS User Guide</i>. Amazon
        /// EKS managed node groups support the November 2022 and later releases of the Windows
        /// AMIs. For information about Windows versions, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/eks-ami-versions-windows.html">Amazon
        /// EKS optimized Windows AMI versions</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>launchTemplate</code>, and your launch template uses a custom
        /// AMI, then don't specify <code>releaseVersion</code>, or the node group update will
        /// fail. For more information about using launch templates with Amazon EKS, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string ReleaseVersion
        {
            get { return this._releaseVersion; }
            set { this._releaseVersion = value; }
        }

        // Check to see if ReleaseVersion property is set
        internal bool IsSetReleaseVersion()
        {
            return this._releaseVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Kubernetes version to update to. If no version is specified, then the Kubernetes
        /// version of the node group does not change. You can specify the Kubernetes version
        /// of the cluster to update the node group to the latest AMI version of the cluster's
        /// Kubernetes version. If you specify <code>launchTemplate</code>, and your launch template
        /// uses a custom AMI, then don't specify <code>version</code>, or the node group update
        /// will fail. For more information about using launch templates with Amazon EKS, see
        /// <a href="https://docs.aws.amazon.com/eks/latest/userguide/launch-templates.html">Launch
        /// template support</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}