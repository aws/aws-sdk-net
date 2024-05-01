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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that defines the time range that you want to retrieve results from.
    /// </summary>
    public partial class TimeRange
    {
        private long? _after;
        private long? _before;

        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// The beginning of the time range to retrieve performance events from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? After
        {
            get { return this._after; }
            set { this._after = value; }
        }

        // Check to see if After property is set
        internal bool IsSetAfter()
        {
            return this._after.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Before. 
        /// <para>
        /// The end of the time range to retrieve performance events from. If you omit this, the
        /// time range extends to the time that this operation is performed.
        /// </para>
        /// </summary>
        public long? Before
        {
            get { return this._before; }
            set { this._before = value; }
        }

        // Check to see if Before property is set
        internal bool IsSetBefore()
        {
            return this._before.HasValue; 
        }

    }
}