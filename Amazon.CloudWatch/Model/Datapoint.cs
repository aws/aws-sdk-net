/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.CloudWatch.Model
{
    ///<summary>
    ///A collection of datapoints.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Datapoint
    {
        private string timestampField;
        private Double? samplesField;
        private Double? averageField;
        private Double? sumField;
        private Double? minimumField;
        private Double? maximumField;
        private string unitField;
        private string customUnitField;

        /// <summary>
        /// Gets and sets the Timestamp property.
        /// Indicates the beginning of the time aggregation for this value and samples.s
        /// </summary>
        [XmlElementAttribute(ElementName = "Timestamp")]
        public string Timestamp
        {
            get { return this.timestampField ; }
            set { this.timestampField= value; }
        }

        /// <summary>
        /// Sets the Timestamp property
        /// </summary>
        /// <param name="timestamp">Indicates the beginning of the time aggregation for this value and samples.s</param>
        /// <returns>this instance</returns>
        public Datapoint WithTimestamp(string timestamp)
        {
            this.timestampField = timestamp;
            return this;
        }

        /// <summary>
        /// Checks if Timestamp property is set
        /// </summary>
        /// <returns>true if Timestamp property is set</returns>
        public bool IsSetTimestamp()
        {
            return  this.timestampField != null;
        }

        /// <summary>
        /// Gets and sets the Samples property.
        /// The number of Measurements that contributed to the aggregate value of this datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Samples")]
        public Double Samples
        {
            get { return this.samplesField.GetValueOrDefault() ; }
            set { this.samplesField= value; }
        }

        /// <summary>
        /// Sets the Samples property
        /// </summary>
        /// <param name="samples">The number of Measurements that contributed to the aggregate value of this datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithSamples(Double samples)
        {
            this.samplesField = samples;
            return this;
        }

        /// <summary>
        /// Checks if Samples property is set
        /// </summary>
        /// <returns>true if Samples property is set</returns>
        public bool IsSetSamples()
        {
            return  this.samplesField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Average property.
        /// Average of samples for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Average")]
        public Double Average
        {
            get { return this.averageField.GetValueOrDefault() ; }
            set { this.averageField= value; }
        }

        /// <summary>
        /// Sets the Average property
        /// </summary>
        /// <param name="average">Average of samples for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithAverage(Double average)
        {
            this.averageField = average;
            return this;
        }

        /// <summary>
        /// Checks if Average property is set
        /// </summary>
        /// <returns>true if Average property is set</returns>
        public bool IsSetAverage()
        {
            return  this.averageField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Sum property.
        /// Sum of samples for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Sum")]
        public Double Sum
        {
            get { return this.sumField.GetValueOrDefault() ; }
            set { this.sumField= value; }
        }

        /// <summary>
        /// Sets the Sum property
        /// </summary>
        /// <param name="sum">Sum of samples for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithSum(Double sum)
        {
            this.sumField = sum;
            return this;
        }

        /// <summary>
        /// Checks if Sum property is set
        /// </summary>
        /// <returns>true if Sum property is set</returns>
        public bool IsSetSum()
        {
            return  this.sumField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Minimum property.
        /// Minimum of samples for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Minimum")]
        public Double Minimum
        {
            get { return this.minimumField.GetValueOrDefault() ; }
            set { this.minimumField= value; }
        }

        /// <summary>
        /// Sets the Minimum property
        /// </summary>
        /// <param name="minimum">Minimum of samples for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithMinimum(Double minimum)
        {
            this.minimumField = minimum;
            return this;
        }

        /// <summary>
        /// Checks if Minimum property is set
        /// </summary>
        /// <returns>true if Minimum property is set</returns>
        public bool IsSetMinimum()
        {
            return  this.minimumField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Maximum property.
        /// Maximum of the samples used for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Maximum")]
        public Double Maximum
        {
            get { return this.maximumField.GetValueOrDefault() ; }
            set { this.maximumField= value; }
        }

        /// <summary>
        /// Sets the Maximum property
        /// </summary>
        /// <param name="maximum">Maximum of the samples used for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithMaximum(Double maximum)
        {
            this.maximumField = maximum;
            return this;
        }

        /// <summary>
        /// Checks if Maximum property is set
        /// </summary>
        /// <returns>true if Maximum property is set</returns>
        public bool IsSetMaximum()
        {
            return  this.maximumField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Unit property.
        /// Standard unit used for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "Unit")]
        public string Unit
        {
            get { return this.unitField ; }
            set { this.unitField= value; }
        }

        /// <summary>
        /// Sets the Unit property
        /// </summary>
        /// <param name="unit">Standard unit used for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithUnit(string unit)
        {
            this.unitField = unit;
            return this;
        }

        /// <summary>
        /// Checks if Unit property is set
        /// </summary>
        /// <returns>true if Unit property is set</returns>
        public bool IsSetUnit()
        {
            return  this.unitField != null;
        }

        /// <summary>
        /// Gets and sets the CustomUnit property.
        /// CustomUnit defined for the datapoint.
        /// </summary>
        [XmlElementAttribute(ElementName = "CustomUnit")]
        public string CustomUnit
        {
            get { return this.customUnitField ; }
            set { this.customUnitField= value; }
        }

        /// <summary>
        /// Sets the CustomUnit property
        /// </summary>
        /// <param name="customUnit">CustomUnit defined for the datapoint.</param>
        /// <returns>this instance</returns>
        public Datapoint WithCustomUnit(string customUnit)
        {
            this.customUnitField = customUnit;
            return this;
        }

        /// <summary>
        /// Checks if CustomUnit property is set
        /// </summary>
        /// <returns>true if CustomUnit property is set</returns>
        public bool IsSetCustomUnit()
        {
            return  this.customUnitField != null;
        }

    }
}
