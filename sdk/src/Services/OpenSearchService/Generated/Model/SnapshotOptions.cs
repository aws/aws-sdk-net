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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The time, in UTC format, when OpenSearch Service takes a daily automated snapshot
    /// of the specified domain. Default is <c>0</c> hours.
    /// </summary>
    public partial class SnapshotOptions
    {
        private int? _automatedSnapshotStartHour;

        /// <summary>
        /// Gets and sets the property AutomatedSnapshotStartHour. 
        /// <para>
        /// The time, in UTC format, when OpenSearch Service takes a daily automated snapshot
        /// of the specified domain. Default is <c>0</c> hours.
        /// </para>
        /// </summary>
        public int? AutomatedSnapshotStartHour
        {
            get { return this._automatedSnapshotStartHour; }
            set { this._automatedSnapshotStartHour = value; }
        }

        // Check to see if AutomatedSnapshotStartHour property is set
        internal bool IsSetAutomatedSnapshotStartHour()
        {
            return this._automatedSnapshotStartHour.HasValue; 
        }

    }
}