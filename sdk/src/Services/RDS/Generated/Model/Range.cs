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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A range of integer values.
    /// </summary>
    public partial class Range
    {
        private int? _from;
        private int? _step;
        private int? _to;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The minimum value in the range.
        /// </para>
        /// </summary>
        public int From
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
        /// Gets and sets the property Step. 
        /// <para>
        /// The step value for the range. For example, if you have a range of 5,000 to 10,000,
        /// with a step value of 1,000, the valid values start at 5,000 and step up by 1,000.
        /// Even though 7,500 is within the range, it isn't a valid value for the range. The valid
        /// values are 5,000, 6,000, 7,000, 8,000... 
        /// </para>
        /// </summary>
        public int Step
        {
            get { return this._step.GetValueOrDefault(); }
            set { this._step = value; }
        }

        // Check to see if Step property is set
        internal bool IsSetStep()
        {
            return this._step.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The maximum value in the range.
        /// </para>
        /// </summary>
        public int To
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