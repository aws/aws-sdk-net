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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
    /// Container for the parameters to the StartDICOMImportJob operation.
    /// Start importing bulk data into an <c>ACTIVE</c> data store. The import job imports
    /// DICOM P10 files found in the S3 prefix specified by the <c>inputS3Uri</c> parameter.
    /// The import job stores processing results in the file specified by the <c>outputS3Uri</c>
    /// parameter.
    /// </summary>
    public partial class StartDICOMImportJobRequest : AmazonMedicalImagingRequest
    {
        private string _clientToken;
        private string _dataAccessRoleArn;
        private string _datastoreId;
        private string _inputOwnerAccountId;
        private string _inputs3Uri;
        private string _jobName;
        private string _outputs3Uri;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for API idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants permission to access medical
        /// imaging resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property InputOwnerAccountId. 
        /// <para>
        /// The account ID of the source S3 bucket owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string InputOwnerAccountId
        {
            get { return this._inputOwnerAccountId; }
            set { this._inputOwnerAccountId = value; }
        }

        // Check to see if InputOwnerAccountId property is set
        internal bool IsSetInputOwnerAccountId()
        {
            return this._inputOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property InputS3Uri. 
        /// <para>
        /// The input prefix path for the S3 bucket that contains the DICOM files to be imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string InputS3Uri
        {
            get { return this._inputs3Uri; }
            set { this._inputs3Uri = value; }
        }

        // Check to see if InputS3Uri property is set
        internal bool IsSetInputS3Uri()
        {
            return this._inputs3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The import job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The output prefix of the S3 bucket to upload the results of the DICOM import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string OutputS3Uri
        {
            get { return this._outputs3Uri; }
            set { this._outputs3Uri = value; }
        }

        // Check to see if OutputS3Uri property is set
        internal bool IsSetOutputS3Uri()
        {
            return this._outputs3Uri != null;
        }

    }
}