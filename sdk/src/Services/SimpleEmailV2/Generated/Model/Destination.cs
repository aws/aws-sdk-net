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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that describes the recipients for an email.
    /// </summary>
    public partial class Destination
    {
        private List<string> _bccAddresses = new List<string>();
        private List<string> _ccAddresses = new List<string>();
        private List<string> _toAddresses = new List<string>();

        /// <summary>
        /// Gets and sets the property BccAddresses. 
        /// <para>
        /// An array that contains the email addresses of the "BCC" (blind carbon copy) recipients
        /// for the email.
        /// </para>
        /// </summary>
        public List<string> BccAddresses
        {
            get { return this._bccAddresses; }
            set { this._bccAddresses = value; }
        }

        // Check to see if BccAddresses property is set
        internal bool IsSetBccAddresses()
        {
            return this._bccAddresses != null && this._bccAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CcAddresses. 
        /// <para>
        /// An array that contains the email addresses of the "CC" (carbon copy) recipients for
        /// the email.
        /// </para>
        /// </summary>
        public List<string> CcAddresses
        {
            get { return this._ccAddresses; }
            set { this._ccAddresses = value; }
        }

        // Check to see if CcAddresses property is set
        internal bool IsSetCcAddresses()
        {
            return this._ccAddresses != null && this._ccAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ToAddresses. 
        /// <para>
        /// An array that contains the email addresses of the "To" recipients for the email.
        /// </para>
        /// </summary>
        public List<string> ToAddresses
        {
            get { return this._toAddresses; }
            set { this._toAddresses = value; }
        }

        // Check to see if ToAddresses property is set
        internal bool IsSetToAddresses()
        {
            return this._toAddresses != null && this._toAddresses.Count > 0; 
        }

    }
}