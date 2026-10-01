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
    /// Container for the parameters to the GetReference operation. Downloads parts of data
    /// from a reference genome and returns the reference file in the same format that it
    /// was uploaded. <para> For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/create-reference-store.html">Creating
    /// a HealthOmics reference store</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetReferenceRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// The file to retrieve.
        /// </para>
        /// </summary>
        public ReferenceFile File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The reference's ID.
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
        /// Gets and sets the property Range. 
        /// <para>
        /// The range to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property ReferenceStoreId. 
        /// <para>
        /// The reference's store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string ReferenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceStoreId property is set.
        /// </summary>
        internal bool IsSetReferenceStoreId() => this.ReferenceStoreId != null;
    }
}
