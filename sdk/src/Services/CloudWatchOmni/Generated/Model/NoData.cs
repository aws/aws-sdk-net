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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Configures how the alert reacts when an evaluation produces no data. {@code treatAs}
    /// carries the resulting state; defaults to {@code NODATA} when omitted.
    /// </summary>
    public partial class NoData
    {
        private AlertState _treatAs;

        /// <summary>
        /// Gets and sets the property TreatAs. 
        /// <para>
        /// The state to report when an evaluation produces no data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlertState TreatAs
        {
            get { return this._treatAs; }
            set { this._treatAs = value; }
        }

        // Check to see if TreatAs property is set
        internal bool IsSetTreatAs()
        {
            return this._treatAs != null;
        }

    }
}