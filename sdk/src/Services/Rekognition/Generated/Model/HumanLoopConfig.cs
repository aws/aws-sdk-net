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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Sets up the flow definition the image will be sent to if one of the conditions is
    /// met. You can also set certain attributes of the image before review.
    /// </summary>
    public partial class HumanLoopConfig
    {
        private HumanLoopDataAttributes _dataAttributes;
        private string _flowDefinitionArn;
        private string _humanLoopName;

        /// <summary>
        /// Gets and sets the property DataAttributes. 
        /// <para>
        /// Sets attributes of the input data.
        /// </para>
        /// </summary>
        public HumanLoopDataAttributes DataAttributes
        {
            get { return this._dataAttributes; }
            set { this._dataAttributes = value; }
        }

        // Check to see if DataAttributes property is set
        internal bool IsSetDataAttributes()
        {
            return this._dataAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property FlowDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow definition. You can create a flow definition
        /// by using the Amazon Sagemaker <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateFlowDefinition.html">CreateFlowDefinition</a>
        /// Operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string FlowDefinitionArn
        {
            get { return this._flowDefinitionArn; }
            set { this._flowDefinitionArn = value; }
        }

        // Check to see if FlowDefinitionArn property is set
        internal bool IsSetFlowDefinitionArn()
        {
            return this._flowDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopName. 
        /// <para>
        /// The name of the human review used for this image. This should be kept unique within
        /// a region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string HumanLoopName
        {
            get { return this._humanLoopName; }
            set { this._humanLoopName = value; }
        }

        // Check to see if HumanLoopName property is set
        internal bool IsSetHumanLoopName()
        {
            return this._humanLoopName != null;
        }

    }
}