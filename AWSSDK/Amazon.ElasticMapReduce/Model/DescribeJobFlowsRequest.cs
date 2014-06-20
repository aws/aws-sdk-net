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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeJobFlows operation.
    /// This API is deprecated and will eventually be removed. We recommend you use <a>ListClusters</a>,
    ///         <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a> and <a>ListBootstrapActions</a>
    ///         instead.
    /// 
    ///       
    /// <para>
    ///  DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
    ///         The parameters can include a list of job flow IDs, job flow states, and restrictions
    /// on job         flow creation date and time.
    /// </para>
    ///       
    /// <para>
    ///  Regardless of supplied parameters, only job flows created within the last two months
    /// are         returned.
    /// </para>
    ///       
    /// <para>
    ///  If no parameters are supplied, then job flows matching either of the following criteria
    ///         are returned:
    /// </para>
    ///       <ul>         <li>Job flows created and completed in the last two weeks</li>
    ///         <li> Job flows created within the last two months that are in one of the following
    /// states:               <code>RUNNING</code>, <code>WAITING</code>, <code>SHUTTING_DOWN</code>,
    ///               <code>STARTING</code>         </li>      </ul>      
    /// <para>
    ///  Amazon Elastic MapReduce can return a maximum of 512 job flow descriptions. 
    /// </para>
    /// </summary>
    public partial class DescribeJobFlowsRequest : AmazonWebServiceRequest
    {
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private List<string> _jobFlowIds = new List<string>();
        private List<string> _jobFlowStates = new List<string>();


        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Return only job flows created after this date and time.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
            set { this._createdAfter = value; }
        }


        /// <summary>
        /// Sets the CreatedAfter property
        /// </summary>
        /// <param name="createdAfter">The value to set for the CreatedAfter property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithCreatedAfter(DateTime createdAfter)
        {
            this._createdAfter = createdAfter;
            return this;
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Return only job flows created before this date and time.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }


        /// <summary>
        /// Sets the CreatedBefore property
        /// </summary>
        /// <param name="createdBefore">The value to set for the CreatedBefore property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithCreatedBefore(DateTime createdBefore)
        {
            this._createdBefore = createdBefore;
            return this;
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// Return only job flows whose job flow ID is contained in this list. 
        /// </para>
        /// </summary>
        public List<string> JobFlowIds
        {
            get { return this._jobFlowIds; }
            set { this._jobFlowIds = value; }
        }

        /// <summary>
        /// Sets the JobFlowIds property
        /// </summary>
        /// <param name="jobFlowIds">The values to add to the JobFlowIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithJobFlowIds(params string[] jobFlowIds)
        {
            foreach (var element in jobFlowIds)
            {
                this._jobFlowIds.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the JobFlowIds property
        /// </summary>
        /// <param name="jobFlowIds">The values to add to the JobFlowIds collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithJobFlowIds(IEnumerable<string> jobFlowIds)
        {
            foreach (var element in jobFlowIds)
            {
                this._jobFlowIds.Add(element);
            }
            return this;
        }
        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this._jobFlowIds != null && this._jobFlowIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property JobFlowStates. 
        /// <para>
        /// Return only job flows whose state is contained in this list.
        /// </para>
        /// </summary>
        public List<string> JobFlowStates
        {
            get { return this._jobFlowStates; }
            set { this._jobFlowStates = value; }
        }

        /// <summary>
        /// Sets the JobFlowStates property
        /// </summary>
        /// <param name="jobFlowStates">The values to add to the JobFlowStates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithJobFlowStates(params string[] jobFlowStates)
        {
            foreach (var element in jobFlowStates)
            {
                this._jobFlowStates.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the JobFlowStates property
        /// </summary>
        /// <param name="jobFlowStates">The values to add to the JobFlowStates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeJobFlowsRequest WithJobFlowStates(IEnumerable<string> jobFlowStates)
        {
            foreach (var element in jobFlowStates)
            {
                this._jobFlowStates.Add(element);
            }
            return this;
        }
        // Check to see if JobFlowStates property is set
        internal bool IsSetJobFlowStates()
        {
            return this._jobFlowStates != null && this._jobFlowStates.Count > 0; 
        }

    }
}