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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Filters results based on timestamp range (in epochs).
    /// </summary>
    public partial class DateRangeType
    {
        private DateTime? _endValue;
        private DateTime? _startValue;

        /// <summary>
        /// Gets and sets the property EndValue. 
        /// <para>
        /// Timestamp range end value (in epochs).
        /// </para>
        /// </summary>
        public DateTime EndValue
        {
            get { return this._endValue.GetValueOrDefault(); }
            set { this._endValue = value; }
        }

        // Check to see if EndValue property is set
        internal bool IsSetEndValue()
        {
            return this._endValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartValue. 
        /// <para>
        /// Timestamp range start value (in epochs)
        /// </para>
        /// </summary>
        public DateTime StartValue
        {
            get { return this._startValue.GetValueOrDefault(); }
            set { this._startValue = value; }
        }

        // Check to see if StartValue property is set
        internal bool IsSetStartValue()
        {
            return this._startValue.HasValue; 
        }

    }
}