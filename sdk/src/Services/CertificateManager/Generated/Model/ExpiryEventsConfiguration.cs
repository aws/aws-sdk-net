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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Object containing expiration events options associated with an Amazon Web Services
    /// account.
    /// </summary>
    public partial class ExpiryEventsConfiguration
    {
        private int? _daysBeforeExpiry;

        /// <summary>
        /// Gets and sets the property DaysBeforeExpiry. 
        /// <para>
        /// Specifies the number of days prior to certificate expiration when ACM starts generating
        /// <c>EventBridge</c> events. ACM sends one event per day per certificate until the certificate
        /// expires. By default, accounts receive events starting 45 days before certificate expiration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? DaysBeforeExpiry
        {
            get { return this._daysBeforeExpiry; }
            set { this._daysBeforeExpiry = value; }
        }

        // Check to see if DaysBeforeExpiry property is set
        internal bool IsSetDaysBeforeExpiry()
        {
            return this._daysBeforeExpiry.HasValue; 
        }

    }
}