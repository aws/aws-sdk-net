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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Contains trend statistics for a set of reports. The actual values depend on the type
    /// of trend being collected. For more information, see .
    /// </summary>
    public partial class ReportGroupTrendStats
    {
        private string _average;
        private string _max;
        private string _min;

        /// <summary>
        /// Gets and sets the property Average. 
        /// <para>
        /// Contains the average of all values analyzed.
        /// </para>
        /// </summary>
        public string Average
        {
            get { return this._average; }
            set { this._average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this._average != null;
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// Contains the maximum value analyzed.
        /// </para>
        /// </summary>
        public string Max
        {
            get { return this._max; }
            set { this._max = value; }
        }

        // Check to see if Max property is set
        internal bool IsSetMax()
        {
            return this._max != null;
        }

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// Contains the minimum value analyzed.
        /// </para>
        /// </summary>
        public string Min
        {
            get { return this._min; }
            set { this._min = value; }
        }

        // Check to see if Min property is set
        internal bool IsSetMin()
        {
            return this._min != null;
        }

    }
}