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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Splice insert message configuration.
    /// </summary>
    public partial class SpliceInsertMessage
    {
        /// <summary>
        /// Gets and sets the property AvailNum. 
        /// <para>
        /// This is written to <c>splice_insert.avail_num</c>, as defined in section 9.7.3.1 of
        /// the SCTE-35 specification. The default value is <c>0</c>. Values must be between <c>0</c>
        /// and <c>256</c>, inclusive.
        /// </para>
        /// </summary>
        public int? AvailNum { get; set; }

        /// <summary>
        /// Checks to see if the AvailNum property is set.
        /// </summary>
        internal bool IsSetAvailNum() => this.AvailNum.HasValue;

        /// <summary>
        /// Gets and sets the property AvailsExpected. 
        /// <para>
        /// This is written to <c>splice_insert.avails_expected</c>, as defined in section 9.7.3.1
        /// of the SCTE-35 specification. The default value is <c>0</c>. Values must be between
        /// <c>0</c> and <c>256</c>, inclusive.
        /// </para>
        /// </summary>
        public int? AvailsExpected { get; set; }

        /// <summary>
        /// Checks to see if the AvailsExpected property is set.
        /// </summary>
        internal bool IsSetAvailsExpected() => this.AvailsExpected.HasValue;

        /// <summary>
        /// Gets and sets the property SpliceEventId. 
        /// <para>
        /// This is written to <c>splice_insert.splice_event_id</c>, as defined in section 9.7.3.1
        /// of the SCTE-35 specification. The default value is <c>1</c>.
        /// </para>
        /// </summary>
        public int? SpliceEventId { get; set; }

        /// <summary>
        /// Checks to see if the SpliceEventId property is set.
        /// </summary>
        internal bool IsSetSpliceEventId() => this.SpliceEventId.HasValue;

        /// <summary>
        /// Gets and sets the property UniqueProgramId. 
        /// <para>
        /// This is written to <c>splice_insert.unique_program_id</c>, as defined in section 9.7.3.1
        /// of the SCTE-35 specification. The default value is <c>0</c>. Values must be between
        /// <c>0</c> and <c>256</c>, inclusive.
        /// </para>
        /// </summary>
        public int? UniqueProgramId { get; set; }

        /// <summary>
        /// Checks to see if the UniqueProgramId property is set.
        /// </summary>
        internal bool IsSetUniqueProgramId() => this.UniqueProgramId.HasValue;
    }
}
