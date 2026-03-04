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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Summary information about an email address associated with a queue. Contains the essential
    /// details needed to identify and manage the email address routing configuration.
    /// </summary>
    public partial class EmailAddressSummary
    {
        private string _arn;
        private string _id;
        private bool? _isDefaultOutboundEmail;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the email address associated with the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the email address associated with the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IsDefaultOutboundEmail. 
        /// <para>
        /// Indicates whether this email address is configured as the default outbound email address
        /// for the queue. When set to true, this email address is used as the default sender
        /// for outbound email contacts from this queue.
        /// </para>
        /// </summary>
        public bool IsDefaultOutboundEmail
        {
            get { return this._isDefaultOutboundEmail.GetValueOrDefault(); }
            set { this._isDefaultOutboundEmail = value; }
        }

        // Check to see if IsDefaultOutboundEmail property is set
        internal bool IsSetIsDefaultOutboundEmail()
        {
            return this._isDefaultOutboundEmail.HasValue; 
        }

    }
}