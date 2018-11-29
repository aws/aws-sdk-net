/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provided configuration information for the worker UI for a labeling job.
    /// </summary>
    public partial class UiConfig
    {
        private string _uiTemplateS3Uri;

        /// <summary>
        /// Gets and sets the property UiTemplateS3Uri. 
        /// <para>
        /// The Amazon S3 bucket location of the UI template.
        /// </para>
        /// </summary>
        public string UiTemplateS3Uri
        {
            get { return this._uiTemplateS3Uri; }
            set { this._uiTemplateS3Uri = value; }
        }

        // Check to see if UiTemplateS3Uri property is set
        internal bool IsSetUiTemplateS3Uri()
        {
            return this._uiTemplateS3Uri != null;
        }

    }
}