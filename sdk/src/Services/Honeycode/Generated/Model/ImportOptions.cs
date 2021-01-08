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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// An object that contains the options specified by the sumitter of the import request.
    /// </summary>
    public partial class ImportOptions
    {
        private DelimitedTextImportOptions _delimitedTextOptions;
        private DestinationOptions _destinationOptions;

        /// <summary>
        /// Gets and sets the property DelimitedTextOptions. 
        /// <para>
        /// Options relating to parsing delimited text. Required if dataFormat is DELIMITED_TEXT.
        /// </para>
        /// </summary>
        public DelimitedTextImportOptions DelimitedTextOptions
        {
            get { return this._delimitedTextOptions; }
            set { this._delimitedTextOptions = value; }
        }

        // Check to see if DelimitedTextOptions property is set
        internal bool IsSetDelimitedTextOptions()
        {
            return this._delimitedTextOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationOptions. 
        /// <para>
        /// Options relating to the destination of the import request.
        /// </para>
        /// </summary>
        public DestinationOptions DestinationOptions
        {
            get { return this._destinationOptions; }
            set { this._destinationOptions = value; }
        }

        // Check to see if DestinationOptions property is set
        internal bool IsSetDestinationOptions()
        {
            return this._destinationOptions != null;
        }

    }
}