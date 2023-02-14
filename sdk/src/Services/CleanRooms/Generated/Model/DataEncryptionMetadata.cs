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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The settings for client-side encryption for cryptographic computing.
    /// </summary>
    public partial class DataEncryptionMetadata
    {
        private bool? _allowCleartext;
        private bool? _allowDuplicates;
        private bool? _allowJoinsOnColumnsWithDifferentNames;
        private bool? _preserveNulls;

        /// <summary>
        /// Gets and sets the property AllowCleartext. 
        /// <para>
        /// Indicates whether encrypted tables can contain cleartext data (true) or are to cryptographically
        /// process every column (false).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AllowCleartext
        {
            get { return this._allowCleartext.GetValueOrDefault(); }
            set { this._allowCleartext = value; }
        }

        // Check to see if AllowCleartext property is set
        internal bool IsSetAllowCleartext()
        {
            return this._allowCleartext.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowDuplicates. 
        /// <para>
        /// Indicates whether Fingerprint columns can contain duplicate entries (true) or are
        /// to contain only non-repeated values (false).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AllowDuplicates
        {
            get { return this._allowDuplicates.GetValueOrDefault(); }
            set { this._allowDuplicates = value; }
        }

        // Check to see if AllowDuplicates property is set
        internal bool IsSetAllowDuplicates()
        {
            return this._allowDuplicates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowJoinsOnColumnsWithDifferentNames. 
        /// <para>
        /// Indicates whether Fingerprint columns can be joined on any other Fingerprint column
        /// with a different name (true) or can only be joined on Fingerprint columns of the same
        /// name (false).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AllowJoinsOnColumnsWithDifferentNames
        {
            get { return this._allowJoinsOnColumnsWithDifferentNames.GetValueOrDefault(); }
            set { this._allowJoinsOnColumnsWithDifferentNames = value; }
        }

        // Check to see if AllowJoinsOnColumnsWithDifferentNames property is set
        internal bool IsSetAllowJoinsOnColumnsWithDifferentNames()
        {
            return this._allowJoinsOnColumnsWithDifferentNames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreserveNulls. 
        /// <para>
        /// Indicates whether NULL values are to be copied as NULL to encrypted tables (true)
        /// or cryptographically processed (false).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool PreserveNulls
        {
            get { return this._preserveNulls.GetValueOrDefault(); }
            set { this._preserveNulls = value; }
        }

        // Check to see if PreserveNulls property is set
        internal bool IsSetPreserveNulls()
        {
            return this._preserveNulls.HasValue; 
        }

    }
}