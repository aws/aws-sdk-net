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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The order that compute environments are tried in for job placement within a queue.
    /// Compute environments are tried in ascending order. For example, if two compute environments
    /// are associated with a job queue, the compute environment with a lower order integer
    /// value is tried for job placement first. Compute environments must be in the <c>VALID</c>
    /// state before you can associate them with a job queue. All of the compute environments
    /// must be either EC2 (<c>EC2</c> or <c>SPOT</c>) or Fargate (<c>FARGATE</c> or <c>FARGATE_SPOT</c>);
    /// Amazon EC2 and Fargate compute environments can't be mixed.
    /// 
    ///  <note> 
    /// <para>
    /// All compute environments that are associated with a job queue must share the same
    /// architecture. Batch doesn't support mixing compute environment architecture types
    /// in a single job queue.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ComputeEnvironmentOrder
    {
        private string _computeEnvironment;
        private int? _order;

        /// <summary>
        /// Gets and sets the property ComputeEnvironment. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the compute environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ComputeEnvironment
        {
            get { return this._computeEnvironment; }
            set { this._computeEnvironment = value; }
        }

        // Check to see if ComputeEnvironment property is set
        internal bool IsSetComputeEnvironment()
        {
            return this._computeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order of the compute environment. Compute environments are tried in ascending
        /// order. For example, if two compute environments are associated with a job queue, the
        /// compute environment with a lower <c>order</c> integer value is tried for job placement
        /// first.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order.HasValue; 
        }

    }
}