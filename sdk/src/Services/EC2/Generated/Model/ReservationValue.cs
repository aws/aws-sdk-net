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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The cost associated with the Reserved Instance.
    /// </summary>
    public partial class ReservationValue
    {
        private string _hourlyPrice;
        private string _remainingTotalValue;
        private string _remainingUpfrontValue;

        /// <summary>
        /// Gets and sets the property HourlyPrice. 
        /// <para>
        /// The hourly rate of the reservation.
        /// </para>
        /// </summary>
        public string HourlyPrice
        {
            get { return this._hourlyPrice; }
            set { this._hourlyPrice = value; }
        }

        // Check to see if HourlyPrice property is set
        internal bool IsSetHourlyPrice()
        {
            return this._hourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property RemainingTotalValue. 
        /// <para>
        /// The balance of the total value (the sum of remainingUpfrontValue + hourlyPrice * number
        /// of hours remaining).
        /// </para>
        /// </summary>
        public string RemainingTotalValue
        {
            get { return this._remainingTotalValue; }
            set { this._remainingTotalValue = value; }
        }

        // Check to see if RemainingTotalValue property is set
        internal bool IsSetRemainingTotalValue()
        {
            return this._remainingTotalValue != null;
        }

        /// <summary>
        /// Gets and sets the property RemainingUpfrontValue. 
        /// <para>
        /// The remaining upfront cost of the reservation.
        /// </para>
        /// </summary>
        public string RemainingUpfrontValue
        {
            get { return this._remainingUpfrontValue; }
            set { this._remainingUpfrontValue = value; }
        }

        // Check to see if RemainingUpfrontValue property is set
        internal bool IsSetRemainingUpfrontValue()
        {
            return this._remainingUpfrontValue != null;
        }

    }
}