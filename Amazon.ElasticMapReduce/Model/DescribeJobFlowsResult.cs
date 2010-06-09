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
    /// Extensive details about specified job flows.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class DescribeJobFlowsResult
    {
        private List<JobFlowDetail> jobFlowsField;
        /// <summary>
        /// Gets and sets the JobFlows property.
        /// </summary>
        [XmlElementAttribute(ElementName = "JobFlows")]
        public List<JobFlowDetail> JobFlows
        {
            get
            {
                if (this.jobFlowsField == null)
                {
                    this.jobFlowsField = new List<JobFlowDetail>();
                }
                return this.jobFlowsField;
            }
            set { this.jobFlowsField = value; }
        }

        /// <summary>
        /// Sets the JobFlows property
        /// </summary>
        /// <param name="list">JobFlows property</param>
        /// <returns>this instance</returns>
        public DescribeJobFlowsResult WithJobFlows(params JobFlowDetail[] list)
        {
            foreach (JobFlowDetail item in list)
            {
                JobFlows.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if JobFlows property is set
        /// </summary>
        /// <returns>true if JobFlows property is set</returns>
        public bool IsSetJobFlows()
        {
            return (JobFlows.Count > 0);
        }

    }
}
