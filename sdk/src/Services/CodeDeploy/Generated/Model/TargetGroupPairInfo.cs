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
    /// Information about two target groups and how traffic is routed during an Amazon ECS
    /// deployment. An optional test traffic route can be specified.
    /// </summary>
    public partial class TargetGroupPairInfo
    {
        private TrafficRoute _prodTrafficRoute;
        private List<TargetGroupInfo> _targetGroups = AWSConfigs.InitializeCollections ? new List<TargetGroupInfo>() : null;
        private TrafficRoute _testTrafficRoute;

        /// <summary>
        /// Gets and sets the property ProdTrafficRoute. 
        /// <para>
        ///  The path used by a load balancer to route production traffic when an Amazon ECS deployment
        /// is complete. 
        /// </para>
        /// </summary>
        public TrafficRoute ProdTrafficRoute
        {
            get { return this._prodTrafficRoute; }
            set { this._prodTrafficRoute = value; }
        }

        // Check to see if ProdTrafficRoute property is set
        internal bool IsSetProdTrafficRoute()
        {
            return this._prodTrafficRoute != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        ///  One pair of target groups. One is associated with the original task set. The second
        /// is associated with the task set that serves traffic after the deployment is complete.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetGroupInfo> TargetGroups
        {
            get { return this._targetGroups; }
            set { this._targetGroups = value; }
        }

        // Check to see if TargetGroups property is set
        internal bool IsSetTargetGroups()
        {
            return this._targetGroups != null && (this._targetGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TestTrafficRoute. 
        /// <para>
        ///  An optional path used by a load balancer to route test traffic after an Amazon ECS
        /// deployment. Validation can occur while test traffic is served during a deployment.
        /// 
        /// </para>
        /// </summary>
        public TrafficRoute TestTrafficRoute
        {
            get { return this._testTrafficRoute; }
            set { this._testTrafficRoute = value; }
        }

        // Check to see if TestTrafficRoute property is set
        internal bool IsSetTestTrafficRoute()
        {
            return this._testTrafficRoute != null;
        }

    }
}