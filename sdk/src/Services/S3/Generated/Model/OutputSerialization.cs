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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes how results of the Select job are serialized.
    /// </summary>
    public partial class OutputSerialization
    {
        private CSVOutput _csv;
        private JSONOutput _json;

        /// <summary>
        /// Gets and sets the property CSV. 
        /// <para>
        /// Describes the serialization of CSV-encoded Select results.
        /// </para>
        /// </summary>
        public CSVOutput CSV
        {
            get { return this._csv; }
            set { this._csv = value; }
        }

        // Check to see if CSV property is set
        internal bool IsSetCSV()
        {
            return this._csv != null;
        }

        /// <summary>
        /// Gets and sets the property JSON. 
        /// <para>
        /// Specifies JSON as request's output serialization format.
        /// </para>
        /// </summary>
        public JSONOutput JSON
        {
            get { return this._json; }
            set { this._json = value; }
        }

        // Check to see if JSON property is set
        internal bool IsSetJSON()
        {
            return this._json != null;
        }

    }
}