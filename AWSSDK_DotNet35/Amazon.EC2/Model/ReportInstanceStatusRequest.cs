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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the ReportInstanceStatus operation.
    /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
    /// state. If your experience with the instance differs from the instance status returned
    /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
    /// with the instance. Amazon EC2 collects this information to improve the accuracy of
    /// status checks.
    /// 
    ///  
    /// <para>
    /// Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
    /// </para>
    /// </summary>
    public partial class ReportInstanceStatusRequest : AmazonEC2Request
    {
        private string _description;
        private DateTime? _endTime;
        private List<string> _instances = new List<string>();
        private List<string> _reasonCodes = new List<string>();
        private DateTime? _startTime;
        private ReportStatusType _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text about the health state of your instance.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time at which the reported instance health state ended.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// One or more instances.
        /// </para>
        /// </summary>
        public List<string> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReasonCodes. 
        /// <para>
        /// One or more reason codes that describes the health state of your instance.
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// <code>instance-stuck-in-state</code>: My instance is stuck in a state.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>unresponsive</code>: My instance is unresponsive.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>not-accepting-credentials</code>: My instance is not accepting my credentials.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>password-not-available</code>: A password is not available for my instance.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>performance-network</code>: My instance is experiencing performance problems
        /// which I believe are network related.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>performance-instance-store</code>: My instance is experiencing performance problems
        /// which I believe are related to the instance stores.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>performance-ebs-volume</code>: My instance is experiencing performance problems
        /// which I believe are related to an EBS volume.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>performance-other</code>: My instance is experiencing performance problems.
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>other</code>: [explain using the description parameter]
        /// </para>
        /// </li> </ul>
        /// </summary>
        public List<string> ReasonCodes
        {
            get { return this._reasonCodes; }
            set { this._reasonCodes = value; }
        }

        // Check to see if ReasonCodes property is set
        internal bool IsSetReasonCodes()
        {
            return this._reasonCodes != null && this._reasonCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time at which the reported instance health state began.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The status of all instances listed.
        /// </para>
        /// </summary>
        public ReportStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}