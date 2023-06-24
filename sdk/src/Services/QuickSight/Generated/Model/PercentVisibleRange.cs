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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The percent range in the visible range.
    /// </summary>
    public partial class PercentVisibleRange
    {
        private double? _from;
        private double? _to;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The lower bound of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double From
        {
            get { return this._from.GetValueOrDefault(); }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The top bound of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double To
        {
            get { return this._to.GetValueOrDefault(); }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to.HasValue; 
        }

    }
}