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
    /// Container for the parameters to the DescribeInstanceStatus operation.
    /// Describes the status of the specified instances or all of your instances. By default,
    /// only running instances are described, unless you specifically indicate to return the
    /// status of all instances.
    /// 
    ///  
    /// <para>
    /// Instance status includes the following components:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
    /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
    /// checks for your instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshoot
    /// instances with failed status checks</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
    /// terminate) for your instances related to hardware issues, software updates, or system
    /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
    /// events for your instances</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Instance state</b> - You can manage your instances from the moment you launch
    /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
    /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> </ul>
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
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.code</code> - The code for the scheduled event (<code>instance-reboot</code>
        /// | <code>system-reboot</code> | <code>system-maintenance</code> | <code>instance-retirement</code>
        /// | <code>instance-stop</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.description</code> - A description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.instance-event-id</code> - The ID of the event whose date and time you
        /// are modifying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.not-after</code> - The latest end time for the scheduled event (for example,
        /// <code>2014-09-15T17:15:20.000Z</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.not-before</code> - The earliest start time for the scheduled event (for
        /// example, <code>2014-09-15T17:15:20.000Z</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>event.not-before-deadline</code> - The deadline for starting the event (for
        /// example, <code>2014-09-15T17:15:20.000Z</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-state-code</code> - The code for the instance state, as a 16-bit unsigned
        /// integer. The high byte is used for internal purposes and should be ignored. The low
        /// byte is set based on the state represented. The valid values are 0 (pending), 16 (running),
        /// 32 (shutting-down), 48 (terminated), 64 (stopping), and 80 (stopped).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-state-name</code> - The state of the instance (<code>pending</code>
        /// | <code>running</code> | <code>shutting-down</code> | <code>terminated</code> | <code>stopping</code>
        /// | <code>stopped</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-status.reachability</code> - Filters on instance status where the
        /// name is <code>reachability</code> (<code>passed</code> | <code>failed</code> | <code>initializing</code>
        /// | <code>insufficient-data</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-status.status</code> - The status of the instance (<code>ok</code>
        /// | <code>impaired</code> | <code>initializing</code> | <code>insufficient-data</code>
        /// | <code>not-applicable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>system-status.reachability</code> - Filters on system status where the name
        /// is <code>reachability</code> (<code>passed</code> | <code>failed</code> | <code>initializing</code>
        /// | <code>insufficient-data</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>system-status.status</code> - The system status of the instance (<code>ok</code>
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
        /// The instance IDs.
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
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter and the instance IDs parameter in the same request.
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
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
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