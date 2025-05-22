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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes the status of the production variant.
    /// </summary>
    public partial class ProductionVariantStatus
    {
        private DateTime? _startTime;
        private VariantStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the current status change.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The endpoint variant status which describes the current deployment stage status or
        /// operational status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c>: Creating inference resources for the production variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: Terminating inference resources for the production variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: Updating capacity for the production variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ActivatingTraffic</c>: Turning on traffic for the production variant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Baking</c>: Waiting period to monitor the CloudWatch alarms in the automatic rollback
        /// configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public VariantStatus Status
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
        /// A message that describes the status of the production variant.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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