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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Represents an amount of money in United States dollars.
    /// </summary>
    public partial class USD
    {
        private int? _cents;
        private int? _dollars;
        private int? _tenthFractionsOfACent;

        /// <summary>
        /// Gets and sets the property Cents. 
        /// <para>
        /// The fractional portion, in cents, of the amount. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=99)]
        public int? Cents
        {
            get { return this._cents; }
            set { this._cents = value; }
        }

        // Check to see if Cents property is set
        internal bool IsSetCents()
        {
            return this._cents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Dollars. 
        /// <para>
        /// The whole number of dollars in the amount.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int? Dollars
        {
            get { return this._dollars; }
            set { this._dollars = value; }
        }

        // Check to see if Dollars property is set
        internal bool IsSetDollars()
        {
            return this._dollars.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TenthFractionsOfACent. 
        /// <para>
        /// Fractions of a cent, in tenths.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9)]
        public int? TenthFractionsOfACent
        {
            get { return this._tenthFractionsOfACent; }
            set { this._tenthFractionsOfACent = value; }
        }

        // Check to see if TenthFractionsOfACent property is set
        internal bool IsSetTenthFractionsOfACent()
        {
            return this._tenthFractionsOfACent.HasValue; 
        }

    }
}