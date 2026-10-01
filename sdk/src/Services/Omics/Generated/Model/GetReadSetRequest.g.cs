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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the GetReadSet operation. Retrieves detailed information
    /// from parts of a read set and returns the read set in the same format that it was uploaded.
    /// You must have read sets uploaded to your sequence store in order to run this operation.
    /// </summary>
    public partial class GetReadSetRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// The file to retrieve.
        /// </para>
        /// </summary>
        public ReadSetFile File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The read set's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PartNumber. 
        /// <para>
        /// The part number to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10000)]
        public int? PartNumber { get; set; }

        /// <summary>
        /// Checks to see if the PartNumber property is set.
        /// </summary>
        internal bool IsSetPartNumber() => this.PartNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The read set's sequence store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string SequenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the SequenceStoreId property is set.
        /// </summary>
        internal bool IsSetSequenceStoreId() => this.SequenceStoreId != null;
    }
}
