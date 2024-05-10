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
    /// An object representing the scaling configuration details for the Auto Scaling group
    /// that is associated with your node group. When creating a node group, you must specify
    /// all or none of the properties. When updating a node group, you can specify any or
    /// none of the properties.
    /// </summary>
    public partial class NodegroupScalingConfig
    {
        private int? _desiredSize;
        private int? _maxSize;
        private int? _minSize;

        /// <summary>
        /// Gets and sets the property DesiredSize. 
        /// <para>
        /// The current number of nodes that the managed node group should maintain.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use the Kubernetes <a href="https://github.com/kubernetes/autoscaler#kubernetes-autoscaler">Cluster
        /// Autoscaler</a>, you shouldn't change the <c>desiredSize</c> value directly, as this
        /// can cause the Cluster Autoscaler to suddenly scale up or scale down.
        /// </para>
        ///  </important> 
        /// <para>
        /// Whenever this parameter changes, the number of worker nodes in the node group is updated
        /// to the specified size. If this parameter is given a value that is smaller than the
        /// current number of running worker nodes, the necessary number of worker nodes are terminated
        /// to match the given value. When using CloudFormation, no action occurs if you remove
        /// this parameter from your CFN template.
        /// </para>
        ///  
        /// <para>
        /// This parameter can be different from <c>minSize</c> in some cases, such as when starting
        /// with extra hosts for testing. This parameter can also be different when you want to
        /// start with an estimated number of needed hosts, but let the Cluster Autoscaler reduce
        /// the number if there are too many. When the Cluster Autoscaler is used, the <c>desiredSize</c>
        /// parameter is altered by the Cluster Autoscaler (but can be out-of-date for short periods
        /// of time). the Cluster Autoscaler doesn't scale a managed node group lower than <c>minSize</c>
        /// or higher than <c>maxSize</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DesiredSize
        {
            get { return this._desiredSize; }
            set { this._desiredSize = value; }
        }

        // Check to see if DesiredSize property is set
        internal bool IsSetDesiredSize()
        {
            return this._desiredSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum number of nodes that the managed node group can scale out to. For information
        /// about the maximum number that you can specify, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/service-quotas.html">Amazon
        /// EKS service quotas</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxSize
        {
            get { return this._maxSize; }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum number of nodes that the managed node group can scale in to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? MinSize
        {
            get { return this._minSize; }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

    }
}