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
    /// Container for the parameters to the DescribeInstanceStatus operation.
    /// Describes the status of one or more instances, including any scheduled events.
    /// 
    ///  
    /// <para>
    /// Instance status has two main components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// System Status reports impaired functionality that stems from issues related to the
    /// systems that support an instance, such as such as hardware failures and network connectivity
    /// problems. This call reports such problems as impaired reachability.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Instance Status reports impaired functionality that arises from problems internal
    /// to the instance. This call reports such problems as impaired reachability.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Instance status provides information about four types of scheduled events for an instance
    /// that may require your attention:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the
    /// instances status returns one of two event codes: <code>system-reboot</code> or <code>instance-reboot</code>.
    /// System reboot commonly occurs if certain maintenance or upgrade operations require
    /// a reboot of the underlying host that supports an instance. Instance reboot commonly
    /// occurs if the instance must be rebooted, rather than the underlying host. Rebooting
    /// events include a scheduled start and end time.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// System Maintenance: When Amazon EC2 determines that an instance requires maintenance
    /// that requires power or network impact, the instance status is the event code <code>system-maintenance</code>.
    /// System maintenance is either power maintenance or network maintenance. For power maintenance,
    /// your instance will be unavailable for a brief period of time and then rebooted. For
    /// network maintenance, your instance will experience a brief loss of network connectivity.
    /// System maintenance events include a scheduled start and end time. You will also be
    /// notified by email if one of your instances is set for system maintenance. The email
    /// message indicates when your instance is scheduled for maintenance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down,
    /// the instance status is the event code <code>instance-retirement</code>. Retirement
    /// commonly occurs when the underlying host is degraded and must be replaced. Retirement
    /// events include a scheduled start and end time. You will also be notified by email
    /// if one of your instances is set to retiring. The email message indicates when your
    /// instance will be permanently retired.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the
    /// instances status returns an event code called <code>instance-stop</code>. Stop events
    /// include a scheduled start and end time. You will also be notified by email if one
    /// of your instances is set to stop. The email message indicates when your instance will
    /// be stopped.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When your instance is retired, it will either be terminated (if its root device type
    /// is the instance-store) or stopped (if its root device type is an EBS volume). Instances
    /// stopped due to retirement will not be restarted, but you can do so manually. You can
    /// also avoid retirement of EBS-backed instances by manually restarting your instance
    /// when its event code is <code>instance-retirement</code>. This ensures that your instance
    /// is started on a different underlying host.
    /// </para>
    ///  
    /// <para>
    /// For more information about failed status checks, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
    /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
    /// Guide for Linux</i>. For more information about working with scheduled events, see
    /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html#schedevents_actions">Working
    /// with an Instance That Has a Scheduled Event</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DescribeInstanceStatusRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private bool? _includeAllInstances;
        private List<string> _instanceIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>availability-zone</code> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>event.code</code> - The code identifying the type of event (<code>instance-reboot</code>
        /// | <code>system-reboot</code> | <code>system-maintenance</code> | <code>instance-retirement</code>
        /// | <code>instance-stop</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>event.description</code> - A description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>event.not-after</code> - The latest end time for the scheduled event, for example:
        /// <code>2010-09-15T17:15:20.000Z</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>event.not-before</code> - The earliest start time for the scheduled event, for
        /// example: <code>2010-09-15T17:15:20.000Z</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-state-code</code> - A code representing the state of the instance,
        /// as a 16-bit unsigned integer. The high byte is an opaque internal value and should
        /// be ignored. The low byte is set based on the state represented. The valid values are
        /// 0 (pending), 16 (running), 32 (shutting-down), 48 (terminated), 64 (stopping), and
        /// 80 (stopped).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-state-name</code> - The state of the instance (<code>pending</code>
        /// | <code>running</code> | <code>shutting-down</code> | <code>terminated</code> | <code>stopping</code>
        /// | <code>stopped</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-status.reachability</code> - Filters on instance status where the name
        /// is <code>reachability</code> (<code>passed</code> | <code>failed</code> | <code>initializing</code>
        /// | <code>insufficient-data</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>instance-status.status</code> - The status of the instance (<code>ok</code>
        /// | <code>impaired</code> | <code>initializing</code> | <code>insufficient-data</code>
        /// | <code>not-applicable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>system-status.reachability</code> - Filters on system status where the name
        /// is <code>reachability</code> (<code>passed</code> | <code>failed</code> | <code>initializing</code>
        /// | <code>insufficient-data</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>system-status.status</code> - The system status of the instance (<code>ok</code>
        /// | <code>impaired</code> | <code>initializing</code> | <code>insufficient-data</code>
        /// | <code>not-applicable</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeAllInstances. 
        /// <para>
        /// When <code>true</code>, includes the health status for all instances. When <code>false</code>,
        /// includes the health status for running instances only.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public bool IncludeAllInstances
        {
            get { return this._includeAllInstances.GetValueOrDefault(); }
            set { this._includeAllInstances = value; }
        }

        // Check to see if IncludeAllInstances property is set
        internal bool IsSetIncludeAllInstances()
        {
            return this._includeAllInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// One or more instance IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 100 explicitly specified instance IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of paginated instance items per response. The call also returns
        /// a token that you can specify in a subsequent call to get the next set of results.
        /// If the value is greater than 1000, we return only 1000 items.
        /// </para>
        ///  
        /// <para>
        /// Default: 1000
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next paginated set of results to return. (You received this token from a prior
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}