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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Configuration for using a custom note template with specific instructions
    /// </summary>
    public partial class CustomTemplate
    {
        private List<TemplateSectionInstruction> _templateInstructions = AWSConfigs.InitializeCollections ? new List<TemplateSectionInstruction>() : null;
        private CustomTemplateBase _templateType;

        /// <summary>
        /// Gets and sets the property TemplateInstructions. 
        /// <para>
        /// Custom instructions for each section of the template
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<TemplateSectionInstruction> TemplateInstructions
        {
            get { return this._templateInstructions; }
            set { this._templateInstructions = value; }
        }

        // Check to see if TemplateInstructions property is set
        internal bool IsSetTemplateInstructions()
        {
            return this._templateInstructions != null && (this._templateInstructions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateType. 
        /// <para>
        /// The base template type to customize
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomTemplateBase TemplateType
        {
            get { return this._templateType; }
            set { this._templateType = value; }
        }

        // Check to see if TemplateType property is set
        internal bool IsSetTemplateType()
        {
            return this._templateType != null;
        }

    }
}