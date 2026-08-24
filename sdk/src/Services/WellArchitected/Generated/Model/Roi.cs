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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A return-on-investment estimate with context.
    /// </summary>
    public partial class Roi
    {
        private string _detail;
        private string _estimate;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// A sentence providing context for the estimate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=300)]
        public string Detail
        {
            get { return this._detail; }
            set { this._detail = value; }
        }

        // Check to see if Detail property is set
        internal bool IsSetDetail()
        {
            return this._detail != null;
        }

        /// <summary>
        /// Gets and sets the property Estimate. 
        /// <para>
        /// A short statistic or key metric. Optional when there is no quantifiable figure.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=40)]
        public string Estimate
        {
            get { return this._estimate; }
            set { this._estimate = value; }
        }

        // Check to see if Estimate property is set
        internal bool IsSetEstimate()
        {
            return this._estimate != null;
        }

    }
}