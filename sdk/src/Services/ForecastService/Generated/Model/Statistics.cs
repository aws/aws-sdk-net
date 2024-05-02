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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
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
        private double? _avg;
        private int? _count;
        private int? _countDistinct;
        private long? _countDistinctLong;
        private long? _countLong;
        private int? _countNan;
        private long? _countNanLong;
        private int? _countNull;
        private long? _countNullLong;
        private string _max;
        private string _min;
        private double? _stddev;

        /// <summary>
        /// Gets and sets the property Avg. 
        /// <para>
        /// For a numeric field, the average value in the field.
        /// </para>
        /// </summary>
        public double? Avg
        {
            get { return this._avg; }
            set { this._avg = value; }
        }

        // Check to see if Avg property is set
        internal bool IsSetAvg()
        {
            return this._avg.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of values in the field. If the response value is -1, refer to <c>CountLong</c>.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountDistinct. 
        /// <para>
        /// The number of distinct values in the field. If the response value is -1, refer to
        /// <c>CountDistinctLong</c>.
        /// </para>
        /// </summary>
        public int? CountDistinct
        {
            get { return this._countDistinct; }
            set { this._countDistinct = value; }
        }

        // Check to see if CountDistinct property is set
        internal bool IsSetCountDistinct()
        {
            return this._countDistinct.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountDistinctLong. 
        /// <para>
        /// The number of distinct values in the field. <c>CountDistinctLong</c> is used instead
        /// of <c>CountDistinct</c> if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountDistinctLong
        {
            get { return this._countDistinctLong; }
            set { this._countDistinctLong = value; }
        }

        // Check to see if CountDistinctLong property is set
        internal bool IsSetCountDistinctLong()
        {
            return this._countDistinctLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountLong. 
        /// <para>
        /// The number of values in the field. <c>CountLong</c> is used instead of <c>Count</c>
        /// if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountLong
        {
            get { return this._countLong; }
            set { this._countLong = value; }
        }

        // Check to see if CountLong property is set
        internal bool IsSetCountLong()
        {
            return this._countLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountNan. 
        /// <para>
        /// The number of NAN (not a number) values in the field. If the response value is -1,
        /// refer to <c>CountNanLong</c>.
        /// </para>
        /// </summary>
        public int? CountNan
        {
            get { return this._countNan; }
            set { this._countNan = value; }
        }

        // Check to see if CountNan property is set
        internal bool IsSetCountNan()
        {
            return this._countNan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountNanLong. 
        /// <para>
        /// The number of NAN (not a number) values in the field. <c>CountNanLong</c> is used
        /// instead of <c>CountNan</c> if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountNanLong
        {
            get { return this._countNanLong; }
            set { this._countNanLong = value; }
        }

        // Check to see if CountNanLong property is set
        internal bool IsSetCountNanLong()
        {
            return this._countNanLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountNull. 
        /// <para>
        /// The number of null values in the field. If the response value is -1, refer to <c>CountNullLong</c>.
        /// </para>
        /// </summary>
        public int? CountNull
        {
            get { return this._countNull; }
            set { this._countNull = value; }
        }

        // Check to see if CountNull property is set
        internal bool IsSetCountNull()
        {
            return this._countNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CountNullLong. 
        /// <para>
        /// The number of null values in the field. <c>CountNullLong</c> is used instead of <c>CountNull</c>
        /// if the value is greater than 2,147,483,647.
        /// </para>
        /// </summary>
        public long? CountNullLong
        {
            get { return this._countNullLong; }
            set { this._countNullLong = value; }
        }

        // Check to see if CountNullLong property is set
        internal bool IsSetCountNullLong()
        {
            return this._countNullLong.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// For a numeric field, the maximum value in the field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// For a numeric field, the minimum value in the field.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property Stddev. 
        /// <para>
        /// For a numeric field, the standard deviation.
        /// </para>
        /// </summary>
        public double? Stddev
        {
            get { return this._stddev; }
            set { this._stddev = value; }
        }

        // Check to see if Stddev property is set
        internal bool IsSetStddev()
        {
            return this._stddev.HasValue; 
        }

    }
}