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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure containing an LF-tag key-value pair.
    /// </summary>
    public partial class LFTagPair
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The key-name for the LF-tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValues. 
        /// <para>
        /// A list of possible values an attribute can take.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> TagValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TagValues property is set.
        /// </summary>
        internal bool IsSetTagValues() => this.TagValues != null && (this.TagValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
