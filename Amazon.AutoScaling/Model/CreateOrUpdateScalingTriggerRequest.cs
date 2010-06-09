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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This call sets the parameters that governs when and how to scale an AutoScalingGroup.
    /// If specified trigger is updated if it already exists within the scope of the caller's AWS account.
    /// If a trigger with a different name already exists, this call fails.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class CreateOrUpdateScalingTriggerRequest
    {
        private string triggerNameField;
        private string autoScalingGroupNameField;
        private string measureNameField;
        private string statisticField;
        private List<Dimension> dimensionsField;
        private Decimal? periodField;
        private string unitField;
        private string customUnitField;
        private string namespaceValueField;
        private Double? lowerThresholdField;
        private string lowerBreachScaleIncrementField;
        private Double? upperThresholdField;
        private string upperBreachScaleIncrementField;
        private Decimal? breachDurationField;

        /// <summary>
        /// Gets and sets the TriggerName property.
        /// The name for this trigger. Must be an alphanumeric string. Must be unique
        /// within the scope of the associated AutoScalingGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "TriggerName")]
        public string TriggerName
        {
            get { return this.triggerNameField ; }
            set { this.triggerNameField= value; }
        }

        /// <summary>
        /// Sets the TriggerName property
        /// </summary>
        /// <param name="triggerName">The name for this trigger. Must be an alphanumeric string. Must be unique
        /// within the scope of the associated AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithTriggerName(string triggerName)
        {
            this.triggerNameField = triggerName;
            return this;
        }

        /// <summary>
        /// Checks if TriggerName property is set
        /// </summary>
        /// <returns>true if TriggerName property is set</returns>
        public bool IsSetTriggerName()
        {
            return  this.triggerNameField != null;
        }

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// The name of the AutoScalingGroup to be associated with the trigger.
        /// The AutoScalingGroup must exist (within the scope of the caller's AWS account).
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoScalingGroupName")]
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupNameField ; }
            set { this.autoScalingGroupNameField= value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The name of the AutoScalingGroup to be associated with the trigger.
        /// The AutoScalingGroup must exist (within the scope of the caller's AWS account).</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupNameField = autoScalingGroupName;
            return this;
        }

        /// <summary>
        /// Checks if AutoScalingGroupName property is set
        /// </summary>
        /// <returns>true if AutoScalingGroupName property is set</returns>
        public bool IsSetAutoScalingGroupName()
        {
            return  this.autoScalingGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the MeasureName property.
        /// The measure name associated with the metric used by the trigger to determine when to fire;
        /// for example, CPU, network I/O, or disk I/O. For more information on Amazon CloudWatch, go to
        /// the Amazon CloudWatch product documentation.
        ///
        /// Valid Values: CPUUtilization | NetworkIn | NetworkOut | DiskWriteOps | DiskReadBytes |
        /// DiskReadOps | DiskWriteBytes
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
        /// <param name="measureName">The measure name associated with the metric used by the trigger to determine when to fire;
        /// for example, CPU, network I/O, or disk I/O. For more information on Amazon CloudWatch, go to
        /// the Amazon CloudWatch product documentation.
        ///
        /// Valid Values: CPUUtilization | NetworkIn | NetworkOut | DiskWriteOps | DiskReadBytes |
        /// DiskReadOps | DiskWriteBytes</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithMeasureName(string measureName)
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
        /// Gets and sets the Statistic property.
        /// The statistic that the trigger uses when fetching metric statistics to examine.
        /// Valid Values: Minimum | Maximum | Sum | Average
        /// </summary>
        [XmlElementAttribute(ElementName = "Statistic")]
        public string Statistic
        {
            get { return this.statisticField ; }
            set { this.statisticField= value; }
        }

        /// <summary>
        /// Sets the Statistic property
        /// </summary>
        /// <param name="statistic">The statistic that the trigger uses when fetching metric statistics to examine.
        /// Valid Values: Minimum | Maximum | Sum | Average</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithStatistic(string statistic)
        {
            this.statisticField = statistic;
            return this;
        }

        /// <summary>
        /// Checks if Statistic property is set
        /// </summary>
        /// <returns>true if Statistic property is set</returns>
        public bool IsSetStatistic()
        {
            return  this.statisticField != null;
        }
        /// <summary>
        /// Gets and sets the Dimensions property.
        /// A list of dimensions associated with the metric used by the trigger to determine whether to fire.
        /// For more information on Amazon CloudWatch, go to the Amazon CloudWatch product documentation.
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
        /// <param name="list">A list of dimensions associated with the metric used by the trigger to determine whether to fire.
        /// For more information on Amazon CloudWatch, go to the Amazon CloudWatch product documentation.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithDimensions(params Dimension[] list)
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
        /// Gets and sets the Period property.
        /// The period associated with the metric statistics in seconds. Must be a multiple of 60.
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
        /// <param name="period">The period associated with the metric statistics in seconds. Must be a multiple of 60.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithPeriod(Decimal period)
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
        /// Gets and sets the Unit property.
        /// The standard unit of measurement for a given measure that the trigger uses when fetching
        /// metric statistics to examine.
        ///
        /// Valid Values: Seconds | Percent | Bytes | Bits | Count | Bytes/Second | Bits/Second | Count/Second | None.
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
        /// <param name="unit">The standard unit of measurement for a given measure that the trigger uses when fetching
        /// metric statistics to examine.
        ///
        /// Valid Values: Seconds | Percent | Bytes | Bits | Count | Bytes/Second | Bits/Second | Count/Second | None.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithUnit(string unit)
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
        /// The user-defined custom unit for a given measure. This is used by the trigger when fetching the
        /// metric statistics it uses to determine whether to activate. Custom units are currently not available.
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
        /// <param name="customUnit">The user-defined custom unit for a given measure. This is used by the trigger when fetching the
        /// metric statistics it uses to determine whether to activate. Custom units are currently not available.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithCustomUnit(string customUnit)
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
        /// The namespace associated with the trigger.
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
        /// <param name="namespaceValue">The namespace associated with the trigger.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithNamespace(string namespaceValue)
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

        /// <summary>
        /// Gets and sets the LowerThreshold property.
        /// The lower limit for the metric. If all datapoints in the last BreachDuration seconds exceed the upper
        /// threshold or fall below the lower threshold, the trigger activates.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowerThreshold")]
        public Double LowerThreshold
        {
            get { return this.lowerThresholdField.GetValueOrDefault() ; }
            set { this.lowerThresholdField= value; }
        }

        /// <summary>
        /// Sets the LowerThreshold property
        /// </summary>
        /// <param name="lowerThreshold">The lower limit for the metric. If all datapoints in the last BreachDuration seconds exceed the upper
        /// threshold or fall below the lower threshold, the trigger activates.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithLowerThreshold(Double lowerThreshold)
        {
            this.lowerThresholdField = lowerThreshold;
            return this;
        }

        /// <summary>
        /// Checks if LowerThreshold property is set
        /// </summary>
        /// <returns>true if LowerThreshold property is set</returns>
        public bool IsSetLowerThreshold()
        {
            return  this.lowerThresholdField.HasValue;
        }

        /// <summary>
        /// Gets and sets the LowerBreachScaleIncrement property.
        /// The incremental amount to use when performing scaling activities when the lower threshold has been breached.
        /// Must be a positive or negative integer followed by a % sign. If you specify only a positive or negative number,
        /// then the AutoScalingGroup increases or decreases by the specified number of actual instances. If you specify a
        /// positive or negative number with a percent sign, the AutoScaling group increases or decreases by the specified
        /// percentage.
        /// </summary>
        [XmlElementAttribute(ElementName = "LowerBreachScaleIncrement")]
        public string LowerBreachScaleIncrement
        {
            get { return this.lowerBreachScaleIncrementField ; }
            set { this.lowerBreachScaleIncrementField= value; }
        }

        /// <summary>
        /// Sets the LowerBreachScaleIncrement property
        /// </summary>
        /// <param name="lowerBreachScaleIncrement">The incremental amount to use when performing scaling activities when the lower threshold has been breached.
        /// Must be a positive or negative integer followed by a % sign. If you specify only a positive or negative number,
        /// then the AutoScalingGroup increases or decreases by the specified number of actual instances. If you specify a
        /// positive or negative number with a percent sign, the AutoScaling group increases or decreases by the specified
        /// percentage.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithLowerBreachScaleIncrement(string lowerBreachScaleIncrement)
        {
            this.lowerBreachScaleIncrementField = lowerBreachScaleIncrement;
            return this;
        }

        /// <summary>
        /// Checks if LowerBreachScaleIncrement property is set
        /// </summary>
        /// <returns>true if LowerBreachScaleIncrement property is set</returns>
        public bool IsSetLowerBreachScaleIncrement()
        {
            return  this.lowerBreachScaleIncrementField != null;
        }

        /// <summary>
        /// Gets and sets the UpperThreshold property.
        /// The upper limit for the metric. If all datapoints in the last BreachDuration seconds exceed the upper threshold
        /// or fall below the lower threshold, the trigger activates.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpperThreshold")]
        public Double UpperThreshold
        {
            get { return this.upperThresholdField.GetValueOrDefault() ; }
            set { this.upperThresholdField= value; }
        }

        /// <summary>
        /// Sets the UpperThreshold property
        /// </summary>
        /// <param name="upperThreshold">The upper limit for the metric. If all datapoints in the last BreachDuration seconds exceed the upper threshold
        /// or fall below the lower threshold, the trigger activates.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithUpperThreshold(Double upperThreshold)
        {
            this.upperThresholdField = upperThreshold;
            return this;
        }

        /// <summary>
        /// Checks if UpperThreshold property is set
        /// </summary>
        /// <returns>true if UpperThreshold property is set</returns>
        public bool IsSetUpperThreshold()
        {
            return  this.upperThresholdField.HasValue;
        }

        /// <summary>
        /// Gets and sets the UpperBreachScaleIncrement property.
        /// The incremental amount to use when performing scaling activities when the upper threshold has been breached.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpperBreachScaleIncrement")]
        public string UpperBreachScaleIncrement
        {
            get { return this.upperBreachScaleIncrementField ; }
            set { this.upperBreachScaleIncrementField= value; }
        }

        /// <summary>
        /// Sets the UpperBreachScaleIncrement property
        /// </summary>
        /// <param name="upperBreachScaleIncrement">The incremental amount to use when performing scaling activities when the upper threshold has been breached.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithUpperBreachScaleIncrement(string upperBreachScaleIncrement)
        {
            this.upperBreachScaleIncrementField = upperBreachScaleIncrement;
            return this;
        }

        /// <summary>
        /// Checks if UpperBreachScaleIncrement property is set
        /// </summary>
        /// <returns>true if UpperBreachScaleIncrement property is set</returns>
        public bool IsSetUpperBreachScaleIncrement()
        {
            return  this.upperBreachScaleIncrementField != null;
        }

        /// <summary>
        /// Gets and sets the BreachDuration property.
        /// The amount of time in seconds used to evaluate and determine if a breach is occurring. The service will look at
        /// data between the current time and the number of seconds specified in this parameter to see if a breach has occurred.
        /// Must be a multiple of 60.
        /// </summary>
        [XmlElementAttribute(ElementName = "BreachDuration")]
        public Decimal BreachDuration
        {
            get { return this.breachDurationField.GetValueOrDefault() ; }
            set { this.breachDurationField= value; }
        }

        /// <summary>
        /// Sets the BreachDuration property
        /// </summary>
        /// <param name="breachDuration">The amount of time in seconds used to evaluate and determine if a breach is occurring. The service will look at
        /// data between the current time and the number of seconds specified in this parameter to see if a breach has occurred.
        /// Must be a multiple of 60.</param>
        /// <returns>this instance</returns>
        public CreateOrUpdateScalingTriggerRequest WithBreachDuration(Decimal breachDuration)
        {
            this.breachDurationField = breachDuration;
            return this;
        }

        /// <summary>
        /// Checks if BreachDuration property is set
        /// </summary>
        /// <returns>true if BreachDuration property is set</returns>
        public bool IsSetBreachDuration()
        {
            return  this.breachDurationField.HasValue;
        }

    }
}
