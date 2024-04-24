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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Omics.Model
{
    /// <summary>
    /// The entity tag (ETag) is a hash of the object representing its semantic content.
    /// </summary>
    public partial class ETag
    {
        private ETagAlgorithm _algorithm;
        private string _source1;
        private string _source2;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The algorithm used to calculate the read set’s ETag(s).
        /// </para>
        /// </summary>
        public ETagAlgorithm Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Source1. 
        /// <para>
        /// The ETag hash calculated on Source1 of the read set.
        /// </para>
        /// </summary>
        public string Source1
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
        /// The ETag hash calculated on Source2 of the read set.
        /// </para>
        /// </summary>
        public string Source2
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