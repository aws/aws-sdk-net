/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Submits feedback about the status of an instance. The instance must be in the <c>running</c> state. If your experience with the
    /// instance differs from the instance status returned by DescribeInstanceStatus, use ReportInstanceStatus to report your experience with the
    /// instance. Amazon EC2 collects this information to improve the accuracy of status checks.</para>
    /// </summary>
    public partial class ReportInstanceStatusRequest : AmazonEC2Request
    {
        private List<string> instances = new List<string>();
        private ReportStatusType status;
        private DateTime? startTime;
        private DateTime? endTime;
        private List<string> reasonCodes = new List<string>();
        private string description;


        /// <summary>
        /// One or more instances.
        ///  
        /// </summary>
        public List<string> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }

        /// <summary>
        /// The status of all instances listed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ok, impaired</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReportStatusType Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The time at which the reported instance health state began.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The time at which the reported instance health state ended.
        ///  
        /// </summary>
        public DateTime EndTime
        {
            get { return this.endTime ?? default(DateTime); }
            set { this.endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this.endTime.HasValue;
        }

        /// <summary>
        /// One or more reason codes that describes the health state of your instance. <ul> <li><c>instance-stuck-in-state</c>: My instance is stuck in
        /// a state.</li> <li><c>unresponsive</c>: My instance is unresponsive.</li> <li><c>not-accepting-credentials</c>: My instance is not accepting
        /// my credentials.</li> <li><c>password-not-available</c>: A password is not available for my instance.</li> <li><c>performance-network</c>: My
        /// instance is experiencing performance problems which I believe are network related.</li> <li><c>performance-instance-store</c>: My instance
        /// is experiencing performance problems which I believe are related to the instance stores.</li> <li><c>performance-ebs-volume</c>: My instance
        /// is experiencing performance problems which I believe are related to an EBS volume.</li> <li><c>performance-other</c>: My instance is
        /// experiencing performance problems.</li> <li><c>other</c>: [explain using the description parameter]</li> </ul>
        ///  
        /// </summary>
        public List<string> ReasonCodes
        {
            get { return this.reasonCodes; }
            set { this.reasonCodes = value; }
        }

        // Check to see if ReasonCodes property is set
        internal bool IsSetReasonCodes()
        {
            return this.reasonCodes.Count > 0;
        }

        /// <summary>
        /// Descriptive text about the health state of your instance.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

    }
}
    
