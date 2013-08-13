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
        private string unit;

        /// <summary>
        /// The time stamp used for the datapoint.
        ///  
        /// </summary>
        public DateTime Timestamp
        {
            get { return this.timestamp ?? default(DateTime); }
            set { this.timestamp = value; }
        }

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">The value to set for the Timestamp property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithTimestamp(DateTime timestamp)
        {
            this.timestamp = timestamp;
            return this;
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

        /// <summary>
        /// Sets the SampleCount property
        /// </summary>
        /// <param name="sampleCount">The value to set for the SampleCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithSampleCount(double sampleCount)
        {
            this.sampleCount = sampleCount;
            return this;
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

        /// <summary>
        /// Sets the Average property
        /// </summary>
        /// <param name="average">The value to set for the Average property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithAverage(double average)
        {
            this.average = average;
            return this;
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

        /// <summary>
        /// Sets the Sum property
        /// </summary>
        /// <param name="sum">The value to set for the Sum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithSum(double sum)
        {
            this.sum = sum;
            return this;
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

        /// <summary>
        /// Sets the Minimum property
        /// </summary>
        /// <param name="minimum">The value to set for the Minimum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithMinimum(double minimum)
        {
            this.minimum = minimum;
            return this;
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

        /// <summary>
        /// Sets the Maximum property
        /// </summary>
        /// <param name="maximum">The value to set for the Maximum property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithMaximum(double maximum)
        {
            this.maximum = maximum;
            return this;
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
        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        /// <summary>
        /// Sets the Unit property
        /// </summary>
        /// <param name="unit">The value to set for the Unit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Datapoint WithUnit(string unit)
        {
            this.unit = unit;
            return this;
        }
            

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this.unit != null;       
        }
    }
}
