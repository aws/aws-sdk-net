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
    /// Receipt rules enable you to specify which actions Amazon SES should take when it receives
    /// mail on behalf of one or more email addresses or domains that you own.
    /// 
    ///  
    /// <para>
    /// Each receipt rule defines a set of email addresses or domains that it applies to.
    /// If the email addresses or domains match at least one recipient address of the message,
    /// Amazon SES executes all of the receipt rule's actions on the message.
    /// </para>
    ///  
    /// <para>
    /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptRule
    {
        private List<ReceiptAction> _actions = AWSConfigs.InitializeCollections ? new List<ReceiptAction>() : null;
        private bool? _enabled;
        private string _name;
        private List<string> _recipients = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _scanEnabled;
        private TlsPolicy _tlsPolicy;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// An ordered list of actions to perform on messages that match at least one of the recipient
        /// email addresses or domains specified in the receipt rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReceiptAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// If <c>true</c>, the receipt rule is active. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the receipt rule. The name must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), underscores (_), dashes (-),
        /// or periods (.). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start and end with a letter or number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Contain 64 characters or fewer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Recipients. 
        /// <para>
        /// The recipient domains and email addresses that the receipt rule applies to. If this
        /// field is not specified, this rule matches all recipients on all verified domains.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Recipients
        {
            get { return this._recipients; }
            set { this._recipients = value; }
        }

        // Check to see if Recipients property is set
        internal bool IsSetRecipients()
        {
            return this._recipients != null && (this._recipients.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanEnabled. 
        /// <para>
        /// If <c>true</c>, then messages that this receipt rule applies to are scanned for spam
        /// and viruses. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ScanEnabled
        {
            get { return this._scanEnabled; }
            set { this._scanEnabled = value; }
        }

        // Check to see if ScanEnabled property is set
        internal bool IsSetScanEnabled()
        {
            return this._scanEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TlsPolicy. 
        /// <para>
        /// Specifies whether Amazon SES should require that incoming email is delivered over
        /// a connection encrypted with Transport Layer Security (TLS). If this parameter is set
        /// to <c>Require</c>, Amazon SES bounces emails that are not received over TLS. The default
        /// is <c>Optional</c>.
        /// </para>
        /// </summary>
        public TlsPolicy TlsPolicy
        {
            get { return this._tlsPolicy; }
            set { this._tlsPolicy = value; }
        }

        // Check to see if TlsPolicy property is set
        internal bool IsSetTlsPolicy()
        {
            return this._tlsPolicy != null;
        }

    }
}