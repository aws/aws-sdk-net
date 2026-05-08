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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// The status of an MPA session.
    /// </summary>
    public partial class MpaStatus
    {
        private DateTime? _initiationDate;
        private string _mpaSessionArn;
        private SessionStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date and time when the MPA session was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? InitiationDate
        {
            get { return this._initiationDate; }
            set { this._initiationDate = value; }
        }

        // Check to see if InitiationDate property is set
        internal bool IsSetInitiationDate()
        {
            return this._initiationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MpaSessionArn. 
        /// <para>
        /// The ARN of the MPA session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string MpaSessionArn
        {
            get { return this._mpaSessionArn; }
            set { this._mpaSessionArn = value; }
        }

        // Check to see if MpaSessionArn property is set
        internal bool IsSetMpaSessionArn()
        {
            return this._mpaSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the MPA session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message providing additional information about the MPA session status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}