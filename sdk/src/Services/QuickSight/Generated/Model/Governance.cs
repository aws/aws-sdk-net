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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Contains the governance configuration for a custom permissions profile. When governance
    /// controls are defined for a category, any capabilities in that category not explicitly
    /// set to <c>ALLOW</c> in <c>Capabilities</c> are denied. Even newly added capabilities
    /// in the category are implicitly disabled when Amazon Quick releases them.
    /// </summary>
    public partial class Governance
    {
        private Dictionary<string, string> _defaultCategoryEffects = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultCategoryEffects. 
        /// <para>
        /// A map of <c>DefaultCategoryEffects</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> DefaultCategoryEffects
        {
            get { return this._defaultCategoryEffects; }
            set { this._defaultCategoryEffects = value; }
        }

        // Check to see if DefaultCategoryEffects property is set
        internal bool IsSetDefaultCategoryEffects()
        {
            return this._defaultCategoryEffects != null && (this._defaultCategoryEffects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}