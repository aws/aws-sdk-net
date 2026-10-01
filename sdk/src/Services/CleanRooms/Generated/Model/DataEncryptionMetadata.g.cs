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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The settings for client-side encryption for cryptographic computing.
    /// </summary>
    public partial class DataEncryptionMetadata
    {
        /// <summary>
        /// Gets and sets the property AllowCleartext. 
        /// <para>
        /// Indicates whether encrypted tables can contain cleartext data (<c>TRUE</c>) or are
        /// to cryptographically process every column (<c>FALSE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowCleartext { get; set; }

        /// <summary>
        /// Checks to see if the AllowCleartext property is set.
        /// </summary>
        internal bool IsSetAllowCleartext() => this.AllowCleartext.HasValue;

        /// <summary>
        /// Gets and sets the property AllowDuplicates. 
        /// <para>
        /// Indicates whether Fingerprint columns can contain duplicate entries (<c>TRUE</c>)
        /// or are to contain only non-repeated values (<c>FALSE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowDuplicates { get; set; }

        /// <summary>
        /// Checks to see if the AllowDuplicates property is set.
        /// </summary>
        internal bool IsSetAllowDuplicates() => this.AllowDuplicates.HasValue;

        /// <summary>
        /// Gets and sets the property AllowJoinsOnColumnsWithDifferentNames. 
        /// <para>
        /// Indicates whether Fingerprint columns can be joined on any other Fingerprint column
        /// with a different name (<c>TRUE</c>) or can only be joined on Fingerprint columns of
        /// the same name (<c>FALSE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AllowJoinsOnColumnsWithDifferentNames { get; set; }

        /// <summary>
        /// Checks to see if the AllowJoinsOnColumnsWithDifferentNames property is set.
        /// </summary>
        internal bool IsSetAllowJoinsOnColumnsWithDifferentNames() => this.AllowJoinsOnColumnsWithDifferentNames.HasValue;

        /// <summary>
        /// Gets and sets the property PreserveNulls. 
        /// <para>
        /// Indicates whether NULL values are to be copied as NULL to encrypted tables (<c>TRUE</c>)
        /// or cryptographically processed (<c>FALSE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? PreserveNulls { get; set; }

        /// <summary>
        /// Checks to see if the PreserveNulls property is set.
        /// </summary>
        internal bool IsSetPreserveNulls() => this.PreserveNulls.HasValue;
    }
}
