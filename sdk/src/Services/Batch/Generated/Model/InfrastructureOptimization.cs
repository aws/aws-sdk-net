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
    /// The infrastructure optimization configuration for an Amazon ECS Managed Instances
    /// capacity provider. Specifies the idle-instance scale-in behavior.
    /// </summary>
    public partial class InfrastructureOptimization
    {
        private int? _scaleInAfter;

        /// <summary>
        /// Gets and sets the property ScaleInAfter. 
        /// <para>
        /// The number of seconds an instance can remain idle before it is terminated. Valid values
        /// are <c>-1</c> or <c>0</c> to <c>3600</c>. Use <c>-1</c> as a special value to disable
        /// scale-in (instances are never terminated for being idle). If not specified, a default
        /// value applies.
        /// </para>
        /// </summary>
        public int? ScaleInAfter
        {
            get { return this._scaleInAfter; }
            set { this._scaleInAfter = value; }
        }

        // Check to see if ScaleInAfter property is set
        internal bool IsSetScaleInAfter()
        {
            return this._scaleInAfter.HasValue; 
        }

    }
}