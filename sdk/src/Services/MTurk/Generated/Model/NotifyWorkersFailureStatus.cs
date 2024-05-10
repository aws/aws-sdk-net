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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// When MTurk encounters an issue with notifying the Workers you specified, it returns
    /// back this object with failure details.
    /// </summary>
    public partial class NotifyWorkersFailureStatus
    {
        private NotifyWorkersFailureCode _notifyWorkersFailureCode;
        private string _notifyWorkersFailureMessage;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property NotifyWorkersFailureCode. 
        /// <para>
        ///  Encoded value for the failure type. 
        /// </para>
        /// </summary>
        public NotifyWorkersFailureCode NotifyWorkersFailureCode
        {
            get { return this._notifyWorkersFailureCode; }
            set { this._notifyWorkersFailureCode = value; }
        }

        // Check to see if NotifyWorkersFailureCode property is set
        internal bool IsSetNotifyWorkersFailureCode()
        {
            return this._notifyWorkersFailureCode != null;
        }

        /// <summary>
        /// Gets and sets the property NotifyWorkersFailureMessage. 
        /// <para>
        ///  A message detailing the reason the Worker could not be notified. 
        /// </para>
        /// </summary>
        public string NotifyWorkersFailureMessage
        {
            get { return this._notifyWorkersFailureMessage; }
            set { this._notifyWorkersFailureMessage = value; }
        }

        // Check to see if NotifyWorkersFailureMessage property is set
        internal bool IsSetNotifyWorkersFailureMessage()
        {
            return this._notifyWorkersFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        ///  The ID of the Worker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}