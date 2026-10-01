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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetCell operation.
    /// </summary>
    public partial class GetCellResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CellArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the cell.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string CellArn { get; set; }

        /// <summary>
        /// Checks to see if the CellArn property is set.
        /// </summary>
        internal bool IsSetCellArn() => this.CellArn != null;

        /// <summary>
        /// Gets and sets the property CellName. 
        /// <para>
        /// The name of the cell.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string CellName { get; set; }

        /// <summary>
        /// Checks to see if the CellName property is set.
        /// </summary>
        internal bool IsSetCellName() => this.CellName != null;

        /// <summary>
        /// Gets and sets the property Cells. 
        /// <para>
        /// A list of cell ARNs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Cells { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Cells property is set.
        /// </summary>
        internal bool IsSetCells() => this.Cells != null && (this.Cells.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentReadinessScopes. 
        /// <para>
        /// The readiness scope for the cell, which can be a cell Amazon Resource Name (ARN) or
        /// a recovery group ARN. This is a list but currently can have only one element.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ParentReadinessScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ParentReadinessScopes property is set.
        /// </summary>
        internal bool IsSetParentReadinessScopes() => this.ParentReadinessScopes != null && (this.ParentReadinessScopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags on the resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
