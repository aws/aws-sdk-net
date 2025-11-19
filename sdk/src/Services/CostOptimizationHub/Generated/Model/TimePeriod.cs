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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Specifies a date range for retrieving efficiency metrics. The start date is inclusive
    /// and the end date is exclusive.
    /// </summary>
    public partial class TimePeriod
    {
        private string _end;
        private string _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end of the time period (exclusive). Specify the date in ISO 8601 format, such
        /// as 2024-12-31.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The beginning of the time period (inclusive). Specify the date in ISO 8601 format,
        /// such as 2024-01-01.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}