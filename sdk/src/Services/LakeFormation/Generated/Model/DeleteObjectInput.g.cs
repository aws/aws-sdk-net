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
    /// An object to delete from the governed table.
    /// </summary>
    public partial class DeleteObjectInput
    {
        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The Amazon S3 ETag of the object. Returned by <c>GetTableObjects</c> for validation
        /// and used to identify changes to the underlying data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property PartitionValues. 
        /// <para>
        /// A list of partition values for the object. A value must be specified for each partition
        /// key associated with the governed table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> PartitionValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PartitionValues property is set.
        /// </summary>
        internal bool IsSetPartitionValues() => this.PartitionValues != null && (this.PartitionValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// The Amazon S3 location of the object to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Uri { get; set; }

        /// <summary>
        /// Checks to see if the Uri property is set.
        /// </summary>
        internal bool IsSetUri() => this.Uri != null;
    }
}
