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
    /// <para> The <c>StatisticSet</c> data type describes the <c>StatisticValues</c> component of MetricDatum, and represents a set of statistics
    /// that describes a specific metric. </para>
    /// </summary>
    public class StatisticSet  
    {
        
        private double? sampleCount;
        private double? sum;
        private double? minimum;
        private double? maximum;

        /// <summary>
        /// The number of samples used for the statistic set.
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
        public StatisticSet WithSampleCount(double sampleCount)
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
        /// The sum of values for the sample set.
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
        public StatisticSet WithSum(double sum)
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
        /// The minimum value of the sample set.
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
        public StatisticSet WithMinimum(double minimum)
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
        /// The maximum value of the sample set.
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
        public StatisticSet WithMaximum(double maximum)
        {
            this.maximum = maximum;
            return this;
        }
            

        // Check to see if Maximum property is set
        internal bool IsSetMaximum()
        {
            return this.maximum.HasValue;       
        }
    }
}
