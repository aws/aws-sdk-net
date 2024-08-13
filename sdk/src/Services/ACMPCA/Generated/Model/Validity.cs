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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Validity specifies the period of time during which a certificate is valid. Validity
    /// can be expressed as an explicit date and time when the validity of a certificate starts
    /// or expires, or as a span of time after issuance, stated in days, months, or years.
    /// For more information, see <a href="https://tools.ietf.org/html/rfc5280#section-4.1.2.5">Validity</a>
    /// in RFC 5280.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services Private CA API consumes the <c>Validity</c> data type differently
    /// in two distinct parameters of the <c>IssueCertificate</c> action. The required parameter
    /// <c>IssueCertificate</c>:<c>Validity</c> specifies the end of a certificate's validity
    /// period. The optional parameter <c>IssueCertificate</c>:<c>ValidityNotBefore</c> specifies
    /// a customized starting time for the validity period.
    /// </para>
    /// </summary>
    public partial class Validity
    {
        private ValidityPeriodType _type;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Determines how <i>Amazon Web Services Private CA</i> interprets the <c>Value</c> parameter,
        /// an integer. Supported validity types include those listed below. Type definitions
        /// with values include a sample input value and the resulting output. 
        /// </para>
        ///  
        /// <para>
        ///  <c>END_DATE</c>: The specific date and time when the certificate will expire, expressed
        /// using UTCTime (YYMMDDHHMMSS) or GeneralizedTime (YYYYMMDDHHMMSS) format. When UTCTime
        /// is used, if the year field (YY) is greater than or equal to 50, the year is interpreted
        /// as 19YY. If the year field is less than 50, the year is interpreted as 20YY.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sample input value: 491231235959 (UTCTime format)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Output expiration date/time: 12/31/2049 23:59:59
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>ABSOLUTE</c>: The specific date and time when the validity of a certificate will
        /// start or expire, expressed in seconds since the Unix Epoch. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sample input value: 2524608000
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Output expiration date/time: 01/01/2050 00:00:00
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>DAYS</c>, <c>MONTHS</c>, <c>YEARS</c>: The relative time from the moment of issuance
        /// until the certificate will expire, expressed in days, months, or years. 
        /// </para>
        ///  
        /// <para>
        /// Example if <c>DAYS</c>, issued on 10/12/2020 at 12:34:54 UTC:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sample input value: 90
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Output expiration date: 01/10/2020 12:34:54 UTC
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The minimum validity duration for a certificate using relative time (<c>DAYS</c>)
        /// is one day. The minimum validity for a certificate using absolute time (<c>ABSOLUTE</c>
        /// or <c>END_DATE</c>) is one second.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidityPeriodType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A long integer interpreted according to the value of <c>Type</c>, below.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}