/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The frequency and the amount of recurring charges.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class RecurringCharges
    {
        private string frequencyField;
        private Decimal? amountField;

        /// <summary>
        /// The frequency of the recurring charge. 
        /// 
        /// Valid values: Hourly, Monthly.
        /// </summary>
        [XmlElementAttribute(ElementName = "Frequency")]
        public string Frequency
        {
            get { return this.frequencyField; }
            set { this.frequencyField = value; }
        }

        /// <summary>
        /// Checks if Frequency property is set
        /// </summary>
        /// <returns>true if Frequency property is set</returns>
        public bool IsSetFrequency()
        {
            return this.frequencyField != null;
        }

        /// <summary>
        /// The amount of the recurring charge.
        /// </summary>
        [XmlElementAttribute(ElementName = "Amount")]
        public Decimal Amount
        {
            get { return this.amountField.GetValueOrDefault(); }
            set { this.amountField = value; }
        }

        /// <summary>
        /// Checks if Amount property is set
        /// </summary>
        /// <returns>true if Amount property is set</returns>
        public bool IsSetAmount()
        {
            return this.amountField.HasValue;
        }
    }
}
