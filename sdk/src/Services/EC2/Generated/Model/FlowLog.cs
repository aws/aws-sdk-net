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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a flow log.
    /// </summary>
    public partial class FlowLog
    {
        private DateTime? _creationTime;
        private string _deliverLogsErrorMessage;
        private string _deliverLogsPermissionArn;
        private string _deliverLogsStatus;
        private string _flowLogId;
        private string _flowLogStatus;
        private string _logGroupName;
        private string _resourceId;
        private TrafficType _trafficType;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the flow log was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsErrorMessage. 
        /// <para>
        /// Information about the error that occurred. <code>Rate limited</code> indicates that
        /// CloudWatch logs throttling has been applied for one or more network interfaces. <code>Access
        /// error</code> indicates that the IAM role associated with the flow log does not have
        /// sufficient permissions to publish to CloudWatch Logs. <code>Unknown error</code> indicates
        /// an internal error.
        /// </para>
        /// </summary>
        public string DeliverLogsErrorMessage
        {
            get { return this._deliverLogsErrorMessage; }
            set { this._deliverLogsErrorMessage = value; }
        }

        // Check to see if DeliverLogsErrorMessage property is set
        internal bool IsSetDeliverLogsErrorMessage()
        {
            return this._deliverLogsErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsPermissionArn. 
        /// <para>
        /// The ARN of the IAM role that posts logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public string DeliverLogsPermissionArn
        {
            get { return this._deliverLogsPermissionArn; }
            set { this._deliverLogsPermissionArn = value; }
        }

        // Check to see if DeliverLogsPermissionArn property is set
        internal bool IsSetDeliverLogsPermissionArn()
        {
            return this._deliverLogsPermissionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeliverLogsStatus. 
        /// <para>
        /// The status of the logs delivery (<code>SUCCESS</code> | <code>FAILED</code>).
        /// </para>
        /// </summary>
        public string DeliverLogsStatus
        {
            get { return this._deliverLogsStatus; }
            set { this._deliverLogsStatus = value; }
        }

        // Check to see if DeliverLogsStatus property is set
        internal bool IsSetDeliverLogsStatus()
        {
            return this._deliverLogsStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogId. 
        /// <para>
        /// The flow log ID.
        /// </para>
        /// </summary>
        public string FlowLogId
        {
            get { return this._flowLogId; }
            set { this._flowLogId = value; }
        }

        // Check to see if FlowLogId property is set
        internal bool IsSetFlowLogId()
        {
            return this._flowLogId != null;
        }

        /// <summary>
        /// Gets and sets the property FlowLogStatus. 
        /// <para>
        /// The status of the flow log (<code>ACTIVE</code>).
        /// </para>
        /// </summary>
        public string FlowLogStatus
        {
            get { return this._flowLogStatus; }
            set { this._flowLogStatus = value; }
        }

        // Check to see if FlowLogStatus property is set
        internal bool IsSetFlowLogStatus()
        {
            return this._flowLogStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the flow log group.
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource on which the flow log was created.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficType. 
        /// <para>
        /// The type of traffic captured for the flow log.
        /// </para>
        /// </summary>
        public TrafficType TrafficType
        {
            get { return this._trafficType; }
            set { this._trafficType = value; }
        }

        // Check to see if TrafficType property is set
        internal bool IsSetTrafficType()
        {
            return this._trafficType != null;
        }

    }
}