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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the RenderUiTemplate operation.
    /// Renders the UI template so that you can preview the worker's experience.
    /// </summary>
    public partial class RenderUiTemplateRequest : AmazonSageMakerRequest
    {
        private string _humanTaskUiArn;
        private string _roleArn;
        private RenderableTask _task;
        private UiTemplate _uiTemplate;

        /// <summary>
        /// Gets and sets the property HumanTaskUiArn. 
        /// <para>
        /// The <c>HumanTaskUiArn</c> of the worker UI that you want to render. Do not provide
        /// a <c>HumanTaskUiArn</c> if you use the <c>UiTemplate</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// See a list of available Human Ui Amazon Resource Names (ARNs) in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_UiConfig.html">UiConfig</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string HumanTaskUiArn
        {
            get { return this._humanTaskUiArn; }
            set { this._humanTaskUiArn = value; }
        }

        // Check to see if HumanTaskUiArn property is set
        internal bool IsSetHumanTaskUiArn()
        {
            return this._humanTaskUiArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that has access to the S3 objects that are used by
        /// the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// A <c>RenderableTask</c> object containing a representative task to render.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A <c>Template</c> object containing the worker UI template to render.
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