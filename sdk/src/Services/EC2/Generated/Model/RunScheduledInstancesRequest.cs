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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RunScheduledInstances operation.
    /// Launches the specified Scheduled Instances.
    /// 
    ///  
    /// <para>
    /// Before you can launch a Scheduled Instance, you must purchase it and obtain an identifier
    /// using <a>PurchaseScheduledInstances</a>.
    /// </para>
    ///  
    /// <para>
    /// You must launch a Scheduled Instance during its scheduled time period. You can't stop
    /// or reboot a Scheduled Instance, but you can terminate it as needed. If you terminate
    /// a Scheduled Instance before the current scheduled time period ends, you can launch
    /// it again after a few minutes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html">Scheduled
    /// Instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RunScheduledInstancesRequest : AmazonEC2Request
    {
        private string _clientToken;
        private int? _instanceCount;
        private ScheduledInstancesLaunchSpecification _launchSpecification;
        private string _scheduledInstanceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that ensures the idempotency of the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecification. 
        /// <para>
        /// The launch specification. You must match the instance type, Availability Zone, network,
        /// and platform of the schedule that you purchased.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public ScheduledInstancesLaunchSpecification LaunchSpecification
        {
            get { return this._launchSpecification; }
            set { this._launchSpecification = value; }
        }

        // Check to see if LaunchSpecification property is set
        internal bool IsSetLaunchSpecification()
        {
            return this._launchSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledInstanceId. 
        /// <para>
        /// The Scheduled Instance ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScheduledInstanceId
        {
            get { return this._scheduledInstanceId; }
            set { this._scheduledInstanceId = value; }
        }

        // Check to see if ScheduledInstanceId property is set
        internal bool IsSetScheduledInstanceId()
        {
            return this._scheduledInstanceId != null;
        }

    }
}