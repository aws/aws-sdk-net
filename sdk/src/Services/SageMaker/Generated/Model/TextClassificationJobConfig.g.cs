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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The collection of settings used by an AutoML job V2 for the text classification problem
    /// type.
    /// </summary>
    public partial class TextClassificationJobConfig
    {
        /// <summary>
        /// Gets and sets the property CompletionCriteria. 
        /// <para>
        /// How long a job is allowed to run, or how many candidates a job is allowed to generate.
        /// </para>
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria { get; set; }

        /// <summary>
        /// Checks to see if the CompletionCriteria property is set.
        /// </summary>
        internal bool IsSetCompletionCriteria() => this.CompletionCriteria != null;

        /// <summary>
        /// Gets and sets the property ContentColumn. 
        /// <para>
        /// The name of the column used to provide the sentences to be classified. It should not
        /// be the same as the target column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContentColumn { get; set; }

        /// <summary>
        /// Checks to see if the ContentColumn property is set.
        /// </summary>
        internal bool IsSetContentColumn() => this.ContentColumn != null;

        /// <summary>
        /// Gets and sets the property TargetLabelColumn. 
        /// <para>
        /// The name of the column used to provide the class labels. It should not be same as
        /// the content column.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string TargetLabelColumn { get; set; }

        /// <summary>
        /// Checks to see if the TargetLabelColumn property is set.
        /// </summary>
        internal bool IsSetTargetLabelColumn() => this.TargetLabelColumn != null;
    }
}
