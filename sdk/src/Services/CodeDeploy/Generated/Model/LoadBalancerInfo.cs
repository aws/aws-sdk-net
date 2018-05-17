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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the Elastic Load Balancing load balancer or target group used in
    /// a deployment.
    /// </summary>
    public partial class LoadBalancerInfo
    {
        private List<ELBInfo> _elbInfoList = new List<ELBInfo>();
        private List<TargetGroupInfo> _targetGroupInfoList = new List<TargetGroupInfo>();

        /// <summary>
        /// Gets and sets the property ElbInfoList. 
        /// <para>
        /// An array containing information about the load balancer to use for load balancing
        /// in a deployment. In Elastic Load Balancing, load balancers are used with Classic Load
        /// Balancers.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Adding more than one load balancer to the array is not supported. 
        /// </para>
        ///  </note>
        /// </summary>
        public List<ELBInfo> ElbInfoList
        {
            get { return this._elbInfoList; }
            set { this._elbInfoList = value; }
        }

        // Check to see if ElbInfoList property is set
        internal bool IsSetElbInfoList()
        {
            return this._elbInfoList != null && this._elbInfoList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupInfoList. 
        /// <para>
        /// An array containing information about the target group to use for load balancing in
        /// a deployment. In Elastic Load Balancing, target groups are used with Application Load
        /// Balancers.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Adding more than one target group to the array is not supported. 
        /// </para>
        ///  </note>
        /// </summary>
        public List<TargetGroupInfo> TargetGroupInfoList
        {
            get { return this._targetGroupInfoList; }
            set { this._targetGroupInfoList = value; }
        }

        // Check to see if TargetGroupInfoList property is set
        internal bool IsSetTargetGroupInfoList()
        {
            return this._targetGroupInfoList != null && this._targetGroupInfoList.Count > 0; 
        }

    }
}