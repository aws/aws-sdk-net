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
    /// This is the response object from the DescribeHumanTaskUi operation.
    /// </summary>
    public partial class DescribeHumanTaskUiResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the human task user interface was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property HumanTaskUiArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the human task user interface (worker task template).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string HumanTaskUiArn { get; set; }

        /// <summary>
        /// Checks to see if the HumanTaskUiArn property is set.
        /// </summary>
        internal bool IsSetHumanTaskUiArn() => this.HumanTaskUiArn != null;

        /// <summary>
        /// Gets and sets the property HumanTaskUiName. 
        /// <para>
        /// The name of the human task user interface (worker task template).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string HumanTaskUiName { get; set; }

        /// <summary>
        /// Checks to see if the HumanTaskUiName property is set.
        /// </summary>
        internal bool IsSetHumanTaskUiName() => this.HumanTaskUiName != null;

        /// <summary>
        /// Gets and sets the property HumanTaskUiStatus. 
        /// <para>
        /// The status of the human task user interface (worker task template). Valid values are
        /// listed below.
        /// </para>
        /// </summary>
        public HumanTaskUiStatus HumanTaskUiStatus { get; set; }

        /// <summary>
        /// Checks to see if the HumanTaskUiStatus property is set.
        /// </summary>
        internal bool IsSetHumanTaskUiStatus() => this.HumanTaskUiStatus != null;

        /// <summary>
        /// Gets and sets the property UiTemplate.
        /// </summary>
        [AWSProperty(Required = true)]
        public UiTemplateInfo UiTemplate { get; set; }

        /// <summary>
        /// Checks to see if the UiTemplate property is set.
        /// </summary>
        internal bool IsSetUiTemplate() => this.UiTemplate != null;
    }
}
