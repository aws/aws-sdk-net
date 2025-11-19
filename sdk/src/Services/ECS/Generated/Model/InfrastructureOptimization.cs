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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The configuration that controls how Amazon ECS optimizes your infrastructure.
    /// </summary>
    public partial class InfrastructureOptimization
    {
        private int? _scaleInAfter;

        /// <summary>
        /// Gets and sets the property ScaleInAfter. 
        /// <para>
        /// This parameter defines the number of seconds Amazon ECS Managed Instances waits before
        /// optimizing EC2 instances that have become idle or underutilized. A longer delay increases
        /// the likelihood of placing new tasks on idle or underutilized instances instances,
        /// reducing startup time. A shorter delay helps reduce infrastructure costs by optimizing
        /// idle or underutilized instances,instances more quickly.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>null</c> - Uses the default optimization behavior.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>-1</c> - Disables automatic infrastructure optimization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A value between <c>0</c> and <c>3600</c> (inclusive) - Specifies the number of seconds
        /// to wait before optimizing instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int ScaleInAfter
        {
            get { return this._scaleInAfter.GetValueOrDefault(); }
            set { this._scaleInAfter = value; }
        }

        // Check to see if ScaleInAfter property is set
        internal bool IsSetScaleInAfter()
        {
            return this._scaleInAfter.HasValue; 
        }

    }
}