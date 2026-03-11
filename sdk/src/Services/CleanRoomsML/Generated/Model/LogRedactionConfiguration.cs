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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The configuration for log redaction.
    /// </summary>
    public partial class LogRedactionConfiguration
    {
        private CustomEntityConfig _customEntityConfig;
        private List<string> _entitiesToRedact = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CustomEntityConfig. 
        /// <para>
        /// Specifies the configuration for custom entities in the context of log redaction.
        /// </para>
        /// </summary>
        public CustomEntityConfig CustomEntityConfig
        {
            get { return this._customEntityConfig; }
            set { this._customEntityConfig = value; }
        }

        // Check to see if CustomEntityConfig property is set
        internal bool IsSetCustomEntityConfig()
        {
            return this._customEntityConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EntitiesToRedact. 
        /// <para>
        /// Specifies the entities to be redacted from logs. Entities to redact are "ALL_PERSONALLY_IDENTIFIABLE_INFORMATION",
        /// "NUMBERS","CUSTOM". If CUSTOM is supplied or configured, custom patterns (customDataIdentifiers)
        /// should be provided, and the patterns will be redacted in logs or error messages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> EntitiesToRedact
        {
            get { return this._entitiesToRedact; }
            set { this._entitiesToRedact = value; }
        }

        // Check to see if EntitiesToRedact property is set
        internal bool IsSetEntitiesToRedact()
        {
            return this._entitiesToRedact != null && (this._entitiesToRedact.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}