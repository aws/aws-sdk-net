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
    /// Returns a job flow ID.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class RunJobFlowResult
    {
        private string jobFlowIdField;

        /// <summary>
        /// Gets and sets the JobFlowId property.
        /// String, returned by RunJobFlow, which uniquely identifies the job flow created.
        /// </summary>
        [XmlElementAttribute(ElementName = "JobFlowId")]
        public string JobFlowId
        {
            get { return this.jobFlowIdField ; }
            set { this.jobFlowIdField= value; }
        }

        /// <summary>
        /// Sets the JobFlowId property
        /// </summary>
        /// <param name="jobFlowId">String, returned by RunJobFlow, which uniquely identifies the job flow created.</param>
        /// <returns>this instance</returns>
        public RunJobFlowResult WithJobFlowId(string jobFlowId)
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
            return  this.jobFlowIdField != null;
        }

    }
}
