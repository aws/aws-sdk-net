/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Message-related information to include in the Delivery Status Notification (DSN) when
    /// an email that Amazon SES receives on your behalf bounces.
    /// 
    ///  
    /// <para>
    /// For information about receiving email through Amazon SES, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class MessageDsn
    {
        private DateTime? _arrivalDateUtc;
        private List<ExtensionField> _extensionFields = new List<ExtensionField>();
        private string _reportingMta;

        /// <summary>
        /// Gets and sets the property ArrivalDateUtc. 
        /// <para>
        /// When the message was received by the reporting mail transfer agent (MTA), in <a href="https://www.ietf.org/rfc/rfc0822.txt">RFC
        /// 822</a> date-time format.
        /// </para>
        /// </summary>
        public DateTime ArrivalDateUtc
        {
            get { return this._arrivalDateUtc.GetValueOrDefault(); }
            set { this._arrivalDate = this._arrivalDateUtc = value; }
        }

        // Check to see if ArrivalDateUtc property is set
        internal bool IsSetArrivalDateUtc()
        {
            return this._arrivalDateUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtensionFields. 
        /// <para>
        /// Additional X-headers to include in the DSN.
        /// </para>
        /// </summary>
        public List<ExtensionField> ExtensionFields
        {
            get { return this._extensionFields; }
            set { this._extensionFields = value; }
        }

        // Check to see if ExtensionFields property is set
        internal bool IsSetExtensionFields()
        {
            return this._extensionFields != null && this._extensionFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReportingMta. 
        /// <para>
        /// The reporting MTA that attempted to deliver the message, formatted as specified in
        /// <a href="https://tools.ietf.org/html/rfc3464">RFC 3464</a> (<code>mta-name-type; mta-name</code>).
        /// The default value is <code>dns; inbound-smtp.[region].amazonaws.com</code>.
        /// </para>
        /// </summary>
        public string ReportingMta
        {
            get { return this._reportingMta; }
            set { this._reportingMta = value; }
        }

        // Check to see if ReportingMta property is set
        internal bool IsSetReportingMta()
        {
            return this._reportingMta != null;
        }

#region Backwards compatible properties
        private DateTime? _arrivalDate;

        /// <summary>
        /// Gets and sets the property ArrivalDateUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ArrivalDateUtc instead. Setting either ArrivalDate
        /// or ArrivalDateUtc results in both ArrivalDate and ArrivalDateUtc being assigned, the
        /// latest assignment to either one of the two property is reflected in the value of both.
        /// ArrivalDate is provided for backwards compatibility only and assigning a non-Utc DateTime
        /// to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// When the message was received by the reporting mail transfer agent (MTA), in <a href="https://www.ietf.org/rfc/rfc0822.txt">RFC
        /// 822</a> date-time format.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ArrivalDateUtc instead. Setting either ArrivalDate or ArrivalDateUtc results in both ArrivalDate and " +
            "ArrivalDateUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ArrivalDate is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ArrivalDate
        {
            get { return this._arrivalDate.GetValueOrDefault(); }
            set
            {
                this._arrivalDate = value;
                this._arrivalDateUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}