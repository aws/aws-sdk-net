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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Provides configuration parameters for PII entity redaction.
    /// </summary>
    public partial class RedactionConfig
    {
        private string _maskCharacter;
        private PiiEntitiesDetectionMaskMode _maskMode;
        private List<string> _piiEntityTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaskCharacter. 
        /// <para>
        /// A character that replaces each character in the redacted PII entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public string MaskCharacter
        {
            get { return this._maskCharacter; }
            set { this._maskCharacter = value; }
        }

        // Check to see if MaskCharacter property is set
        internal bool IsSetMaskCharacter()
        {
            return this._maskCharacter != null;
        }

        /// <summary>
        /// Gets and sets the property MaskMode. 
        /// <para>
        /// Specifies whether the PII entity is redacted with the mask character or the entity
        /// type.
        /// </para>
        /// </summary>
        public PiiEntitiesDetectionMaskMode MaskMode
        {
            get { return this._maskMode; }
            set { this._maskMode = value; }
        }

        // Check to see if MaskMode property is set
        internal bool IsSetMaskMode()
        {
            return this._maskMode != null;
        }

        /// <summary>
        /// Gets and sets the property PiiEntityTypes. 
        /// <para>
        /// An array of the types of PII entities that Amazon Comprehend detects in the input
        /// text for your request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PiiEntityTypes
        {
            get { return this._piiEntityTypes; }
            set { this._piiEntityTypes = value; }
        }

        // Check to see if PiiEntityTypes property is set
        internal bool IsSetPiiEntityTypes()
        {
            return this._piiEntityTypes != null && (this._piiEntityTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}