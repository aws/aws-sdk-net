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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the total number of findings for a type of unused access.
    /// </summary>
    public partial class UnusedAccessTypeStatistics
    {
        private int? _total;
        private string _unusedAccessType;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of findings for the specified unused access type.
        /// </para>
        /// </summary>
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnusedAccessType. 
        /// <para>
        /// The type of unused access.
        /// </para>
        /// </summary>
        public string UnusedAccessType
        {
            get { return this._unusedAccessType; }
            set { this._unusedAccessType = value; }
        }

        // Check to see if UnusedAccessType property is set
        internal bool IsSetUnusedAccessType()
        {
            return this._unusedAccessType != null;
        }

    }
}