/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Properties of the import job.
    /// </summary>
    public partial class DICOMImportJobProperties
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that grants permissions to access medical imaging resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp for when the import job was ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ImportConfiguration. 
        /// <para>
        /// The object containing <c>DicomJsonMetadataImportConfiguration</c>.
        /// </para>
        /// </summary>
        public ImportConfiguration ImportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImportConfiguration property is set.
        /// </summary>
        internal bool IsSetImportConfiguration() => this.ImportConfiguration != null;

        /// <summary>
        /// Gets and sets the property InputS3Uri. 
        /// <para>
        /// The input prefix path for the S3 bucket that contains the DICOM P10 files to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InputS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the InputS3Uri property is set.
        /// </summary>
        internal bool IsSetInputS3Uri() => this.InputS3Uri != null;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The import job identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The import job name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The filters for listing import jobs based on status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message thrown if an import job fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The output prefix of the S3 bucket to upload the results of the DICOM import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string OutputS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Uri property is set.
        /// </summary>
        internal bool IsSetOutputS3Uri() => this.OutputS3Uri != null;

        /// <summary>
        /// Gets and sets the property SubmittedAt. 
        /// <para>
        /// The timestamp for when the import job was submitted.
        /// </para>
        /// </summary>
        public DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedAt property is set.
        /// </summary>
        internal bool IsSetSubmittedAt() => this.SubmittedAt.HasValue;
    }
}
