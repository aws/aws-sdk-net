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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Information about the quota period.
    /// </summary>
    public partial class QuotaPeriod
    {
        private PeriodUnit _periodUnit;
        private int? _periodValue;

        /// <summary>
        /// Gets and sets the property PeriodUnit. 
        /// <para>
        /// The time unit.
        /// </para>
        /// </summary>
        public PeriodUnit PeriodUnit
        {
            get { return this._periodUnit; }
            set { this._periodUnit = value; }
        }

        // Check to see if PeriodUnit property is set
        internal bool IsSetPeriodUnit()
        {
            return this._periodUnit != null;
        }

        /// <summary>
        /// Gets and sets the property PeriodValue. 
        /// <para>
        /// The value associated with the reported <c>PeriodUnit</c>.
        /// </para>
        /// </summary>
        public int? PeriodValue
        {
            get { return this._periodValue; }
            set { this._periodValue = value; }
        }

        // Check to see if PeriodValue property is set
        internal bool IsSetPeriodValue()
        {
            return this._periodValue.HasValue; 
        }

    }
}