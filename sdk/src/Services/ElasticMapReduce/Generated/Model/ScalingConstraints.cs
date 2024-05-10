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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The upper and lower Amazon EC2 instance limits for an automatic scaling policy. Automatic
    /// scaling activities triggered by automatic scaling rules will not cause an instance
    /// group to grow above or below these limits.
    /// </summary>
    public partial class ScalingConstraints
    {
        private int? _maxCapacity;
        private int? _minCapacity;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The upper boundary of Amazon EC2 instances in an instance group beyond which scaling
        /// activities are not allowed to grow. Scale-out activities will not add instances beyond
        /// this boundary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The lower boundary of Amazon EC2 instances in an instance group below which scaling
        /// activities are not allowed to shrink. Scale-in activities will not terminate instances
        /// below this boundary.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

    }
}