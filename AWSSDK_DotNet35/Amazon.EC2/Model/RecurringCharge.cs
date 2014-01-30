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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a recurring charge.</para>
    /// </summary>
    public class RecurringCharge
    {
        
        private RecurringChargeFrequency frequency;
        private double? amount;


        /// <summary>
        /// The frequency of the recurring charge.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Hourly</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RecurringChargeFrequency Frequency
        {
            get { return this.frequency; }
            set { this.frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this.frequency != null;
        }

        /// <summary>
        /// The amount of the recurring charge.
        ///  
        /// </summary>
        public double Amount
        {
            get { return this.amount ?? default(double); }
            set { this.amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this.amount.HasValue;
        }
    }
}
