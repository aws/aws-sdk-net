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
    /// A list of port ranges that are permitted to allow inbound traffic from all public
    /// IP addresses. To specify a single port, use the same value for <c>MinRange</c> and
    /// <c>MaxRange</c>.
    /// </summary>
    public partial class PortRange
    {
        private int? _maxRange;
        private int? _minRange;

        /// <summary>
        /// Gets and sets the property MaxRange. 
        /// <para>
        /// The smallest port number in a specified range of port numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
        public int? MaxRange
        {
            get { return this._maxRange; }
            set { this._maxRange = value; }
        }

        // Check to see if MaxRange property is set
        internal bool IsSetMaxRange()
        {
            return this._maxRange.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinRange. 
        /// <para>
        /// The smallest port number in a specified range of port numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=-1, Max=65535)]
        public int? MinRange
        {
            get { return this._minRange; }
            set { this._minRange = value; }
        }

        // Check to see if MinRange property is set
        internal bool IsSetMinRange()
        {
            return this._minRange.HasValue; 
        }

    }
}