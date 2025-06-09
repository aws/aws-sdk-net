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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A structure letting customers specify a relative time window over which over which
    /// data is included in the Calculated Attribute. Use positive numbers to indicate that
    /// the endpoint is in the past, and negative numbers to indicate it is in the future.
    /// ValueRange overrides Value.
    /// </summary>
    public partial class ValueRange
    {
        private int? _end;
        private int? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time of when to include objects. Use positive numbers to indicate that the
        /// starting point is in the past, and negative numbers to indicate it is in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time of when to include objects. Use positive numbers to indicate that the
        /// starting point is in the past, and negative numbers to indicate it is in the future.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}