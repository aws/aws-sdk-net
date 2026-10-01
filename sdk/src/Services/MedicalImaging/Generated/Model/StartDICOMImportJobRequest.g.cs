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
    /// Container for the parameters to the StartDICOMImportJob operation. Start importing
    /// bulk data into an <c>ACTIVE</c> data store. The import job imports DICOM P10 files
    /// or enhances existing DICOM files with JSON metadata. The <c>importConfiguration</c>
    /// parameter specifies the import type. The data is found in the S3 prefix specified
    /// by the <c>inputS3Uri</c> parameter. The import job stores processing results in the
    /// file specified by the <c>outputS3Uri</c> parameter.
    /// </summary>
    public partial class StartDICOMImportJobRequest : AmazonMedicalImagingRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for API idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants permission to access medical
        /// imaging resources.
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
        /// Gets and sets the property ImportConfiguration. 
        /// <para>
        /// The import configuration for the import job.
        /// </para>
        /// </summary>
        public ImportConfiguration ImportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImportConfiguration property is set.
        /// </summary>
        internal bool IsSetImportConfiguration() => this.ImportConfiguration != null;

        /// <summary>
        /// Gets and sets the property InputOwnerAccountId. 
        /// <para>
        /// The account ID of the source S3 bucket owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string InputOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the InputOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetInputOwnerAccountId() => this.InputOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property InputS3Uri. 
        /// <para>
        /// The input prefix path for the S3 bucket that contains the DICOM files to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string InputS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the InputS3Uri property is set.
        /// </summary>
        internal bool IsSetInputS3Uri() => this.InputS3Uri != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The import job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

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
    }
}
