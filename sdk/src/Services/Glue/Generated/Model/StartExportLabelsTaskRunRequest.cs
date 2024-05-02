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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the StartExportLabelsTaskRun operation.
    /// Begins an asynchronous task to export all labeled data for a particular transform.
    /// This task is the only label-related API call that is not part of the typical active
    /// learning workflow. You typically use <c>StartExportLabelsTaskRun</c> when you want
    /// to work with all of your existing labels at the same time, such as when you want to
    /// remove or change labels that were previously submitted as truth. This API operation
    /// accepts the <c>TransformId</c> whose labels you want to export and an Amazon Simple
    /// Storage Service (Amazon S3) path to export the labels to. The operation returns a
    /// <c>TaskRunId</c>. You can check on the status of your task run by calling the <c>GetMLTaskRun</c>
    /// API.
    /// </summary>
    public partial class StartExportLabelsTaskRunRequest : AmazonGlueRequest
    {
        private string _outputS3Path;
        private string _transformId;

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The Amazon S3 path where you export the labels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Path
        {
            get { return this._outputS3Path; }
            set { this._outputS3Path = value; }
        }

        // Check to see if OutputS3Path property is set
        internal bool IsSetOutputS3Path()
        {
            return this._outputS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property TransformId. 
        /// <para>
        /// The unique identifier of the machine learning transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TransformId
        {
            get { return this._transformId; }
            set { this._transformId = value; }
        }

        // Check to see if TransformId property is set
        internal bool IsSetTransformId()
        {
            return this._transformId != null;
        }

    }
}