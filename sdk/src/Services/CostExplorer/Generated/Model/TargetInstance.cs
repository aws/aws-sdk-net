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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Details on recommended instance.
    /// </summary>
    public partial class TargetInstance
    {
        private string _currencyCode;
        private bool? _defaultTargetInstance;
        private string _estimatedMonthlyCost;
        private string _estimatedMonthlySavings;
        private ResourceUtilization _expectedResourceUtilization;
        private ResourceDetails _resourceDetails;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The currency code that AWS used to calculate the costs for this instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultTargetInstance. 
        /// <para>
        ///  Indicates whether this recommendation is the defaulted AWS recommendation.
        /// </para>
        /// </summary>
        public bool DefaultTargetInstance
        {
            get { return this._defaultTargetInstance.GetValueOrDefault(); }
            set { this._defaultTargetInstance = value; }
        }

        // Check to see if DefaultTargetInstance property is set
        internal bool IsSetDefaultTargetInstance()
        {
            return this._defaultTargetInstance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlyCost. 
        /// <para>
        ///  Expected cost to operate this instance type on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedMonthlyCost
        {
            get { return this._estimatedMonthlyCost; }
            set { this._estimatedMonthlyCost = value; }
        }

        // Check to see if EstimatedMonthlyCost property is set
        internal bool IsSetEstimatedMonthlyCost()
        {
            return this._estimatedMonthlyCost != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        ///  Estimated savings resulting from modification, on a monthly basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedResourceUtilization. 
        /// <para>
        ///  Expected utilization metrics for target instance type.
        /// </para>
        /// </summary>
        public ResourceUtilization ExpectedResourceUtilization
        {
            get { return this._expectedResourceUtilization; }
            set { this._expectedResourceUtilization = value; }
        }

        // Check to see if ExpectedResourceUtilization property is set
        internal bool IsSetExpectedResourceUtilization()
        {
            return this._expectedResourceUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceDetails. 
        /// <para>
        ///  Details on the target instance type. 
        /// </para>
        /// </summary>
        public ResourceDetails ResourceDetails
        {
            get { return this._resourceDetails; }
            set { this._resourceDetails = value; }
        }

        // Check to see if ResourceDetails property is set
        internal bool IsSetResourceDetails()
        {
            return this._resourceDetails != null;
        }

    }
}