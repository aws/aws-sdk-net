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
    /// Container for the parameters to the CreateHumanTaskUi operation.
    /// Defines the settings you will use for the human review workflow user interface. Reviewers
    /// will see a three-panel interface with an instruction area, the item to review, and
    /// an input area.
    /// </summary>
    public partial class CreateHumanTaskUiRequest : AmazonSageMakerRequest
    {
        private string _humanTaskUiName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private UiTemplate _uiTemplate;

        /// <summary>
        /// Gets and sets the property HumanTaskUiName. 
        /// <para>
        /// The name of the user interface you are creating.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs that contain metadata to help you categorize and organize
        /// a human review workflow user interface. Each tag consists of a key and a value, both
        /// of which you define.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UiTemplate.
        /// </summary>
        [AWSProperty(Required=true)]
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