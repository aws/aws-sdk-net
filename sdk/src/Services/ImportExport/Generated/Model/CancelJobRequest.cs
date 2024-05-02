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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
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
namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// This operation cancels a specified job. Only the job owner can cancel it. The operation
    /// fails if the job has already started or is complete.
    /// </summary>
    public partial class CancelJobRequest : AmazonImportExportRequest
    {
        private string _apiVersion;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property APIVersion.
        /// </summary>
        public string APIVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if APIVersion property is set
        internal bool IsSetAPIVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property JobId.
        /// </summary>
        [AWSProperty(Required=true)]
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