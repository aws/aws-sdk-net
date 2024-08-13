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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides status of the delivery of the snapshot or the configuration history to the
    /// specified Amazon S3 bucket. Also provides the status of notifications about the Amazon
    /// S3 delivery to the specified Amazon SNS topic.
    /// </summary>
    public partial class ConfigExportDeliveryInfo
    {
        private DateTime? _lastAttemptTime;
        private string _lastErrorCode;
        private string _lastErrorMessage;
        private DeliveryStatus _lastStatus;
        private DateTime? _lastSuccessfulTime;
        private DateTime? _nextDeliveryTime;

        /// <summary>
        /// Gets and sets the property LastAttemptTime. 
        /// <para>
        /// The time of the last attempted delivery.
        /// </para>
        /// </summary>
        public DateTime? LastAttemptTime
        {
            get { return this._lastAttemptTime; }
            set { this._lastAttemptTime = value; }
        }

        // Check to see if LastAttemptTime property is set
        internal bool IsSetLastAttemptTime()
        {
            return this._lastAttemptTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The error code from the last attempted delivery.
        /// </para>
        /// </summary>
        public string LastErrorCode
        {
            get { return this._lastErrorCode; }
            set { this._lastErrorCode = value; }
        }

        // Check to see if LastErrorCode property is set
        internal bool IsSetLastErrorCode()
        {
            return this._lastErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The error message from the last attempted delivery.
        /// </para>
        /// </summary>
        public string LastErrorMessage
        {
            get { return this._lastErrorMessage; }
            set { this._lastErrorMessage = value; }
        }

        // Check to see if LastErrorMessage property is set
        internal bool IsSetLastErrorMessage()
        {
            return this._lastErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// Status of the last attempted delivery.
        /// </para>
        /// </summary>
        public DeliveryStatus LastStatus
        {
            get { return this._lastStatus; }
            set { this._lastStatus = value; }
        }

        // Check to see if LastStatus property is set
        internal bool IsSetLastStatus()
        {
            return this._lastStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulTime. 
        /// <para>
        /// The time of the last successful delivery.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulTime
        {
            get { return this._lastSuccessfulTime; }
            set { this._lastSuccessfulTime = value; }
        }

        // Check to see if LastSuccessfulTime property is set
        internal bool IsSetLastSuccessfulTime()
        {
            return this._lastSuccessfulTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextDeliveryTime. 
        /// <para>
        /// The time that the next delivery occurs.
        /// </para>
        /// </summary>
        public DateTime? NextDeliveryTime
        {
            get { return this._nextDeliveryTime; }
            set { this._nextDeliveryTime = value; }
        }

        // Check to see if NextDeliveryTime property is set
        internal bool IsSetNextDeliveryTime()
        {
            return this._nextDeliveryTime.HasValue; 
        }

    }
}