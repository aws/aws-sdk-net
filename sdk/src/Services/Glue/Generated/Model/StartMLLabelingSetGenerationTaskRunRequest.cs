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
    /// Container for the parameters to the StartMLLabelingSetGenerationTaskRun operation.
    /// Starts the active learning workflow for your machine learning transform to improve
    /// the transform's quality by generating label sets and adding labels.
    /// 
    ///  
    /// <para>
    /// When the <c>StartMLLabelingSetGenerationTaskRun</c> finishes, Glue will have generated
    /// a "labeling set" or a set of questions for humans to answer.
    /// </para>
    ///  
    /// <para>
    /// In the case of the <c>FindMatches</c> transform, these questions are of the form,
    /// “What is the correct way to group these rows together into groups composed entirely
    /// of matching records?” 
    /// </para>
    ///  
    /// <para>
    /// After the labeling process is finished, you can upload your labels with a call to
    /// <c>StartImportLabelsTaskRun</c>. After <c>StartImportLabelsTaskRun</c> finishes, all
    /// future runs of the machine learning transform will use the new and improved labels
    /// and perform a higher-quality transformation.
    /// </para>
    ///  
    /// <para>
    /// Note: The role used to write the generated labeling set to the <c>OutputS3Path</c>
    /// is the role associated with the Machine Learning Transform, specified in the <c>CreateMLTransform</c>
    /// API.
    /// </para>
    /// </summary>
    public partial class StartMLLabelingSetGenerationTaskRunRequest : AmazonGlueRequest
    {
        private string _outputS3Path;
        private string _transformId;

        /// <summary>
        /// Gets and sets the property OutputS3Path. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path where you generate the labeling
        /// set.
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