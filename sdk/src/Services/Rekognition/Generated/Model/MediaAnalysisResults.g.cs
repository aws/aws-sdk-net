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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Contains the results for a media analysis job created with StartMediaAnalysisJob.
    /// </summary>
    public partial class MediaAnalysisResults
    {
        /// <summary>
        /// Gets and sets the property ModelVersions. 
        /// <para>
        /// Information about the model versions for the features selected in a given job.
        /// </para>
        /// </summary>
        public MediaAnalysisModelVersions ModelVersions { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersions property is set.
        /// </summary>
        internal bool IsSetModelVersions() => this.ModelVersions != null;

        /// <summary>
        /// Gets and sets the property S3Object.
        /// </summary>
        public S3Object S3Object { get; set; }

        /// <summary>
        /// Checks to see if the S3Object property is set.
        /// </summary>
        internal bool IsSetS3Object() => this.S3Object != null;
    }
}
