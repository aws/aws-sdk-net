/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

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
    /// that your instance is started on a different underlying host.</para> <para>For more information about failed status checks, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html" >Troubleshooting Instances with Failed Status
    /// Checks</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> . For more information about working with scheduled events, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html#schedevents_actions" >Working with an
    /// Instance That Has a Scheduled Event</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeInstanceStatusRequest : EC2Request
    {
        private List<string> instanceIdField;
        private List<Filter> filterField;
        private string nextTokenField;
        private int? maxResultsField;
        private bool? includeAllInstancesField;

        /// <summary>
        /// List of instance IDs.
        /// If not specified, all instances are described. 
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public List<string> InstanceId
        {
            get
            {
                if (this.instanceIdField == null)
                {
                    this.instanceIdField = new List<string>();
                }
                return this.instanceIdField;
            }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets instance IDs.
        /// </summary>
        /// <param name="list">Instance IDs to describe.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceStatusRequest WithInstanceId(params string[] list)
        {
            foreach (string item in list)
            {
                InstanceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return (InstanceId.Count > 0);
        }

        /// <summary>
        /// A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Instances.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Instances.
        /// </summary>
        /// <param name="list">A list of filters used to match system-defined properties and user-defined tags associated with 
        /// the specified Instances.
        /// For a complete reference to the available filter keys for this operation, see the
        /// Amazon EC2 API reference.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceStatusRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

        /// <summary>
        /// Token specifying the next paginated set of results to return. 
        /// </summary>
        public string NextToken
        {
            get { return this.nextTokenField; }
            set { this.nextTokenField = value; }
        }

        /// <summary>
        /// Sets the token specifying the next paginated set of results to return. 
        /// </summary>
        /// <param name="nextToken"></param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceStatusRequest WithNextToken(string nextToken)
        {
            this.nextTokenField = nextToken;
            return this;
        }

        /// <summary>
        /// Checks if the NextToken property is set.
        /// </summary>
        /// <returns>true if NextToken property is set</returns>
        public bool IsSetNextToken()
        {
            return this.nextTokenField != null;
        }

        /// <summary>
        /// The maximum number of paginated instance items per response.
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResultsField.GetValueOrDefault(); }
            set { this.maxResultsField = value; }
        }

        /// <summary>
        /// Sets the maximum number of paginated instance items per response.
        /// </summary>
        /// <param name="maxResults">Maximum number of paginated instance items</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceStatusRequest WithMaxResults(int maxResults)
        {
            this.maxResultsField = maxResults;
            return this;
        }

        /// <summary>
        /// Checks if the MaxResults property is set.
        /// </summary>
        /// <returns>true if MaxResults property is set</returns>
        public bool IsSetMaxResults()
        {
            return this.maxResultsField.HasValue;
        }

        /// <summary>
        /// Gets and sets whether the request includes all or only running instances.
        /// When true, returns the health status for all instances (e.g., running, stopped, pending, shutting down, etc.). 
        /// When false (default), returns only the health status for running instances. 
        /// </summary>
        public bool IncludeAllInstances
        {
            get { return this.includeAllInstancesField.GetValueOrDefault(); }
            set { this.includeAllInstancesField = value; }
        }

        /// <summary>
        /// Sets whether the request includes all or only running instances.
        /// </summary>
        /// <param name="includeAllInstances">
        /// Set true to return the health status for all instances (e.g., running, stopped, pending, shutting down, etc.). 
        /// Set false to return only the health status for running instances. 
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeInstanceStatusRequest WithIncludeAllInstances(bool includeAllInstances)
        {
            this.includeAllInstancesField = includeAllInstances;
            return this;
        }

        /// <summary>
        /// Checks if the IncludeAllInstances property is set.
        /// </summary>
        /// <returns>True if the IncludeAllInstances property is set.</returns>
        public bool IsSetIncludeAllInstances()
        {
            return this.includeAllInstancesField != null;
        }
    }
}
