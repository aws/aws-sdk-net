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
    /// <summary>
    /// This call returns data for one or more statistics of given a metric. For more information, see the CloudWatch developer
    /// documentation. The maximum number of datapoints that the Amazon CloudWatch service will return in a single GetMetricStatistics
    /// request is 1,440. If a request is made that would generate more datapoints than this amount, Amazon CloudWatch will return an
    /// error. You can alter your request by narrowing the time range (StartTime, EndTime) or increasing the Period in your single
    /// request. You may also get all of the data at the granularity you originally asked for by making multiple requests with
    /// adjacent time ranges.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://monitoring.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class GetMetricStatisticsRequest
    {
        private List<string> statisticsField;
        private Decimal? periodField;
        private string measureNameField;
        private List<Dimension> dimensionsField;
        private string startTimeField;
        private string endTimeField;
        private string unitField;
        private string customUnitField;
        private string namespaceValueField;

        /// <summary>
        /// Gets and sets the Statistics property.
        /// The statistics to be returned for the given metric. No default.
        /// </summary>
        [XmlElementAttribute(ElementName = "Statistics")]
        public List<string> Statistics
        {
            get
            {
                if (this.statisticsField == null)
                {
                    this.statisticsField = new List<string>();
                }
                return this.statisticsField;
            }
            set { this.statisticsField = value; }
        }

        /// <summary>
        /// Sets the Statistics property
        /// </summary>
        /// <param name="list">The statistics to be returned for the given metric. No default.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithStatistics(params string[] list)
        {
            foreach (string item in list)
            {
                Statistics.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Statistics property is set
        /// </summary>
        /// <returns>true if Statistics property is set</returns>
        public bool IsSetStatistics()
        {
            return (Statistics.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Period property.
        /// The granularity (in seconds) of the returned datapoints. Valid Values are 60 or a multiple of 60. Default is 60.
        /// </summary>
        [XmlElementAttribute(ElementName = "Period")]
        public Decimal Period
        {
            get { return this.periodField.GetValueOrDefault() ; }
            set { this.periodField= value; }
        }

        /// <summary>
        /// Sets the Period property
        /// </summary>
        /// <param name="period">The granularity (in seconds) of the returned datapoints. Valid Values are 60 or a multiple of 60. Default is 60.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithPeriod(Decimal period)
        {
            this.periodField = period;
            return this;
        }

        /// <summary>
        /// Checks if Period property is set
        /// </summary>
        /// <returns>true if Period property is set</returns>
        public bool IsSetPeriod()
        {
            return  this.periodField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MeasureName property.
        /// The measure name that corresponds to the measure for the gathered metric. Must be a valid collected metric with the corresponding measure name.
        /// </summary>
        [XmlElementAttribute(ElementName = "MeasureName")]
        public string MeasureName
        {
            get { return this.measureNameField ; }
            set { this.measureNameField= value; }
        }

        /// <summary>
        /// Sets the MeasureName property
        /// </summary>
        /// <param name="measureName">The measure name that corresponds to the measure for the gathered metric. Must be a valid collected metric with the corresponding measure name.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithMeasureName(string measureName)
        {
            this.measureNameField = measureName;
            return this;
        }

        /// <summary>
        /// Checks if MeasureName property is set
        /// </summary>
        /// <returns>true if MeasureName property is set</returns>
        public bool IsSetMeasureName()
        {
            return  this.measureNameField != null;
        }
        /// <summary>
        /// Gets and sets the Dimensions property.
        /// Amazon CloudWatch allows you to specify one Dimension to further filter metric data on. If you don't specify a dimension,
        /// the service returns the aggregate of all the measures with the given measure name and time range.
        ///
        /// Exception: LoadBalancerName and AvailabilityZone can be used together as a special case of multiple-dimension aggregation.
        ///
        /// Constraints: Must correspond to dimensions of a currently gathered metric. Please see Amazon CloudWatch Dimensions.
        ///
        /// Default: None
        /// </summary>
        [XmlElementAttribute(ElementName = "Dimensions")]
        public List<Dimension> Dimensions
        {
            get
            {
                if (this.dimensionsField == null)
                {
                    this.dimensionsField = new List<Dimension>();
                }
                return this.dimensionsField;
            }
            set { this.dimensionsField = value; }
        }

        /// <summary>
        /// Sets the Dimensions property
        /// </summary>
        /// <param name="list">Amazon CloudWatch allows you to specify one Dimension to further filter metric data on. If you don't specify a dimension,
        /// the service returns the aggregate of all the measures with the given measure name and time range.
        ///
        /// Exception: LoadBalancerName and AvailabilityZone can be used together as a special case of multiple-dimension aggregation.
        ///
        /// Constraints: Must correspond to dimensions of a currently gathered metric. Please see Amazon CloudWatch Dimensions.
        ///
        /// Default: None</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithDimensions(params Dimension[] list)
        {
            foreach (Dimension item in list)
            {
                Dimensions.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Dimensions property is set
        /// </summary>
        /// <returns>true if Dimensions property is set</returns>
        public bool IsSetDimensions()
        {
            return (Dimensions.Count > 0);
        }

        /// <summary>
        /// Gets and sets the StartTime property.
        /// The timestamp of the first datapoint to return, inclusive. For example, 2008-02-26T19:00:00+00:00. We round your value down
        /// to the nearest minute.
        ///
        /// You can set your start time for more than two weeks in the past. However, you will only get data for the past two weeks.
        ///
        /// In ISO 8601 format; for more information, go to http://isotc.iso.org .)
        ///
        /// Default: None
        ///
        /// Constraints: Must be before EndTime
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField ; }
            set { this.startTimeField= value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The timestamp of the first datapoint to return, inclusive. For example, 2008-02-26T19:00:00+00:00. We round your value down
        /// to the nearest minute.
        ///
        /// You can set your start time for more than two weeks in the past. However, you will only get data for the past two weeks.
        ///
        /// In ISO 8601 format; for more information, go to http://isotc.iso.org .)
        ///
        /// Default: None
        ///
        /// Constraints: Must be before EndTime</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithStartTime(string startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return  this.startTimeField != null;
        }

        /// <summary>
        /// Gets and sets the EndTime property.
        /// The timestamp to use for determining the last datapoint to return. This is the last datapoint to fetch, exclusive.
        /// For example, 2008-02-26T20:00:00+00:00.
        ///
        /// Type: dateTime (in ISO 8601 format; for more information, go to http://isotc.iso.org .)
        ///
        /// Default: None
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public string EndTime
        {
            get { return this.endTimeField ; }
            set { this.endTimeField= value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">The timestamp to use for determining the last datapoint to return. This is the last datapoint to fetch, exclusive.
        /// For example, 2008-02-26T20:00:00+00:00.
        ///
        /// Type: dateTime (in ISO 8601 format; for more information, go to http://isotc.iso.org .)
        ///
        /// Default: None</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithEndTime(string endTime)
        {
            this.endTimeField = endTime;
            return this;
        }

        /// <summary>
        /// Checks if EndTime property is set
        /// </summary>
        /// <returns>true if EndTime property is set</returns>
        public bool IsSetEndTime()
        {
            return  this.endTimeField != null;
        }

        /// <summary>
        /// Gets and sets the Unit property.
        /// The standard unit of Measurement for a given Measure. Please see the key term Unit.
        ///
        /// Default: None
        ///
        /// Valid Values: For more information, see StandardUnit
        ///
        /// Constraints: When using count/second as the unit, you should use Sum as the statistic instead of Average. Otherwise,
        /// the sample returns as equal to the number of requests instead of the number of 60-second intervals. This will cause
        /// the Average to always equals one when the unit is count/second.
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
        /// <param name="unit">The standard unit of Measurement for a given Measure. Please see the key term Unit.
        ///
        /// Default: None
        ///
        /// Valid Values: For more information, see StandardUnit
        ///
        /// Constraints: When using count/second as the unit, you should use Sum as the statistic instead of Average. Otherwise,
        /// the sample returns as equal to the number of requests instead of the number of 60-second intervals. This will cause
        /// the Average to always equals one when the unit is count/second.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithUnit(string unit)
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
        /// The user-defined CustomUnit applied to a Measure. Please see the key term Unit. CustomUnits are not currently available.
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
        /// <param name="customUnit">The user-defined CustomUnit applied to a Measure. Please see the key term Unit. CustomUnits are not currently available.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithCustomUnit(string customUnit)
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

        /// <summary>
        /// Gets and sets the Namespace property.
        /// The namespace corresponding to the service of interest. For example, AWS/EC2 represents Amazon EC2.
        /// </summary>
        [XmlElementAttribute(ElementName = "Namespace")]
        public string Namespace
        {
            get { return this.namespaceValueField ; }
            set { this.namespaceValueField= value; }
        }

        /// <summary>
        /// Sets the Namespace property
        /// </summary>
        /// <param name="namespaceValue">The namespace corresponding to the service of interest. For example, AWS/EC2 represents Amazon EC2.</param>
        /// <returns>this instance</returns>
        public GetMetricStatisticsRequest WithNamespace(string namespaceValue)
        {
            this.namespaceValueField = namespaceValue;
            return this;
        }

        /// <summary>
        /// Checks if Namespace property is set
        /// </summary>
        /// <returns>true if Namespace property is set</returns>
        public bool IsSetNamespace()
        {
            return  this.namespaceValueField != null;
        }

    }
}
