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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Provides information about the number of resources used.
    /// </summary>
    public partial class AcquiredLimit
    {
        private int? _count;
        private string _limitId;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of limit resources used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2147483647)]
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LimitId. 
        /// <para>
        /// The unique identifier of the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LimitId
        {
            get { return this._limitId; }
            set { this._limitId = value; }
        }

        // Check to see if LimitId property is set
        internal bool IsSetLimitId()
        {
            return this._limitId != null;
        }

    }
}