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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about the unreferenced file removal settings for an Iceberg table
    /// bucket.
    /// </summary>
    public partial class IcebergUnreferencedFileRemovalSettings
    {
        /// <summary>
        /// Gets and sets the property NonCurrentDays. 
        /// <para>
        /// The number of days an object has to be non-current before it is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? NonCurrentDays { get; set; }

        /// <summary>
        /// Checks to see if the NonCurrentDays property is set.
        /// </summary>
        internal bool IsSetNonCurrentDays() => this.NonCurrentDays.HasValue;

        /// <summary>
        /// Gets and sets the property UnreferencedDays. 
        /// <para>
        /// The number of days an object has to be unreferenced before it is marked as non-current.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? UnreferencedDays { get; set; }

        /// <summary>
        /// Checks to see if the UnreferencedDays property is set.
        /// </summary>
        internal bool IsSetUnreferencedDays() => this.UnreferencedDays.HasValue;
    }
}
