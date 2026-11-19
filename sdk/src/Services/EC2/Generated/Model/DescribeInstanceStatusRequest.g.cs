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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstanceStatus operation. Describes the
    /// status of the specified instances or all of your instances. By default, only running
    /// instances are described, unless you specifically indicate to return the status of
    /// all instances. <para> Instance status includes the following components: </para> <ul>
    /// <li> <para> <b>Status checks</b> - Amazon EC2 performs status checks on running EC2
    /// instances to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
    /// checks for your instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshoot
    /// instances with failed status checks</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </li> <li> <para> <b>Application status checks</b> - Amazon EC2 reports application-level
    /// health status for instances, indicating whether applications running on the instance
    /// are functioning properly. </para> </li> <li> <para> <b>Scheduled events</b> - Amazon
    /// EC2 can schedule events (such as reboot, stop, or terminate) for your instances related
    /// to hardware issues, software updates, or system maintenance. For more information,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
    /// events for your instances</a> in the <i>Amazon EC2 User Guide</i>. </para> </li> <li>
    /// <para> <b>Instance state</b> - You can manage your instances from the moment you launch
    /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
    /// lifecycle</a> in the <i>Amazon EC2 User Guide</i>. </para> </li> </ul> <para> The
    /// Amazon EC2 API follows an eventual consistency model. This means that the result of
    /// an API command you run that creates or modifies resources might not be immediately
    /// available to all subsequent commands you run. For guidance on how to manage eventual
    /// consistency, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/eventual-consistency.html">Eventual
    /// consistency in the Amazon EC2 API</a> in the <i>Amazon EC2 Developer Guide</i>. </para>
    /// <note> <para> The order of the elements in the response, including those within nested
    /// structures, might vary. Applications should not assume the elements appear in a particular
    /// order. </para> </note>
    /// </summary>
    public partial class DescribeInstanceStatusRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone-id</c> - The ID of the Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.code</c> - The code for the scheduled event (<c>instance-reboot</c> | <c>system-reboot</c>
        /// | <c>system-maintenance</c> | <c>instance-retirement</c> | <c>instance-stop</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.description</c> - A description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.instance-event-id</c> - The ID of the event whose date and time you are
        /// modifying.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.not-after</c> - The latest end time for the scheduled event (for example,
        /// <c>2014-09-15T17:15:20.000Z</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.not-before</c> - The earliest start time for the scheduled event (for example,
        /// <c>2014-09-15T17:15:20.000Z</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>event.not-before-deadline</c> - The deadline for starting the event (for example,
        /// <c>2014-09-15T17:15:20.000Z</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-state-code</c> - The code for the instance state, as a 16-bit unsigned
        /// integer. The high byte is used for internal purposes and should be ignored. The low
        /// byte is set based on the state represented. The valid values are 0 (pending), 16 (running),
        /// 32 (shutting-down), 48 (terminated), 64 (stopping), and 80 (stopped).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-state-name</c> - The state of the instance (<c>pending</c> | <c>running</c>
        /// | <c>shutting-down</c> | <c>terminated</c> | <c>stopping</c> | <c>stopped</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-status.reachability</c> - Filters on instance status where the name is
        /// <c>reachability</c> (<c>passed</c> | <c>failed</c> | <c>initializing</c> | <c>insufficient-data</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-status.status</c> - The status of the instance (<c>ok</c> | <c>impaired</c>
        /// | <c>initializing</c> | <c>insufficient-data</c> | <c>not-applicable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.managed</c> - A Boolean that indicates whether this is a managed instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>operator.principal</c> - The principal that manages the instance. Only valid for
        /// managed instances, where <c>managed</c> is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>system-status.reachability</c> - Filters on system status where the name is <c>reachability</c>
        /// (<c>passed</c> | <c>failed</c> | <c>initializing</c> | <c>insufficient-data</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>system-status.status</c> - The system status of the instance (<c>ok</c> | <c>impaired</c>
        /// | <c>initializing</c> | <c>insufficient-data</c> | <c>not-applicable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attached-ebs-status.status</c> - The status of the attached EBS volume for the
        /// instance (<c>ok</c> | <c>impaired</c> | <c>initializing</c> | <c>insufficient-data</c>
        /// | <c>not-applicable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application-status.status</c> - The application status of the instance (<c>ok</c>
        /// | <c>impaired</c> | <c>initializing</c> | <c>insufficient-data</c> | <c>not-applicable</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeAllInstances. 
        /// <para>
        /// When <c>true</c>, includes the health status for all instances. When <c>false</c>,
        /// includes the health status for running instances only.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? IncludeAllInstances { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAllInstances property is set.
        /// </summary>
        internal bool IsSetIncludeAllInstances() => this.IncludeAllInstances.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeManagedResources. 
        /// <para>
        /// Indicates whether to include managed resources in the output. If this parameter is
        /// set to <c>true</c>, the output includes resources that are managed by Amazon Web Services
        /// services, even if managed resource visibility is set to hidden.
        /// </para>
        /// </summary>
        public bool? IncludeManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeManagedResources property is set.
        /// </summary>
        internal bool IsSetIncludeManagedResources() => this.IncludeManagedResources.HasValue;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstanceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceIds property is set.
        /// </summary>
        internal bool IsSetInstanceIds() => this.InstanceIds != null && (this.InstanceIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
