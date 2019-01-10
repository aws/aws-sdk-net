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
    /// Container for the parameters to the RenderUiTemplate operation.
    /// Renders the UI template so that you can preview the worker's experience.
    /// </summary>
    public partial class RenderUiTemplateRequest : AmazonSageMakerRequest
    {
        private string _roleArn;
        private RenderableTask _task;
        private UiTemplate _uiTemplate;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that has access to the S3 objects that are used by
        /// the template.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// A <code>RenderableTask</code> object containing a representative task to render.
        /// </para>
        /// </summary>
        public RenderableTask Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

        /// <summary>
        /// Gets and sets the property UiTemplate. 
        /// <para>
        /// A <code>Template</code> object containing the worker UI template to render.
        /// </para>
        /// </summary>
        public UiTemplate UiTemplate
        {
            get { return this._uiTemplate; }
            set { this._uiTemplate = value; }
        }

        // Check to see if UiTemplate property is set
        internal bool IsSetUiTemplate()
        {
            return this._uiTemplate != null;
        }

    }
}