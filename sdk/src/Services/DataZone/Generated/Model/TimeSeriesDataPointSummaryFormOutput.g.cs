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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The summary of the time series data points form.
    /// </summary>
    public partial class TimeSeriesDataPointSummaryFormOutput
    {
        /// <summary>
        /// Gets and sets the property ContentSummary. 
        /// <para>
        /// The content of the summary of the time series data points form.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 20000)]
        public string ContentSummary { get; set; }

        /// <summary>
        /// Checks to see if the ContentSummary property is set.
        /// </summary>
        internal bool IsSetContentSummary() => this.ContentSummary != null;

        /// <summary>
        /// Gets and sets the property FormName. 
        /// <para>
        /// The name of the time series data points summary form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string FormName { get; set; }

        /// <summary>
        /// Checks to see if the FormName property is set.
        /// </summary>
        internal bool IsSetFormName() => this.FormName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the time series data points summary form.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the time series data points summary form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The type ID of the time series data points summary form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 385)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TypeIdentifier property is set.
        /// </summary>
        internal bool IsSetTypeIdentifier() => this.TypeIdentifier != null;

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The type revision of the time series data points summary form.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TypeRevision { get; set; }

        /// <summary>
        /// Checks to see if the TypeRevision property is set.
        /// </summary>
        internal bool IsSetTypeRevision() => this.TypeRevision != null;
    }
}
