/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Makes a request to return information about a job flow. You specify job flows by their ID, creation date, or state. Elastic MapReduce returns descriptions of job flows that are up to two months old. Specifying an older date returns an error. The maximum number of job flow descriptions returned is 512.
    /// Each input parameter acts as a filter so that Elastic MapReduce returns information about a more precise set of job flows with each parameter you use in your request. If you do not include parameters in a request, Elastic MapReduce returns descriptions of all job flows that have: created and completed in the last two weeks, or not ended within the last two months
    /// These jobs are in one of the following states: RUNNING, WAITING, SHUTTING_ DOWN, STARTING.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class DescribeJobFlowsRequest
    {
        private string createdAfterField;
        private string createdBeforeField;
        private List<string> jobFlowIdsField;
        private List<string> jobFlowStatesField;

        /// <summary>
        /// Gets and sets the CreatedAfter property.
        /// Returns descriptions of job flows created after this date. Default is two months ago. Must be two months ago or more recent.
        /// Format is yyyy-mm-ddThh:mm:ss.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreatedAfter")]
        public string CreatedAfter
        {
            get { return this.createdAfterField; }
            set { this.createdAfterField = value; }
        }

        /// <summary>
        /// Sets the CreatedAfter property
        /// </summary>
        /// <param name="createdAfter">Returns descriptions of job flows created after this date. Default is two months ago. Must be two months ago or more recent.
        /// Format is yyyy-mm-ddThh:mm:ss.</param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsRequest WithCreatedAfter(string createdAfter)
        {
            this.createdAfterField = createdAfter;
            return this;
        }

        /// <summary>
        /// Checks if CreatedAfter property is set
        /// </summary>
        /// <returns>true if CreatedAfter property is set</returns>
        public bool IsSetCreatedAfter()
        {
            return this.createdAfterField != null;
        }

        /// <summary>
        /// Gets and sets the CreatedBefore property.
        /// Returns descriptions of job flows created before this date. Default is now. Must be before now and after two months ago.
        /// Format is yyyy-mm-ddThh:mm:ss.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreatedBefore")]
        public string CreatedBefore
        {
            get { return this.createdBeforeField; }
            set { this.createdBeforeField = value; }
        }

        /// <summary>
        /// Sets the CreatedBefore property
        /// </summary>
        /// <param name="createdBefore">Returns descriptions of job flows created before this date. Default is now. Must be before now and after two months ago.
        /// Format is yyyy-mm-ddThh:mm:ss.</param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsRequest WithCreatedBefore(string createdBefore)
        {
            this.createdBeforeField = createdBefore;
            return this;
        }

        /// <summary>
        /// Checks if CreatedBefore property is set
        /// </summary>
        /// <returns>true if CreatedBefore property is set</returns>
        public bool IsSetCreatedBefore()
        {
            return this.createdBeforeField != null;
        }

        /// <summary>
        /// Gets and sets the JobFlowIds property.
        /// Returns descriptions of job flows specified by the job flow IDs. These values are in the RunJobFlow response.
        /// The ID uniquely identifies the job flow.
        /// </summary>
        [XmlElementAttribute(ElementName = "JobFlowIds")]
        public List<string> JobFlowIds
        {
            get
            {
                if (this.jobFlowIdsField == null)
                {
                    this.jobFlowIdsField = new List<string>();
                }
                return this.jobFlowIdsField;
            }
            set { this.jobFlowIdsField = value; }
        }

        /// <summary>
        /// Sets the JobFlowIds property
        /// </summary>
        /// <param name="list">Returns descriptions of job flows specified by the job flow IDs. These values are in the RunJobFlow response.
        /// The ID uniquely identifies the job flow.</param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsRequest WithJobFlowIds(params string[] list)
        {
            foreach (string item in list)
            {
                JobFlowIds.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if JobFlowIds property is set
        /// </summary>
        /// <returns>true if JobFlowIds property is set</returns>
        public bool IsSetJobFlowIds()
        {
            return (JobFlowIds.Count > 0);
        }

        /// <summary>
        /// Gets and sets the JobFlowStates property.
        /// Returns descriptions of job flows specified by the job flow IDs. These values are in the RunJobFlow response.
        /// The ID uniquely identifies the job flow. Values can be: One or more of the following: COMPLETED | FAILED | TERMINATED | RUNNING | SHUTTING_DOWN | STARTING | WAITING.
        /// </summary>
        [XmlElementAttribute(ElementName = "JobFlowStates")]
        public List<string> JobFlowStates
        {
            get
            {
                if (this.jobFlowStatesField == null)
                {
                    this.jobFlowStatesField = new List<string>();
                }
                return this.jobFlowStatesField;
            }
            set { this.jobFlowStatesField = value; }
        }

        /// <summary>
        /// Sets the JobFlowStates property
        /// </summary>
        /// <param name="list">Returns descriptions of job flows specified by the job flow IDs. These values are in the RunJobFlow response.
        /// The ID uniquely identifies the job flow. Values can be: One or more of the following: COMPLETED | FAILED | TERMINATED | RUNNING | SHUTTING_DOWN | STARTING | WAITING.</param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsRequest WithJobFlowStates(params string[] list)
        {
            foreach (string item in list)
            {
                JobFlowStates.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if JobFlowStates property is set
        /// </summary>
        /// <returns>true if JobFlowStates property is set</returns>
        public bool IsSetJobFlowStates()
        {
            return (JobFlowStates.Count > 0);
        }

    }
}
