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
    ///<summary>
    ///Information about a job flow.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticmapreduce.amazonaws.com/doc/2009-03-31", IsNullable = false)]
    public class JobFlowDetail
    {
        private string jobFlowIdField;
        private string nameField;
        private string logUriField;
        private JobFlowExecutionStatusDetail executionStatusDetailField;
        private JobFlowInstancesDetail instancesField;
        private List<StepDetail> stepsField;

        /// <summary>
        /// Gets and sets the JobFlowId property.
        /// ID that uniquely identifies the job flow.
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
        /// <param name="jobFlowId">ID that uniquely identifies the job flow.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithJobFlowId(string jobFlowId)
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
        /// Gets and sets the Name property.
        /// Name of the job flow.
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
        /// <param name="name">Name of the job flow.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithName(string name)
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
        /// URI for the location of the log files on Amazon S3. Amazon S3 URIs are of the form: bucketName/optionalPathToObject.
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
        /// <param name="logUri">URI for the location of the log files on Amazon S3. Amazon S3 URIs are of the form: bucketName/optionalPathToObject.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithLogUri(string logUri)
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
        /// Gets and sets the ExecutionStatusDetail property.
        /// Container for the description of the execution status.
        /// </summary>
        [XmlElementAttribute(ElementName = "ExecutionStatusDetail")]
        public JobFlowExecutionStatusDetail ExecutionStatusDetail
        {
            get { return this.executionStatusDetailField; }
            set { this.executionStatusDetailField = value; }
        }

        /// <summary>
        /// Sets the ExecutionStatusDetail property
        /// </summary>
        /// <param name="executionStatusDetail">Container for the description of the execution status.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithExecutionStatusDetail(JobFlowExecutionStatusDetail executionStatusDetail)
        {
            this.executionStatusDetailField = executionStatusDetail;
            return this;
        }

        /// <summary>
        /// Checks if ExecutionStatusDetail property is set
        /// </summary>
        /// <returns>true if ExecutionStatusDetail property is set</returns>
        public bool IsSetExecutionStatusDetail()
        {
            return this.executionStatusDetailField != null;
        }

        /// <summary>
        /// Gets and sets the Instances property.
        /// Container for JobFlowInstancesDetail.
        /// </summary>
        [XmlElementAttribute(ElementName = "Instances")]
        public JobFlowInstancesDetail Instances
        {
            get { return this.instancesField; }
            set { this.instancesField = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="instances">Container for JobFlowInstancesDetail.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithInstances(JobFlowInstancesDetail instances)
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
        /// A list of steps associated with the job.
        /// </summary>
        [XmlElementAttribute(ElementName = "Steps")]
        public List<StepDetail> Steps
        {
            get
            {
                if (this.stepsField == null)
                {
                    this.stepsField = new List<StepDetail>();
                }
                return this.stepsField;
            }
            set { this.stepsField = value; }
        }

        /// <summary>
        /// Sets the Steps property
        /// </summary>
        /// <param name="list">A list of steps associated with the job.</param>
        /// <returns>this instance</returns>
        public JobFlowDetail WithSteps(params StepDetail[] list)
        {
            foreach (StepDetail item in list)
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
