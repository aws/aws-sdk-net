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
    /// Container for the parameters to the UpdateAccountSendingEnabled operation.
    /// Enables or disables email sending across your entire Amazon SES account in the current
    /// AWS Region. You can use this operation in conjunction with Amazon CloudWatch alarms
    /// to temporarily pause email sending across your Amazon SES account in a given AWS Region
    /// when reputation metrics (such as your bounce or complaint rates) reach certain thresholds.
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class UpdateAccountSendingEnabledRequest : AmazonSimpleEmailServiceRequest
    {
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Describes whether email sending is enabled or disabled for your Amazon SES account
        /// in the current AWS Region.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}