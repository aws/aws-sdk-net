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
    /// <para> Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance. Instance status provides information about two types
    /// of scheduled events for an instance that may require your attention: </para>
    /// <ul>
    /// <li> Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instance's status will return one of two event
    /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
    /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
    /// underlying host. Rebooting events include a scheduled start and end time. </li>
    /// <li> Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance's status will return an event code
    /// called <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events
    /// include a scheduled start and end time. You're also notified by email if one of your instances is set to retiring. The email message
    /// indicates when your instance will be permanently retired. </li>
    /// 
    /// </ul>
    /// <para> If your instance is permanently retired, it will not be restarted. You can avoid retirement by manually restarting your instance
    /// when its event code is <c>instance-retirement</c> . This ensures that your instance is started on a healthy host. </para> <para>
    /// <c>DescribeInstanceStatus</c> returns information only for instances in the running state. </para> <para> You can filter the results to
    /// return information only about instances that match criteria you specify. For example, you could get information about instances in a
    /// specific Availability Zone. You can specify multiple values for a filter (e.g., more than one Availability Zone). An instance must match at
    /// least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters. An instance must
    /// match all the filters for it to be included in the results. If there's no match, no special message is returned; the response is simply
    /// empty. </para> <para> You can use wildcards with the filter values: <c>*</c> matches zero or more characters, and <c>?</c> matches exactly
    /// one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
    /// searches for the literal string <c>*amazon?\</c> .
    /// </para> <para> The following filters are available: </para>
    /// <ul>
    /// <li> <c>availability-zone</c> - Filter on an instance's availability zone. </li>
    /// <li> <c>instance-state-name</c> - Filter on the intended state of the instance, e.g., running. </li>
    /// <li> <c>instance-state-code</c> - Filter on the intended state code of the instance, e.g., 16. </li>
    /// 
    /// </ul>
    /// </summary>
    public partial class DescribeInstanceStatusRequest : AmazonEC2Request
    {
        private List<string> instanceIds = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private string nextToken;
        private int? maxResults;
        private bool? includeAllInstances;


        /// <summary>
        /// The list of instance IDs. If not specified, all instances are described.
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
        /// The list of filters to limit returned results.
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
        /// A string specifying the next paginated set of results to return.
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
        /// The maximum number of paginated instance items per response.
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
    
