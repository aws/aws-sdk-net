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
    /// Describes a recurring charge.
    /// </summary>
    public partial class RecurringCharge
    {
        private double? _amount;
        private RecurringChargeFrequency _frequency;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The amount of the recurring charge.
        /// </para>
        /// </summary>
        public double? Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The frequency of the recurring charge.
        /// </para>
        /// </summary>
        public RecurringChargeFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency != null;
        }

    }
}