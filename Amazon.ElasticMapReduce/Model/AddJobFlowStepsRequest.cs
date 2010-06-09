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
    /// Adds new steps to a job flow already loaded on an EC2 cluster. Each step applies an algorithm to the data set, for the first step, or to the data returned by the previous step in the job flow. If the job flow isn't executing any other steps, execution begins from the first added step. The maximum number of steps in a job flow is 256.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class AddJobFlowStepsRequest
    {
        private string jobFlowIdField;
        private List<StepConfig> stepsField;

        /// <summary>
        /// Gets and sets the JobFlowId property.
        /// String that uniquely identifies a job flow. Elastic MapReduce returns this value in the RunJobFlow response. Must be valid, encrypted job flow ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "JobFlowId")]
        public string JobFlowId
        {
            get { return this.jobFlowIdField; }
            set { this.jobFlowIdField = value; }
        }

        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">String that uniquely identifies a job flow. Elastic MapReduce returns this value in the RunJobFlow response. Must be valid, encrypted job flow ID.</param>
        /// <returns>this instance</returns>
        public AddJobFlowStepsRequest WithJobFlowId(string jobFlowId)
        {
            this.jobFlowIdField = jobFlowId;
            return this;
        }

        /// <summary>
        /// Checks if JobFlowId property is set
        /// </summary>
        /// <returns>true if JobFlowId property is set</returns>
        public bool IsSetJobFlowId()
        {
            return this.jobFlowIdField != null;
        }
        /// <summary>
        /// Gets and sets the Steps property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Steps")]
        public List<StepConfig> Steps
        {
            get
            {
                if (this.stepsField == null)
                {
                    this.stepsField = new List<StepConfig>();
                }
                return this.stepsField;
            }
            set { this.stepsField = value; }
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="list">Steps property</param>
        /// <returns>this instance</returns>
        public AddJobFlowStepsRequest WithSteps(params StepConfig[] list)
        {
            foreach (StepConfig item in list)
            {
                Steps.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Steps property is set
        /// </summary>
        /// <returns>true if Steps property is set</returns>
        public bool IsSetSteps()
        {
            return (Steps.Count > 0);
        }

    }
}
