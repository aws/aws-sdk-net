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
    /// Container for the parameters to the DescribeInstanceStatus operation.
    /// <para>Describes the status of one or more instances, including any scheduled events.</para> <para>Instance status has two main
    /// components:</para>
    /// <ul>
    /// <li> <para>System Status reports impaired functionality that stems from issues related to the systems that support an instance, such as
    /// such as hardware failures and network connectivity problems. This call reports such problems as impaired reachability.</para> </li>
    /// <li> <para>Instance Status reports impaired functionality that arises from problems internal to the instance. This call reports such
    /// problems as impaired reachability.</para> </li>
    /// 
    /// </ul>
    /// <para>Instance status provides information about four types of scheduled events for an instance that may require your attention:</para>
    /// <ul>
    /// <li> <para>Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instances status returns one of two event
    /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
    /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
    /// underlying host. Rebooting events include a scheduled start and end time.</para> </li>
    /// <li> <para>System Maintenance: When Amazon EC2 determines that an instance requires maintenance that requires power or network impact, the
    /// instance status is the event code <c>system-maintenance</c> . System maintenance is either power maintenance or network maintenance. For
    /// power maintenance, your instance will be unavailable for a brief period of time and then rebooted. For network maintenance, your instance
    /// will experience a brief loss of network connectivity. System maintenance events include a scheduled start and end time. You will also be
    /// notified by email if one of your instances is set for system maintenance. The email message indicates when your instance is scheduled for
    /// maintenance.</para> </li>
    /// <li> <para>Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance status is the event code
    /// <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events include
    /// a scheduled start and end time. You will also be notified by email if one of your instances is set to retiring. The email message indicates
    /// when your instance will be permanently retired.</para> </li>
    /// <li> <para>Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the instances status returns an event code called
    /// <c>instance-stop</c> .
    /// Stop events include a scheduled start and end time. You will also be notified by email if one of your instances is set to stop. The
    /// email message indicates when your instance will be stopped.</para> </li>
    /// 
    /// </ul>
    /// <para>When your instance is retired, it will either be terminated (if its root device type is the instance-store) or stopped (if its root
    /// device type is an EBS volume). Instances stopped due to retirement will not be restarted, but you can do so manually. You can also avoid
    /// retirement of EBS-backed instances by manually restarting your instance when its event code is <c>instance-retirement</c> . This ensures
    /// that your instance is started on a different underlying host.</para>
    /// </summary>
    public partial class DescribeInstanceStatusRequest : AmazonEC2Request
    {
        private List<string> instanceIds = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private string nextToken;
        private int? maxResults;
        private bool? includeAllInstances;


        /// <summary>
        /// One or more instance IDs. Default: Describes all your instances. Constraints: Maximum 100 explicitly specified instance IDs.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availability-zone</c> - The Availability Zone of the instance. </li> <li> <c>event.code</c> - The code
        /// identifying the type of event (<c>instance-reboot</c> | <c>system-reboot</c> | <c>system-maintenance</c> | <c>instance-retirement</c> |
        /// <c>instance-stop</c>). </li> <li> <c>event.description</c> - A description of the event. </li> <li> <c>event.not-after</c> - The latest end
        /// time for the scheduled event. </li> <li> <c>event.not-before</c> - The earliest start time for the scheduled event. </li> <li>
        /// <c>instance-state-code</c> - A code representing the state of the instance, as a 16-bit unsigned integer. The high byte is an opaque
        /// internal value and should be ignored. The low byte is set based on the state represented. The valid values are 0 (pending), 16 (running), 32
        /// (shutting-down), 48 (terminated), 64 (stopping), and 80 (stopped). </li> <li> <c>instance-state-name</c> - The state of the instance
        /// (<c>pending</c> | <c>running</c> | <c>shutting-down</c> | <c>terminated</c> | <c>stopping</c> | <c>stopped</c>). </li> <li>
        /// <c>instance-status.reachability</c> - Filters on instance status where the name is <c>reachability</c> (<c>passed</c> | <c>failed</c> |
        /// <c>initializing</c> | <c>insufficient-data</c>). </li> <li> <c>instance-status.status</c> - The status of the instance (<c>ok</c> |
        /// <c>impaired</c> | <c>initializing</c> | <c>insufficient-data</c> | <c>not-applicable</c>). </li> <li> <c>system-status.reachability</c> -
        /// Filters on system status where the name is <c>reachability</c> (<c>passed</c> | <c>failed</c> | <c>initializing</c> |
        /// <c>insufficient-data</c>). </li> <li> <c>system-status.status</c> - The system status of the instance (<c>ok</c> | <c>impaired</c> |
        /// <c>initializing</c> | <c>insufficient-data</c> | <c>not-applicable</c>). </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

        /// <summary>
        /// The next paginated set of results to return.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// The maximum number of paginated instance items per response. Default: 1000
        ///  
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// When <c>true</c>, includes the health status for all instances. When <c>false</c>, includes the health status for running instances only.
        /// Default: <c>false</c>
        ///  
        /// </summary>
        public bool IncludeAllInstances
        {
            get { return this.includeAllInstances ?? default(bool); }
            set { this.includeAllInstances = value; }
        }

        // Check to see if IncludeAllInstances property is set
        internal bool IsSetIncludeAllInstances()
        {
            return this.includeAllInstances.HasValue;
        }

    }
}
    
