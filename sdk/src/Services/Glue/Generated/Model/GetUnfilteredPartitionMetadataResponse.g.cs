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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetUnfilteredPartitionMetadata operation.
    /// </summary>
    public partial class GetUnfilteredPartitionMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuthorizedColumns. 
        /// <para>
        /// A list of column names that the user has been granted access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizedColumns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedColumns property is set.
        /// </summary>
        internal bool IsSetAuthorizedColumns() => this.AuthorizedColumns != null && (this.AuthorizedColumns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsRegisteredWithLakeFormation. 
        /// <para>
        /// A Boolean value that indicates whether the partition location is registered with Lake
        /// Formation.
        /// </para>
        /// </summary>
        public bool? IsRegisteredWithLakeFormation { get; set; }

        /// <summary>
        /// Checks to see if the IsRegisteredWithLakeFormation property is set.
        /// </summary>
        internal bool IsSetIsRegisteredWithLakeFormation() => this.IsRegisteredWithLakeFormation.HasValue;

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// A Partition object containing the partition metadata.
        /// </para>
        /// </summary>
        public Partition Partition { get; set; }

        /// <summary>
        /// Checks to see if the Partition property is set.
        /// </summary>
        internal bool IsSetPartition() => this.Partition != null;
    }
}
