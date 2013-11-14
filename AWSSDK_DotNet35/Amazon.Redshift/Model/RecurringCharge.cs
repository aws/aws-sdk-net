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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a recurring charge.</para>
    /// </summary>
    public class RecurringCharge
    {
        
        private double? recurringChargeAmount;
        private string recurringChargeFrequency;


        /// <summary>
        /// The amount charged per the period of time specified by the recurring charge frequency.
        ///  
        /// </summary>
        public double RecurringChargeAmount
        {
            get { return this.recurringChargeAmount ?? default(double); }
            set { this.recurringChargeAmount = value; }
        }

        // Check to see if RecurringChargeAmount property is set
        internal bool IsSetRecurringChargeAmount()
        {
            return this.recurringChargeAmount.HasValue;
        }

        /// <summary>
        /// The frequency at which the recurring charge amount is applied.
        ///  
        /// </summary>
        public string RecurringChargeFrequency
        {
            get { return this.recurringChargeFrequency; }
            set { this.recurringChargeFrequency = value; }
        }

        // Check to see if RecurringChargeFrequency property is set
        internal bool IsSetRecurringChargeFrequency()
        {
            return this.recurringChargeFrequency != null;
        }
    }
}
