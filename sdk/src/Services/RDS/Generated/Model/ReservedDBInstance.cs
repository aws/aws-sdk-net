/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element in the <a>DescribeReservedDBInstances</a>
    /// and <a>PurchaseReservedDBInstancesOffering</a> actions.
    /// </summary>
    public partial class ReservedDBInstance
    {
        private string _currencyCode;
        private string _dbInstanceClass;
        private int? _dbInstanceCount;
        private int? _duration;
        private double? _fixedPrice;
        private bool? _multiAZ;
        private string _offeringType;
        private string _productDescription;
        private List<RecurringCharge> _recurringCharges = new List<RecurringCharge>();
        private string _reservedDBInstanceId;
        private string _reservedDBInstancesOfferingId;
        private DateTime? _startTime;
        private string _state;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The currency code for the reserved DB instance. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  The DB instance class for the reserved DB instance. 
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBInstanceCount. 
        /// <para>
        ///  The number of reserved DB instances. 
        /// </para>
        /// </summary>
        public int DBInstanceCount
        {
            get { return this._dbInstanceCount.GetValueOrDefault(); }
            set { this._dbInstanceCount = value; }
        }

        // Check to see if DBInstanceCount property is set
        internal bool IsSetDBInstanceCount()
        {
            return this._dbInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The duration of the reservation in seconds. 
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        ///  The fixed price charged for this reserved DB instance. 
        /// </para>
        /// </summary>
        public double FixedPrice
        {
            get { return this._fixedPrice.GetValueOrDefault(); }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Indicates if the reservation applies to Multi-AZ deployments. 
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        ///  The offering type of this reserved DB instance. 
        /// </para>
        /// </summary>
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        ///  The description of the reserved DB instance. 
        /// </para>
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        ///  The recurring price charged to run this reserved DB instance. 
        /// </para>
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && this._recurringCharges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedDBInstanceId. 
        /// <para>
        ///  The unique identifier for the reservation. 
        /// </para>
        /// </summary>
        public string ReservedDBInstanceId
        {
            get { return this._reservedDBInstanceId; }
            set { this._reservedDBInstanceId = value; }
        }

        // Check to see if ReservedDBInstanceId property is set
        internal bool IsSetReservedDBInstanceId()
        {
            return this._reservedDBInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedDBInstancesOfferingId. 
        /// <para>
        ///  The offering identifier. 
        /// </para>
        /// </summary>
        public string ReservedDBInstancesOfferingId
        {
            get { return this._reservedDBInstancesOfferingId; }
            set { this._reservedDBInstancesOfferingId = value; }
        }

        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this._reservedDBInstancesOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The time the reservation started. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        ///  The state of the reserved DB instance. 
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        ///  The hourly price charged for this reserved DB instance. 
        /// </para>
        /// </summary>
        public double UsagePrice
        {
            get { return this._usagePrice.GetValueOrDefault(); }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}