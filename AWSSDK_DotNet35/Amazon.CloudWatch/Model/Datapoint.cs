/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// <para> The <c>Datapoint</c> data type encapsulates the statistical data that Amazon CloudWatch computes from metric data. </para>
    /// </summary>
    public class Datapoint
    {
        
        private DateTime? timestamp;
        private double? sampleCount;
        private double? average;
        private double? sum;
        private double? minimum;
        private double? maximum;
        private StandardUnit unit;

        /// <summary>
        /// The time stamp used for the datapoint. Amazon CloudWatch uses Coordinated Universal Time (UTC) when returning time stamps, which do not
        /// accommodate seasonal adjustments such as daylight savings time. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#about_timestamp">Time stamps</a> in the
        /// <i>Amazon CloudWatch Developer Guide</i>.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this.timestamp.HasValue;
        }

        /// <summary>
        /// The number of metric values that contributed to the aggregate value of this datapoint.
        ///  
        /// </summary>
        public double SampleCount
        {
            get { return this.sampleCount ?? default(double); }
            set { this.sampleCount = value; }
        }

        // Check to see if SampleCount property is set
        internal bool IsSetSampleCount()
        {
            return this.sampleCount.HasValue;
        }

        /// <summary>
        /// The average of metric values that correspond to the datapoint.
        ///  
        /// </summary>
        public double Average
        {
            get { return this.average ?? default(double); }
            set { this.average = value; }
        }

        // Check to see if Average property is set
        internal bool IsSetAverage()
        {
            return this.average.HasValue;
        }

        /// <summary>
        /// The sum of metric values used for the datapoint.
        ///  
        /// </summary>
        public double Sum
        {
            get { return this.sum ?? default(double); }
            set { this.sum = value; }
        }

        // Check to see if Sum property is set
        internal bool IsSetSum()
        {
            return this.sum.HasValue;
        }

        /// <summary>
        /// The minimum metric value used for the datapoint.
        ///  
        /// </summary>
        public double Minimum
        {
            get { return this.minimum ?? default(double); }
            set { this.minimum = value; }
        }

        // Check to see if Minimum property is set
        internal bool IsSetMinimum()
        {
            return this.minimum.HasValue;
        }

        /// <summary>
        /// The maximum of the metric value used for the datapoint.
        ///  
        /// </summary>
        public double Maximum
        {
            get { return this.maximum ?? default(double); }
            set { this.maximum = value; }
        }

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this.maximum.HasValue;
        }

        /// <summary>
        /// The standard unit used for the datapoint.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Seconds, Microseconds, Milliseconds, Bytes, Kilobytes, Megabytes, Gigabytes, Terabytes, Bits, Kilobits, Megabits, Gigabits, Terabits, Percent, Count, Bytes/Second, Kilobytes/Second, Megabytes/Second, Gigabytes/Second, Terabytes/Second, Bits/Second, Kilobits/Second, Megabits/Second, Gigabits/Second, Terabits/Second, Count/Second, None</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public StandardUnit Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this.unit != null;
        }
    }
}
