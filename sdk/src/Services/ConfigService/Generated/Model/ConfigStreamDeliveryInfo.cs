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
    /// A list that contains the status of the delivery of the configuration stream notification
    /// to the Amazon SNS topic.
    /// </summary>
    public partial class ConfigStreamDeliveryInfo
    {
        private string _lastErrorCode;
        private string _lastErrorMessage;
        private DeliveryStatus _lastStatus;
        private DateTime? _lastStatusChangeTime;

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
        ///  
        /// <para>
        ///  <b>Note</b> Providing an SNS topic on a <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_DeliveryChannel.html">DeliveryChannel</a>
        /// for Config is optional. If the SNS delivery is turned off, the last status will be
        /// <b>Not_Applicable</b>.
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
        /// Gets and sets the property LastStatusChangeTime. 
        /// <para>
        /// The time from the last status change.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChangeTime
        {
            get { return this._lastStatusChangeTime; }
            set { this._lastStatusChangeTime = value; }
        }

        // Check to see if LastStatusChangeTime property is set
        internal bool IsSetLastStatusChangeTime()
        {
            return this._lastStatusChangeTime.HasValue; 
        }

    }
}