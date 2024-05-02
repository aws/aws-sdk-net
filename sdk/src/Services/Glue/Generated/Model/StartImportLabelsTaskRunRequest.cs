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
    /// Container for the parameters to the StartImportLabelsTaskRun operation.
    /// Enables you to provide additional labels (examples of truth) to be used to teach the
    /// machine learning transform and improve its quality. This API operation is generally
    /// used as part of the active learning workflow that starts with the <c>StartMLLabelingSetGenerationTaskRun</c>
    /// call and that ultimately results in improving the quality of your machine learning
    /// transform. 
    /// 
    ///  
    /// <para>
    /// After the <c>StartMLLabelingSetGenerationTaskRun</c> finishes, Glue machine learning
    /// will have generated a series of questions for humans to answer. (Answering these questions
    /// is often called 'labeling' in the machine learning workflows). In the case of the
    /// <c>FindMatches</c> transform, these questions are of the form, “What is the correct
    /// way to group these rows together into groups composed entirely of matching records?”
    /// After the labeling process is finished, users upload their answers/labels with a call
    /// to <c>StartImportLabelsTaskRun</c>. After <c>StartImportLabelsTaskRun</c> finishes,
    /// all future runs of the machine learning transform use the new and improved labels
    /// and perform a higher-quality transformation.
    /// </para>
    ///  
    /// <para>
    /// By default, <c>StartMLLabelingSetGenerationTaskRun</c> continually learns from and
    /// combines all labels that you upload unless you set <c>Replace</c> to true. If you
    /// set <c>Replace</c> to true, <c>StartImportLabelsTaskRun</c> deletes and forgets all
    /// previously uploaded labels and learns only from the exact set that you upload. Replacing
    /// labels can be helpful if you realize that you previously uploaded incorrect labels,
    /// and you believe that they are having a negative effect on your transform quality.
    /// </para>
    ///  
    /// <para>
    /// You can check on the status of your task run by calling the <c>GetMLTaskRun</c> operation.
    /// 
    /// </para>
    /// </summary>
    public partial class StartImportLabelsTaskRunRequest : AmazonGlueRequest
    {
        private string _inputS3Path;
        private bool? _replaceAllLabels;
        private string _transformId;

        /// <summary>
        /// Gets and sets the property InputS3Path. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path from where you import the labels.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputS3Path
        {
            get { return this._inputS3Path; }
            set { this._inputS3Path = value; }
        }

        // Check to see if InputS3Path property is set
        internal bool IsSetInputS3Path()
        {
            return this._inputS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceAllLabels. 
        /// <para>
        /// Indicates whether to overwrite your existing labels.
        /// </para>
        /// </summary>
        public bool? ReplaceAllLabels
        {
            get { return this._replaceAllLabels; }
            set { this._replaceAllLabels = value; }
        }

        // Check to see if ReplaceAllLabels property is set
        internal bool IsSetReplaceAllLabels()
        {
            return this._replaceAllLabels.HasValue; 
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