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
    /// Creates a new job flow, an EC2 cluster, and executes the job flow steps on the cluster. When the job flow finishes, depending
    /// on the parameter values, RunJobFlow terminates the EC2 cluster and uploads results to a specified Amazon S3 bucket.
    /// The maximum lifetime of a job flow is 2 weeks. The maximum number of steps allowed in a job flow is 256.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class RunJobFlowRequest
    {
        private string nameField;
        private string logUriField;
        private JobFlowInstancesConfig instancesField;
        private List<StepConfig> stepsField;

        /// <summary>
        /// Gets and sets the Name property.
        /// Name of the job flow. 1 to 255 characters.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">Name of the job flow. 1 to 255 characters.</param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithName(string name)
        {
            this.nameField = name;
            return this;
        }

        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public bool IsSetName()
        {
            return this.nameField != null;
        }

        /// <summary>
        /// Gets and sets the LogUri property.
        /// URI for the log files. If you do not provide a value, logs are not generated. Valid Form: bucket_name
        /// /key_prefix Constraint: bucket_name must be less than 256 characters and key_prefix must be less than 1025 characters.
        /// </summary>
        [XmlElementAttribute(ElementName = "LogUri")]
        public string LogUri
        {
            get { return this.logUriField; }
            set { this.logUriField = value; }
        }

        /// <summary>
        /// Sets the LogUri property
        /// </summary>
        /// <param name="logUri">URI for the log files. If you do not provide a value, logs are not generated. Valid Form: bucket_name
        /// /key_prefix Constraint: bucket_name must be less than 256 characters and key_prefix must be less than 1025 characters.</param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithLogUri(string logUri)
        {
            this.logUriField = logUri;
            return this;
        }

        /// <summary>
        /// Checks if LogUri property is set
        /// </summary>
        /// <returns>true if LogUri property is set</returns>
        public bool IsSetLogUri()
        {
            return this.logUriField != null;
        }

        /// <summary>
        /// Gets and sets the Instances property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Instances")]
        public JobFlowInstancesConfig Instances
        {
            get { return this.instancesField; }
            set { this.instancesField = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">Instances property</param>
        /// <returns>this instance</returns>
        public RunJobFlowRequest WithInstances(JobFlowInstancesConfig instances)
        {
            this.instancesField = instances;
            return this;
        }

        /// <summary>
        /// Checks if Instances property is set
        /// </summary>
        /// <returns>true if Instances property is set</returns>
        public bool IsSetInstances()
        {
            return this.instancesField != null;
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
        public RunJobFlowRequest WithSteps(params StepConfig[] list)
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
