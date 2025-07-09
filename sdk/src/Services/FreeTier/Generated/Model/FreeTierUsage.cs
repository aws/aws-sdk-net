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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
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
namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// Consists of a Amazon Web Services Free Tier offer’s metadata and your data usage for
    /// the offer.
    /// </summary>
    public partial class FreeTierUsage
    {
        private double? _actualUsageAmount;
        private string _description;
        private double? _forecastedUsageAmount;
        private string _freeTierType;
        private double? _limit;
        private string _operation;
        private string _region;
        private string _service;
        private string _unit;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property ActualUsageAmount. 
        /// <para>
        /// Describes the actual usage accrued month-to-day (MTD) that you've used so far.
        /// </para>
        /// </summary>
        public double? ActualUsageAmount
        {
            get { return this._actualUsageAmount; }
            set { this._actualUsageAmount = value; }
        }

        // Check to see if ActualUsageAmount property is set
        internal bool IsSetActualUsageAmount()
        {
            return this._actualUsageAmount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Free Tier offer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastedUsageAmount. 
        /// <para>
        /// Describes the forecasted usage by the month that you're expected to use.
        /// </para>
        /// </summary>
        public double? ForecastedUsageAmount
        {
            get { return this._forecastedUsageAmount; }
            set { this._forecastedUsageAmount = value; }
        }

        // Check to see if ForecastedUsageAmount property is set
        internal bool IsSetForecastedUsageAmount()
        {
            return this._forecastedUsageAmount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FreeTierType. 
        /// <para>
        /// Describes the type of the Free Tier offer. For example, the offer can be <c>"12 Months
        /// Free"</c>, <c>"Always Free"</c>, and <c>"Free Trial"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FreeTierType
        {
            get { return this._freeTierType; }
            set { this._freeTierType = value; }
        }

        // Check to see if FreeTierType property is set
        internal bool IsSetFreeTierType()
        {
            return this._freeTierType != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Describes the maximum usage allowed in Free Tier.
        /// </para>
        /// </summary>
        public double? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Describes <c>usageType</c> more granularly with the specific Amazon Web Services service
        /// API operation. For example, this can be the <c>RunInstances</c> API operation for
        /// Amazon Elastic Compute Cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// Describes the Amazon Web Services Region for which this offer is applicable
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// The name of the Amazon Web Services service providing the Free Tier offer. For example,
        /// this can be Amazon Elastic Compute Cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Describes the unit of the <c>usageType</c>, such as <c>Hrs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        /// Describes the usage details of the offer. For example, this might be <c>Global-BoxUsage:freetrial</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string UsageType
        {
            get { return this._usageType; }
            set { this._usageType = value; }
        }

        // Check to see if UsageType property is set
        internal bool IsSetUsageType()
        {
            return this._usageType != null;
        }

    }
}