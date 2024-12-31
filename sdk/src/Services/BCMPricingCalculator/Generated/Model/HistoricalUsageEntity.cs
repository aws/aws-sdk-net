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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// Represents historical usage data for a specific entity.
    /// </summary>
    public partial class HistoricalUsageEntity
    {
        private BillInterval _billInterval;
        private Expression _filterExpression;
        private string _location;
        private string _operation;
        private string _serviceCode;
        private string _usageAccountId;
        private string _usageType;

        /// <summary>
        /// Gets and sets the property BillInterval. 
        /// <para>
        ///  The time interval for the historical usage data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillInterval BillInterval
        {
            get { return this._billInterval; }
            set { this._billInterval = value; }
        }

        // Check to see if BillInterval property is set
        internal bool IsSetBillInterval()
        {
            return this._billInterval != null;
        }

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        ///  An optional filter expression to apply to the historical usage data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Expression FilterExpression
        {
            get { return this._filterExpression; }
            set { this._filterExpression = value; }
        }

        // Check to see if FilterExpression property is set
        internal bool IsSetFilterExpression()
        {
            return this._filterExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        ///  The location associated with the usage. 
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        ///  The specific operation associated with the usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
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
        /// Gets and sets the property ServiceCode. 
        /// <para>
        ///  The Amazon Web Services service code associated with the usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

        /// <summary>
        /// Gets and sets the property UsageAccountId. 
        /// <para>
        ///  The Amazon Web Services account ID associated with the usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string UsageAccountId
        {
            get { return this._usageAccountId; }
            set { this._usageAccountId = value; }
        }

        // Check to see if UsageAccountId property is set
        internal bool IsSetUsageAccountId()
        {
            return this._usageAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property UsageType. 
        /// <para>
        ///  The type of usage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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