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
    /// Exports a running or stopped instance to an Amazon S3 bucket.
    /// </summary>
    /// <remarks>
    /// Creates a new export task, produces an image of an EC2 instance for use in another virtualization environment, and 
    /// then writes the image to the specified Amazon S3 bucket. If the instance is running at the time of export, Amazon EC2 
    /// will attempt to shut down the instance, initiate the export process, and then reboot the instance. Only instances derived 
    /// from your own ImportInstance tasks may be exported. When the task is complete, the image can be downloaded from your 
    /// Amazon S3 bucket.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateInstanceExportTaskRequest
    {
        private string descriptionField;
        private string instanceIdField;
        private string targetEnvironmentField;
        private ExportToS3TaskType exportToS3TaskTypeField;

        /// <summary>
        /// A description of the conversion task or the resource being exported.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the conversion task or the resource being exported.
        /// </summary>
        /// <param name="description">Description</param>
        /// <returns>this instance</returns>
        public CreateInstanceExportTaskRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if the Description property is set
        /// </summary>
        /// <returns>True if the Description property is set</returns>
        public bool IsSetDescription()
        {
            return !string.IsNullOrEmpty(this.descriptionField);
        }

        /// <summary>
        /// The ID of the instance being exported.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance being exported.
        /// </summary>
        /// <param name="instanceId">Id of the instance to export</param>
        /// <returns>this instance</returns>
        public CreateInstanceExportTaskRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceId property is set
        /// </summary>
        /// <returns>True if the InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return !string.IsNullOrEmpty(this.instanceIdField);
        }

        /// <summary>
        /// The target virtualization environment
        /// </summary>
        /// <remarks>Valid Values: vmware | citrix | microsoft</remarks>
        [XmlElementAttribute(ElementName = "TargetEnvironment")]
        public string TargetEnvironment
        {
            get { return this.targetEnvironmentField; }
            set { this.targetEnvironmentField = value; }
        }

        /// <summary>
        /// Sets the target virtualization environment
        /// </summary>
        /// <param name="targetEnvironment">Target environment; valid values: vmware | citrix | microsoft</param>
        /// <returns>this instance</returns>
        public CreateInstanceExportTaskRequest WithTargetEnvironment(string targetEnvironment)
        {
            this.targetEnvironmentField = targetEnvironment;
            return this;
        }

        /// <summary>
        /// Checks if the TargetEnvironment property is set
        /// </summary>
        /// <returns>True if the TargetEnvironment property is set</returns>
        public bool IsSetTargetEnvironment()
        {
            return !string.IsNullOrEmpty(this.targetEnvironmentField);
        }

        /// <summary>
        /// Details of the S3 object to be written on export
        /// </summary>
        [XmlElementAttribute(ElementName = "ExportToS3TaskType")]
        public ExportToS3TaskType ExportToS3Task
        {
            get { return this.exportToS3TaskTypeField; }
            set { this.exportToS3TaskTypeField = value; }
        }

        /// <summary>
        /// Sets the details of the S3 object to be written on export.
        /// </summary>
        /// <param name="exportToS3TaskType"></param>
        /// <returns>this instance</returns>
        public CreateInstanceExportTaskRequest WithExportToS3Task(ExportToS3TaskType exportToS3TaskType)
        {
            this.exportToS3TaskTypeField = exportToS3TaskType;
            return this;
        }

        /// <summary>
        /// Checks if the ExportToS3Task property is set
        /// </summary>
        /// <returns>True if the ExportToS3Task property is set</returns>
        public bool IsSetExportToS3Task()
        {
            return this.exportToS3TaskTypeField != null;
        }
    }
}
