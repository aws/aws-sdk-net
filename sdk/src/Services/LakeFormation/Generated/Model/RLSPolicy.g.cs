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
    /// A structure that describes a row-level security policy, including the columns its
    /// filter expression references and the filter expression itself.
    /// </summary>
    public partial class RLSPolicy
    {
        /// <summary>
        /// Gets and sets the property AttachmentColumns. 
        /// <para>
        /// The list of columns that the filter expression references.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Column> AttachmentColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<Column>() : null;

        /// <summary>
        /// Checks to see if the AttachmentColumns property is set.
        /// </summary>
        internal bool IsSetAttachmentColumns() => this.AttachmentColumns != null && (this.AttachmentColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog that contains the policy. By default, the account
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// The filter predicate, written in a SQL-like syntax, that determines which rows are
        /// returned to the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string FilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpression property is set.
        /// </summary>
        internal bool IsSetFilterExpression() => this.FilterExpression != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the row-level security policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
