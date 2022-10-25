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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Splice insert message configuration.
    /// </summary>
    public partial class SpliceInsertMessage
    {
        private int? _availNum;
        private int? _availsExpected;
        private int? _spliceEventId;
        private int? _uniqueProgramId;

        /// <summary>
        /// Gets and sets the property AvailNum. 
        /// <para>
        /// This is written to <code>splice_insert.avail_num</code>, as defined in section 9.7.3.1
        /// of the SCTE-35 specification. The default value is <code>0</code>. Values must be
        /// between <code>0</code> and <code>256</code>, inclusive.
        /// </para>
        /// </summary>
        public int AvailNum
        {
            get { return this._availNum.GetValueOrDefault(); }
            set { this._availNum = value; }
        }

        // Check to see if AvailNum property is set
        internal bool IsSetAvailNum()
        {
            return this._availNum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailsExpected. 
        /// <para>
        /// This is written to <code>splice_insert.avails_expected</code>, as defined in section
        /// 9.7.3.1 of the SCTE-35 specification. The default value is <code>0</code>. Values
        /// must be between <code>0</code> and <code>256</code>, inclusive.
        /// </para>
        /// </summary>
        public int AvailsExpected
        {
            get { return this._availsExpected.GetValueOrDefault(); }
            set { this._availsExpected = value; }
        }

        // Check to see if AvailsExpected property is set
        internal bool IsSetAvailsExpected()
        {
            return this._availsExpected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpliceEventId. 
        /// <para>
        /// This is written to <code>splice_insert.splice_event_id</code>, as defined in section
        /// 9.7.3.1 of the SCTE-35 specification. The default value is <code>1</code>.
        /// </para>
        /// </summary>
        public int SpliceEventId
        {
            get { return this._spliceEventId.GetValueOrDefault(); }
            set { this._spliceEventId = value; }
        }

        // Check to see if SpliceEventId property is set
        internal bool IsSetSpliceEventId()
        {
            return this._spliceEventId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UniqueProgramId. 
        /// <para>
        /// This is written to <code>splice_insert.unique_program_id</code>, as defined in section
        /// 9.7.3.1 of the SCTE-35 specification. The default value is <code>0</code>. Values
        /// must be between <code>0</code> and <code>256</code>, inclusive.
        /// </para>
        /// </summary>
        public int UniqueProgramId
        {
            get { return this._uniqueProgramId.GetValueOrDefault(); }
            set { this._uniqueProgramId = value; }
        }

        // Check to see if UniqueProgramId property is set
        internal bool IsSetUniqueProgramId()
        {
            return this._uniqueProgramId.HasValue; 
        }

    }
}