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
    /// Details about a sequence.
    /// </summary>
    public partial class SequenceInformation
    {
        /// <summary>
        /// Gets and sets the property Alignment. 
        /// <para>
        /// The sequence's alignment setting.
        /// </para>
        /// </summary>
        public string Alignment { get; set; }

        /// <summary>
        /// Checks to see if the Alignment property is set.
        /// </summary>
        internal bool IsSetAlignment() => this.Alignment != null;

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        /// Where the sequence originated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string GeneratedFrom { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedFrom property is set.
        /// </summary>
        internal bool IsSetGeneratedFrom() => this.GeneratedFrom != null;

        /// <summary>
        /// Gets and sets the property TotalBaseCount. 
        /// <para>
        /// The sequence's total base count.
        /// </para>
        /// </summary>
        public long? TotalBaseCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalBaseCount property is set.
        /// </summary>
        internal bool IsSetTotalBaseCount() => this.TotalBaseCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalReadCount. 
        /// <para>
        /// The sequence's total read count.
        /// </para>
        /// </summary>
        public long? TotalReadCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalReadCount property is set.
        /// </summary>
        internal bool IsSetTotalReadCount() => this.TotalReadCount.HasValue;
    }
}
