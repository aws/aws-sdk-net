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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies how to group results by document attribute value, and how to display them
    /// collapsed/expanded under a designated primary document for each group.
    /// </summary>
    public partial class CollapseConfiguration
    {
        /// <summary>
        /// Gets and sets the property DocumentAttributeKey. 
        /// <para>
        /// The document attribute used to group search results. You can use any attribute that
        /// has the <c>Sortable</c> flag set to true. You can also sort by any of the following
        /// built-in attributes:"_category","_created_at", "_last_updated_at", "_version", "_view_count".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string DocumentAttributeKey { get; set; }

        /// <summary>
        /// Checks to see if the DocumentAttributeKey property is set.
        /// </summary>
        internal bool IsSetDocumentAttributeKey() => this.DocumentAttributeKey != null;

        /// <summary>
        /// Gets and sets the property Expand. 
        /// <para>
        /// Specifies whether to expand the collapsed results.
        /// </para>
        /// </summary>
        public bool? Expand { get; set; }

        /// <summary>
        /// Checks to see if the Expand property is set.
        /// </summary>
        internal bool IsSetExpand() => this.Expand.HasValue;

        /// <summary>
        /// Gets and sets the property ExpandConfiguration. 
        /// <para>
        /// Provides configuration information to customize expansion options for a collapsed
        /// group.
        /// </para>
        /// </summary>
        public ExpandConfiguration ExpandConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExpandConfiguration property is set.
        /// </summary>
        internal bool IsSetExpandConfiguration() => this.ExpandConfiguration != null;

        /// <summary>
        /// Gets and sets the property MissingAttributeKeyStrategy. 
        /// <para>
        /// Specifies the behavior for documents without a value for the collapse attribute.
        /// </para>
        ///  
        /// <para>
        /// Amazon Kendra offers three customization options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose to <c>COLLAPSE</c> all documents with null or missing values in one group.
        /// This is the default configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose to <c>IGNORE</c> documents with null or missing values. Ignored documents will
        /// not appear in query results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose to <c>EXPAND</c> each document with a null or missing value into a group of
        /// its own.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MissingAttributeKeyStrategy MissingAttributeKeyStrategy { get; set; }

        /// <summary>
        /// Checks to see if the MissingAttributeKeyStrategy property is set.
        /// </summary>
        internal bool IsSetMissingAttributeKeyStrategy() => this.MissingAttributeKeyStrategy != null;

        /// <summary>
        /// Gets and sets the property SortingConfigurations. 
        /// <para>
        /// A prioritized list of document attributes/fields that determine the primary document
        /// among those in a collapsed group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<SortingConfiguration> SortingConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<SortingConfiguration>() : null;

        /// <summary>
        /// Checks to see if the SortingConfigurations property is set.
        /// </summary>
        internal bool IsSetSortingConfigurations() => this.SortingConfigurations != null && (this.SortingConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
