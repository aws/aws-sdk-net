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
    /// Files in a read set.
    /// </summary>
    public partial class ReadSetFiles
    {
        private FileInformation _index;
        private FileInformation _source1;
        private FileInformation _source2;

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The files' index.
        /// </para>
        /// </summary>
        public FileInformation Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index != null;
        }

        /// <summary>
        /// Gets and sets the property Source1. 
        /// <para>
        /// The location of the first file in Amazon S3.
        /// </para>
        /// </summary>
        public FileInformation Source1
        {
            get { return this._source1; }
            set { this._source1 = value; }
        }

        // Check to see if Source1 property is set
        internal bool IsSetSource1()
        {
            return this._source1 != null;
        }

        /// <summary>
        /// Gets and sets the property Source2. 
        /// <para>
        /// The location of the second file in Amazon S3.
        /// </para>
        /// </summary>
        public FileInformation Source2
        {
            get { return this._source2; }
            set { this._source2 = value; }
        }

        // Check to see if Source2 property is set
        internal bool IsSetSource2()
        {
            return this._source2 != null;
        }

    }
}