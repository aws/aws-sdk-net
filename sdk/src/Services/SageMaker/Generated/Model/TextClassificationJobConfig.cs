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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Stores the configuration information for the text classification problem of an AutoML
    /// job using the V2 API.
    /// </summary>
    public partial class TextClassificationJobConfig
    {
        private AutoMLJobCompletionCriteria _completionCriteria;
        private string _contentColumn;
        private string _targetLabelColumn;

        /// <summary>
        /// Gets and sets the property CompletionCriteria. 
        /// <para>
        /// How long a job is allowed to run, or how many candidates a job is allowed to generate.
        /// </para>
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property ContentColumn. 
        /// <para>
        /// The name of the column used to provide the sentences to be classified. It should not
        /// be the same as the target column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContentColumn
        {
            get { return this._contentColumn; }
            set { this._contentColumn = value; }
        }

        // Check to see if ContentColumn property is set
        internal bool IsSetContentColumn()
        {
            return this._contentColumn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLabelColumn. 
        /// <para>
        /// The name of the column used to provide the class labels. It should not be same as
        /// the content column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TargetLabelColumn
        {
            get { return this._targetLabelColumn; }
            set { this._targetLabelColumn = value; }
        }

        // Check to see if TargetLabelColumn property is set
        internal bool IsSetTargetLabelColumn()
        {
            return this._targetLabelColumn != null;
        }

    }
}