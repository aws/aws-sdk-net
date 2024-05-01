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
    /// Container for the parameters to the GetDICOMImportJob operation.
    /// Get the import job properties to learn more about the job or job progress.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>jobStatus</c> refers to the execution of the import job. Therefore, an import
    /// job can return a <c>jobStatus</c> as <c>COMPLETED</c> even if validation issues are
    /// discovered during the import process. If a <c>jobStatus</c> returns as <c>COMPLETED</c>,
    /// we still recommend you review the output manifests written to S3, as they provide
    /// details on the success or failure of individual P10 object imports.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDICOMImportJobRequest : AmazonMedicalImagingRequest
    {
        private string _datastoreId;
        private string _jobId;

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
        /// Gets and sets the property JobId. 
        /// <para>
        /// The import job identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}