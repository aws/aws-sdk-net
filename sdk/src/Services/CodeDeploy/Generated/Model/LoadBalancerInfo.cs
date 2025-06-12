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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about the Elastic Load Balancing load balancer or target group used in
    /// a deployment.
    /// 
    ///  
    /// <para>
    /// You can use load balancers and target groups in combination. For example, if you have
    /// two Classic Load Balancers, and five target groups tied to an Application Load Balancer,
    /// you can specify the two Classic Load Balancers in <c>elbInfoList</c>, and the five
    /// target groups in <c>targetGroupInfoList</c>.
    /// </para>
    /// </summary>
    public partial class LoadBalancerInfo
    {
        private List<ELBInfo> _elbInfoList = AWSConfigs.InitializeCollections ? new List<ELBInfo>() : null;
        private List<TargetGroupInfo> _targetGroupInfoList = AWSConfigs.InitializeCollections ? new List<TargetGroupInfo>() : null;
        private List<TargetGroupPairInfo> _targetGroupPairInfoList = AWSConfigs.InitializeCollections ? new List<TargetGroupPairInfo>() : null;

        /// <summary>
        /// Gets and sets the property ElbInfoList. 
        /// <para>
        /// An array that contains information about the load balancers to use for load balancing
        /// in a deployment. If you're using Classic Load Balancers, specify those load balancers
        /// in this array. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can add up to 10 load balancers to the array.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you're using Application Load Balancers or Network Load Balancers, use the <c>targetGroupInfoList</c>
        /// array instead of this one.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ELBInfo> ElbInfoList
        {
            get { return this._elbInfoList; }
            set { this._elbInfoList = value; }
        }

        // Check to see if ElbInfoList property is set
        internal bool IsSetElbInfoList()
        {
            return this._elbInfoList != null && (this._elbInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupInfoList. 
        /// <para>
        /// An array that contains information about the target groups to use for load balancing
        /// in a deployment. If you're using Application Load Balancers and Network Load Balancers,
        /// specify their associated target groups in this array.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can add up to 10 target groups to the array.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you're using Classic Load Balancers, use the <c>elbInfoList</c> array instead of
        /// this one.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetGroupInfo> TargetGroupInfoList
        {
            get { return this._targetGroupInfoList; }
            set { this._targetGroupInfoList = value; }
        }

        // Check to see if TargetGroupInfoList property is set
        internal bool IsSetTargetGroupInfoList()
        {
            return this._targetGroupInfoList != null && (this._targetGroupInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupPairInfoList. 
        /// <para>
        ///  The target group pair information. This is an array of <c>TargeGroupPairInfo</c>
        /// objects with a maximum size of one. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetGroupPairInfo> TargetGroupPairInfoList
        {
            get { return this._targetGroupPairInfoList; }
            set { this._targetGroupPairInfoList = value; }
        }

        // Check to see if TargetGroupPairInfoList property is set
        internal bool IsSetTargetGroupPairInfoList()
        {
            return this._targetGroupPairInfoList != null && (this._targetGroupPairInfoList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}