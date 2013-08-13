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
    /// Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance.
    /// Instance status provides information about two types of scheduled events for
    /// an instance that may require your attention, Scheduled Reboot and Scheduled Retirement.
    /// Only information about instances in the running state is returned.
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
