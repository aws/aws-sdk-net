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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Message-related information to include in the Delivery Status Notification (DSN) when
    /// an email that Amazon SES receives on your behalf bounces.
    /// 
    ///  
    /// <para>
    /// For information about receiving email through Amazon SES, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class MessageDsn
    {
        private DateTime? _arrivalDate;
        private List<ExtensionField> _extensionFields = AWSConfigs.InitializeCollections ? new List<ExtensionField>() : null;
        private string _reportingMta;

        /// <summary>
        /// Gets and sets the property ArrivalDate. 
        /// <para>
        /// When the message was received by the reporting mail transfer agent (MTA), in <a href="https://www.ietf.org/rfc/rfc0822.txt">RFC
        /// 822</a> date-time format.
        /// </para>
        /// </summary>
        public DateTime? ArrivalDate
        {
            get { return this._arrivalDate; }
            set { this._arrivalDate = value; }
        }

        // Check to see if ArrivalDate property is set
        internal bool IsSetArrivalDate()
        {
            return this._arrivalDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtensionFields. 
        /// <para>
        /// Additional X-headers to include in the DSN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExtensionField> ExtensionFields
        {
            get { return this._extensionFields; }
            set { this._extensionFields = value; }
        }

        // Check to see if ExtensionFields property is set
        internal bool IsSetExtensionFields()
        {
            return this._extensionFields != null && (this._extensionFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportingMta. 
        /// <para>
        /// The reporting MTA that attempted to deliver the message, formatted as specified in
        /// <a href="https://tools.ietf.org/html/rfc3464">RFC 3464</a> (<c>mta-name-type; mta-name</c>).
        /// The default value is <c>dns; inbound-smtp.[region].amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}