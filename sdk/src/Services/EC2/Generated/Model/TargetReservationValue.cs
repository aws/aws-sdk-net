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
    /// The total value of the new Convertible Reserved Instances.
    /// </summary>
    public partial class TargetReservationValue
    {
        private ReservationValue _reservationValue;
        private TargetConfiguration _targetConfiguration;

        /// <summary>
        /// Gets and sets the property ReservationValue. 
        /// <para>
        /// The total value of the Convertible Reserved Instances that make up the exchange. This
        /// is the sum of the list value, remaining upfront price, and additional upfront cost
        /// of the exchange.
        /// </para>
        /// </summary>
        public ReservationValue ReservationValue
        {
            get { return this._reservationValue; }
            set { this._reservationValue = value; }
        }

        // Check to see if ReservationValue property is set
        internal bool IsSetReservationValue()
        {
            return this._reservationValue != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// The configuration of the Convertible Reserved Instances that make up the exchange.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

    }
}