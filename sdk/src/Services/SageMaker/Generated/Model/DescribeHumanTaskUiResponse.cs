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
    /// This is the response object from the DescribeHumanTaskUi operation.
    /// </summary>
    public partial class DescribeHumanTaskUiResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _humanTaskUiArn;
        private string _humanTaskUiName;
        private HumanTaskUiStatus _humanTaskUiStatus;
        private UiTemplateInfo _uiTemplate;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the human task user interface was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HumanTaskUiArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human task user interface (worker task template).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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
        /// Gets and sets the property HumanTaskUiName. 
        /// <para>
        /// The name of the human task user interface (worker task template).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanTaskUiName
        {
            get { return this._humanTaskUiName; }
            set { this._humanTaskUiName = value; }
        }

        // Check to see if HumanTaskUiName property is set
        internal bool IsSetHumanTaskUiName()
        {
            return this._humanTaskUiName != null;
        }

        /// <summary>
        /// Gets and sets the property HumanTaskUiStatus. 
        /// <para>
        /// The status of the human task user interface (worker task template). Valid values are
        /// listed below.
        /// </para>
        /// </summary>
        public HumanTaskUiStatus HumanTaskUiStatus
        {
            get { return this._humanTaskUiStatus; }
            set { this._humanTaskUiStatus = value; }
        }

        // Check to see if HumanTaskUiStatus property is set
        internal bool IsSetHumanTaskUiStatus()
        {
            return this._humanTaskUiStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UiTemplate.
        /// </summary>
        [AWSProperty(Required=true)]
        public UiTemplateInfo UiTemplate
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