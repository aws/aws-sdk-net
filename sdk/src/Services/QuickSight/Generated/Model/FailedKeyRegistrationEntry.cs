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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An entry that appears when a <c>KeyRegistration</c> update to QuickSight fails.
    /// </summary>
    public partial class FailedKeyRegistrationEntry
    {
        private string _keyArn;
        private string _message;
        private bool? _senderFault;
        private int? _statusCode;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The ARN of the KMS key that failed to update.
        /// </para>
        /// </summary>
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that provides information about why a <c>FailedKeyRegistrationEntry</c>
        /// error occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SenderFault. 
        /// <para>
        /// A boolean that indicates whether a <c>FailedKeyRegistrationEntry</c> resulted from
        /// user error. If the value of this property is <c>True</c>, the error was caused by
        /// user error. If the value of this property is <c>False</c>, the error occurred on the
        /// backend. If your job continues fail and with a <c>False</c> <c>SenderFault</c> value,
        /// contact Amazon Web Services Support.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? SenderFault
        {
            get { return this._senderFault; }
            set { this._senderFault = value; }
        }

        // Check to see if SenderFault property is set
        internal bool IsSetSenderFault()
        {
            return this._senderFault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The HTTP status of a <c>FailedKeyRegistrationEntry</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

    }
}