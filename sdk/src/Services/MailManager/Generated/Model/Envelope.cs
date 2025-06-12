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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The SMTP envelope information of the email.
    /// </summary>
    public partial class Envelope
    {
        private string _from;
        private string _helo;
        private List<string> _to = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The RCPT FROM given by the host from which the email was received.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property Helo. 
        /// <para>
        /// The HELO used by the host from which the email was received.
        /// </para>
        /// </summary>
        public string Helo
        {
            get { return this._helo; }
            set { this._helo = value; }
        }

        // Check to see if Helo property is set
        internal bool IsSetHelo()
        {
            return this._helo != null;
        }

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// All SMTP TO entries given by the host from which the email was received.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null && (this._to.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}