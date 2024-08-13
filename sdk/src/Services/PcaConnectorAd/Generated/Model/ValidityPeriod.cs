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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Information describing the end of the validity period of the certificate. This parameter
    /// sets the “Not After” date for the certificate. Certificate validity is the period
    /// of time during which a certificate is valid. Validity can be expressed as an explicit
    /// date and time when the certificate expires, or as a span of time after issuance, stated
    /// in hours, days, months, or years. For more information, see Validity in RFC 5280.
    /// This value is unaffected when ValidityNotBefore is also specified. For example, if
    /// Validity is set to 20 days in the future, the certificate will expire 20 days from
    /// issuance time regardless of the ValidityNotBefore value.
    /// </summary>
    public partial class ValidityPeriod
    {
        private long? _period;
        private ValidityPeriodType _periodType;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The numeric value for the validity period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8766000)]
        public long? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeriodType. 
        /// <para>
        /// The unit of time. You can select hours, days, weeks, months, and years.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidityPeriodType PeriodType
        {
            get { return this._periodType; }
            set { this._periodType = value; }
        }

        // Check to see if PeriodType property is set
        internal bool IsSetPeriodType()
        {
            return this._periodType != null;
        }

    }
}