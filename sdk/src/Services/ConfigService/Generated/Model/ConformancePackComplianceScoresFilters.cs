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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A list of filters to apply to the conformance pack compliance score result set.
    /// </summary>
    public partial class ConformancePackComplianceScoresFilters
    {
        private List<string> _conformancePackNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConformancePackNames. 
        /// <para>
        /// The names of the conformance packs whose compliance scores you want to include in
        /// the conformance pack compliance score result set. You can include up to 25 conformance
        /// packs in the <c>ConformancePackNames</c> array of strings, each with a character limit
        /// of 256 characters for the conformance pack name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> ConformancePackNames
        {
            get { return this._conformancePackNames; }
            set { this._conformancePackNames = value; }
        }

        // Check to see if ConformancePackNames property is set
        internal bool IsSetConformancePackNames()
        {
            return this._conformancePackNames != null && (this._conformancePackNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}