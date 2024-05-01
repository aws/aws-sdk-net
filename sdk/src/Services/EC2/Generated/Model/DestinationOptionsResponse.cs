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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the destination options for a flow log.
    /// </summary>
    public partial class DestinationOptionsResponse
    {
        private DestinationFileFormat _fileFormat;
        private bool? _hiveCompatiblePartitions;
        private bool? _perHourPartition;

        /// <summary>
        /// Gets and sets the property FileFormat. 
        /// <para>
        /// The format for the flow log.
        /// </para>
        /// </summary>
        public DestinationFileFormat FileFormat
        {
            get { return this._fileFormat; }
            set { this._fileFormat = value; }
        }

        // Check to see if FileFormat property is set
        internal bool IsSetFileFormat()
        {
            return this._fileFormat != null;
        }

        /// <summary>
        /// Gets and sets the property HiveCompatiblePartitions. 
        /// <para>
        /// Indicates whether to use Hive-compatible prefixes for flow logs stored in Amazon S3.
        /// </para>
        /// </summary>
        public bool? HiveCompatiblePartitions
        {
            get { return this._hiveCompatiblePartitions; }
            set { this._hiveCompatiblePartitions = value; }
        }

        // Check to see if HiveCompatiblePartitions property is set
        internal bool IsSetHiveCompatiblePartitions()
        {
            return this._hiveCompatiblePartitions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerHourPartition. 
        /// <para>
        /// Indicates whether to partition the flow log per hour.
        /// </para>
        /// </summary>
        public bool? PerHourPartition
        {
            get { return this._perHourPartition; }
            set { this._perHourPartition = value; }
        }

        // Check to see if PerHourPartition property is set
        internal bool IsSetPerHourPartition()
        {
            return this._perHourPartition.HasValue; 
        }

    }
}