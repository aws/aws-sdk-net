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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Contains details about the compaction settings for an Iceberg table.
    /// </summary>
    public partial class IcebergCompactionSettings
    {
        private IcebergCompactionStrategy _strategy;
        private int? _targetFileSizeMB;

        /// <summary>
        /// Gets and sets the property Strategy. 
        /// <para>
        /// The compaction strategy to use for the table. This determines how files are selected
        /// and combined during compaction operations.
        /// </para>
        /// </summary>
        public IcebergCompactionStrategy Strategy
        {
            get { return this._strategy; }
            set { this._strategy = value; }
        }

        // Check to see if Strategy property is set
        internal bool IsSetStrategy()
        {
            return this._strategy != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFileSizeMB. 
        /// <para>
        /// The target file size for the table in MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? TargetFileSizeMB
        {
            get { return this._targetFileSizeMB; }
            set { this._targetFileSizeMB = value; }
        }

        // Check to see if TargetFileSizeMB property is set
        internal bool IsSetTargetFileSizeMB()
        {
            return this._targetFileSizeMB.HasValue; 
        }

    }
}