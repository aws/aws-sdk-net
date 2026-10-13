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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides statistics for each data field imported into to an Amazon Forecast dataset
    /// with the <a href="https://docs.aws.amazon.com/forecast/latest/dg/API_CreateDatasetImportJob.html">CreateDatasetImportJob</a>
    /// operation.
    /// </summary>
    public partial class Statistics
    {
        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// For a numeric field, the average value in the field.
        /// </para>
        /// </summary>
        public double? Avg { get; set; }

        /// <summary>
        /// Checks to see if the Avg property is set.
        /// </summary>
        internal bool IsSetAvg() => this.Avg.HasValue;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of values in the field. If the response value is -1, refer to <c>CountLong</c>.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property CountDistinct. 
        /// <para>
        /// The number of distinct values in the field. If the response value is -1, refer to
        /// <c>CountDistinctLong</c>.
        /// </para>
        /// </summary>
        public int? CountDistinct { get; set; }

        /// <summary>
        /// Checks to see if the CountDistinct property is set.
        /// </summary>
        internal bool IsSetCountDistinct() => this.CountDistinct.HasValue;

        /// <summary>
        /// Gets and sets the property CountDistinctLong. 
        /// <para>
        /// The number of distinct values in the field. <c>CountDistinctLong</c> is used instead
        /// of <c>CountDistinct</c> if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountDistinctLong { get; set; }

        /// <summary>
        /// Checks to see if the CountDistinctLong property is set.
        /// </summary>
        internal bool IsSetCountDistinctLong() => this.CountDistinctLong.HasValue;

        /// <summary>
        /// Gets and sets the property CountLong. 
        /// <para>
        /// The number of values in the field. <c>CountLong</c> is used instead of <c>Count</c>
        /// if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountLong { get; set; }

        /// <summary>
        /// Checks to see if the CountLong property is set.
        /// </summary>
        internal bool IsSetCountLong() => this.CountLong.HasValue;

        /// <summary>
        /// Gets and sets the property CountNan. 
        /// <para>
        /// The number of NAN (not a number) values in the field. If the response value is -1,
        /// refer to <c>CountNanLong</c>.
        /// </para>
        /// </summary>
        public int? CountNan { get; set; }

        /// <summary>
        /// Checks to see if the CountNan property is set.
        /// </summary>
        internal bool IsSetCountNan() => this.CountNan.HasValue;

        /// <summary>
        /// Gets and sets the property CountNanLong. 
        /// <para>
        /// The number of NAN (not a number) values in the field. <c>CountNanLong</c> is used
        /// instead of <c>CountNan</c> if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountNanLong { get; set; }

        /// <summary>
        /// Checks to see if the CountNanLong property is set.
        /// </summary>
        internal bool IsSetCountNanLong() => this.CountNanLong.HasValue;

        /// <summary>
        /// Gets and sets the property CountNull. 
        /// <para>
        /// The number of null values in the field. If the response value is -1, refer to <c>CountNullLong</c>.
        /// </para>
        /// </summary>
        public int? CountNull { get; set; }

        /// <summary>
        /// Checks to see if the CountNull property is set.
        /// </summary>
        internal bool IsSetCountNull() => this.CountNull.HasValue;

        /// <summary>
        /// Gets and sets the property CountNullLong. 
        /// <para>
        /// The number of null values in the field. <c>CountNullLong</c> is used instead of <c>CountNull</c>
        /// if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountNullLong { get; set; }

        /// <summary>
        /// Checks to see if the CountNullLong property is set.
        /// </summary>
        internal bool IsSetCountNullLong() => this.CountNullLong.HasValue;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// For a numeric field, the maximum value in the field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max != null;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        /// For a numeric field, the minimum value in the field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min != null;

        /// <summary>
        /// Gets and sets the property Stddev. 
        /// <para>
        /// For a numeric field, the standard deviation.
        /// </para>
        /// </summary>
        public double? Stddev { get; set; }

        /// <summary>
        /// Checks to see if the Stddev property is set.
        /// </summary>
        internal bool IsSetStddev() => this.Stddev.HasValue;
    }
}
