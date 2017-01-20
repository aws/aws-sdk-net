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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EventAggregate
    {
        private string _aggregateValue;
        private int? _count;

        /// <summary>
        /// Gets and sets the property AggregateValue. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string AggregateValue
        {
            get { return this._aggregateValue; }
            set { this._aggregateValue = value; }
        }

        // Check to see if AggregateValue property is set
        internal bool IsSetAggregateValue()
        {
            return this._aggregateValue != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

    }
}