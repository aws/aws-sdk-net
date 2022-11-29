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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Formatting options for a file.
    /// </summary>
    public partial class FormatOptions
    {
        private TsvOptions _tsvOptions;
        private VcfOptions _vcfOptions;

        /// <summary>
        /// Gets and sets the property TsvOptions. 
        /// <para>
        /// Options for a TSV file.
        /// </para>
        /// </summary>
        public TsvOptions TsvOptions
        {
            get { return this._tsvOptions; }
            set { this._tsvOptions = value; }
        }

        // Check to see if TsvOptions property is set
        internal bool IsSetTsvOptions()
        {
            return this._tsvOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VcfOptions. 
        /// <para>
        /// Options for a VCF file.
        /// </para>
        /// </summary>
        public VcfOptions VcfOptions
        {
            get { return this._vcfOptions; }
            set { this._vcfOptions = value; }
        }

        // Check to see if VcfOptions property is set
        internal bool IsSetVcfOptions()
        {
            return this._vcfOptions != null;
        }

    }
}