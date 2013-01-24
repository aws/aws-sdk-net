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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the DescribeReservedCacheNodes and DescribeReservedCacheNodesOfferings actions.
    /// </para>
    /// </summary>
    public class RecurringCharge
    {
        
        private double? recurringChargeAmount;
        private string recurringChargeFrequency;

        /// <summary>
        /// The amount of the recurring charge.
        ///  
        /// </summary>
        public double RecurringChargeAmount
        {
            get { return this.recurringChargeAmount ?? default(double); }
            set { this.recurringChargeAmount = value; }
        }

        /// <summary>
        /// Sets the RecurringChargeAmount property
        /// </summary>
        /// <param name="recurringChargeAmount">The value to set for the RecurringChargeAmount property </param>
        /// <returns>this instance</returns>
        public RecurringCharge WithRecurringChargeAmount(double recurringChargeAmount)
        {
            this.recurringChargeAmount = recurringChargeAmount;
            return this;
        }
            

        // Check to see if RecurringChargeAmount property is set
        internal bool IsSetRecurringChargeAmount()
        {
            return this.recurringChargeAmount.HasValue;
        }

        /// <summary>
        /// The frequency of the recurring charge.
        ///  
        /// </summary>
        public string RecurringChargeFrequency
        {
            get { return this.recurringChargeFrequency; }
            set { this.recurringChargeFrequency = value; }
        }

        /// <summary>
        /// Sets the RecurringChargeFrequency property
        /// </summary>
        /// <param name="recurringChargeFrequency">The value to set for the RecurringChargeFrequency property </param>
        /// <returns>this instance</returns>
        public RecurringCharge WithRecurringChargeFrequency(string recurringChargeFrequency)
        {
            this.recurringChargeFrequency = recurringChargeFrequency;
            return this;
        }
            

        // Check to see if RecurringChargeFrequency property is set
        internal bool IsSetRecurringChargeFrequency()
        {
            return this.recurringChargeFrequency != null;
        }
    }
}
