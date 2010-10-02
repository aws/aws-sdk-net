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
    /// Terminates job flow processing, uploads data from EC2 to Amazon S3, and terminates the EC2 cluster. You can use this action
    /// to terminate a single job flow or a list of job flows. Job flows that complete successfully terminate automatically unless
    /// you set the RunJobFlows parameter, KeepJobFlowAliveWhenNoSteps, to True. Job flows also terminate automatically on failure
    /// unless you set the RunJobFlows parameter, KeepJobFlowAliveWhenNoSteps, to CANCEL_AND_WAIT or CONTINUE.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class TerminateJobFlowsRequest
    {
        private List<string> jobFlowIdsField;

        /// <summary>
        /// Gets and sets the JobFlowIds property.
        /// One or more job flow IDs that specify the job flows to terminate. Each JobFlowId is a string returned by RunJobFlow.
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
        /// <param name="list">One or more job flow IDs that specify the job flows to terminate. Each JobFlowId is a string returned by RunJobFlow.</param>
        /// <returns>this instance</returns>
        public TerminateJobFlowsRequest WithJobFlowIds(params string[] list)
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

    }
}
