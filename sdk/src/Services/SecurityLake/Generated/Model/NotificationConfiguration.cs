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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Specify the configurations you want to use for subscriber notification to notify the
    /// subscriber when new data is written to the data lake for sources that the subscriber
    /// consumes in Security Lake.
    /// </summary>
    public partial class NotificationConfiguration
    {
        private HttpsNotificationConfiguration _httpsNotificationConfiguration;
        private SqsNotificationConfiguration _sqsNotificationConfiguration;

        /// <summary>
        /// Gets and sets the property HttpsNotificationConfiguration. 
        /// <para>
        /// The configurations used for HTTPS subscriber notification.
        /// </para>
        /// </summary>
        public HttpsNotificationConfiguration HttpsNotificationConfiguration
        {
            get { return this._httpsNotificationConfiguration; }
            set { this._httpsNotificationConfiguration = value; }
        }

        // Check to see if HttpsNotificationConfiguration property is set
        internal bool IsSetHttpsNotificationConfiguration()
        {
            return this._httpsNotificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqsNotificationConfiguration. 
        /// <para>
        /// The configurations for SQS subscriber notification.
        /// </para>
        /// </summary>
        public SqsNotificationConfiguration SqsNotificationConfiguration
        {
            get { return this._sqsNotificationConfiguration; }
            set { this._sqsNotificationConfiguration = value; }
        }

        // Check to see if SqsNotificationConfiguration property is set
        internal bool IsSetSqsNotificationConfiguration()
        {
            return this._sqsNotificationConfiguration != null;
        }

    }
}