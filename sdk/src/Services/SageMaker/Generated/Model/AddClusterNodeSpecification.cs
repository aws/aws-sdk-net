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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies an instance group and the number of nodes to add to it.
    /// </summary>
    public partial class AddClusterNodeSpecification
    {
        private int? _incrementTargetCountBy;
        private string _instanceGroupName;

        /// <summary>
        /// Gets and sets the property IncrementTargetCountBy. 
        /// <para>
        /// The number of nodes to add to the specified instance group. The total number of nodes
        /// across all instance groups in a single request cannot exceed 50.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public int? IncrementTargetCountBy
        {
            get { return this._incrementTargetCountBy; }
            set { this._incrementTargetCountBy = value; }
        }

        // Check to see if IncrementTargetCountBy property is set
        internal bool IsSetIncrementTargetCountBy()
        {
            return this._incrementTargetCountBy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group to which you want to add nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string InstanceGroupName
        {
            get { return this._instanceGroupName; }
            set { this._instanceGroupName = value; }
        }

        // Check to see if InstanceGroupName property is set
        internal bool IsSetInstanceGroupName()
        {
            return this._instanceGroupName != null;
        }

    }
}