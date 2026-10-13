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
    /// Container for the parameters to the CreateRLSPolicy operation. Creates a row-level
    /// security (RLS) policy. A row-level security policy defines a filter expression that
    /// Lake Formation evaluates to determine which rows of a table a principal is allowed
    /// to see. The policy is created independently of any resource, and is later associated
    /// with a resource and principal using <c>AttachRLSPolicy</c>.
    /// </summary>
    public partial class CreateRLSPolicyRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property AttachmentColumns. 
        /// <para>
        /// The list of columns that the filter expression references. These columns define the
        /// shape of the data that the policy can be attached to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<Column> AttachmentColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<Column>() : null;

        /// <summary>
        /// Checks to see if the AttachmentColumns property is set.
        /// </summary>
        internal bool IsSetAttachmentColumns() => this.AttachmentColumns != null && (this.AttachmentColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterExpression. 
        /// <para>
        /// A filter predicate, written in a SQL-like syntax, that Lake Formation evaluates against
        /// each row. Only the rows for which the expression evaluates to true are returned to
        /// the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string FilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the FilterExpression property is set.
        /// </summary>
        internal bool IsSetFilterExpression() => this.FilterExpression != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the row-level security policy within the Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
