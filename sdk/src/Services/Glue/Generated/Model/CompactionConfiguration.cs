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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The configuration for a compaction optimizer. This configuration defines how data
    /// files in your table will be compacted to improve query performance and reduce storage
    /// costs.
    /// </summary>
    public partial class CompactionConfiguration
    {
        private IcebergCompactionConfiguration _icebergConfiguration;

        /// <summary>
        /// Gets and sets the property IcebergConfiguration. 
        /// <para>
        /// The configuration for an Iceberg compaction optimizer.
        /// </para>
        /// </summary>
        public IcebergCompactionConfiguration IcebergConfiguration
        {
            get { return this._icebergConfiguration; }
            set { this._icebergConfiguration = value; }
        }

        // Check to see if IcebergConfiguration property is set
        internal bool IsSetIcebergConfiguration()
        {
            return this._icebergConfiguration != null;
        }

    }
}