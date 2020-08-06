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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Describes the format of a manifest. If the manifest is in CSV format, also describes
    /// the columns contained within the manifest.
    /// </summary>
    public partial class JobManifestSpec
    {
        private List<string> _fields = new List<string>();
        private JobManifestFormat _format;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// If the specified manifest object is in the <code>S3BatchOperations_CSV_20180820</code>
        /// format, this element describes which columns contain the required data.
        /// </para>
        /// </summary>
        public List<string> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && this._fields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Indicates which of the available formats the specified manifest uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobManifestFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

    }
}