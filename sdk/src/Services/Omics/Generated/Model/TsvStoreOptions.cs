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
    /// File settings for a TSV store.
    /// </summary>
    public partial class TsvStoreOptions
    {
        private AnnotationType _annotationType;
        private Dictionary<string, string> _formatToHeader = new Dictionary<string, string>();
        private List<Dictionary<string, string>> _schema = new List<Dictionary<string, string>>();

        /// <summary>
        /// Gets and sets the property AnnotationType. 
        /// <para>
        /// The store's annotation type.
        /// </para>
        /// </summary>
        public AnnotationType AnnotationType
        {
            get { return this._annotationType; }
            set { this._annotationType = value; }
        }

        // Check to see if AnnotationType property is set
        internal bool IsSetAnnotationType()
        {
            return this._annotationType != null;
        }

        /// <summary>
        /// Gets and sets the property FormatToHeader. 
        /// <para>
        /// The store's header key to column name mapping.
        /// </para>
        /// </summary>
        public Dictionary<string, string> FormatToHeader
        {
            get { return this._formatToHeader; }
            set { this._formatToHeader = value; }
        }

        // Check to see if FormatToHeader property is set
        internal bool IsSetFormatToHeader()
        {
            return this._formatToHeader != null && this._formatToHeader.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The store's schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public List<Dictionary<string, string>> Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null && this._schema.Count > 0; 
        }

    }
}