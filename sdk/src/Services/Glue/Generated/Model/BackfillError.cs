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
    /// A list of errors that can occur when registering partition indexes for an existing
    /// table.
    /// 
    ///  
    /// <para>
    /// These errors give the details about why an index registration failed and provide a
    /// limited number of partitions in the response, so that you can fix the partitions at
    /// fault and try registering the index again. The most common set of errors that can
    /// occur are categorized as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// EncryptedPartitionError: The partitions are encrypted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// InvalidPartitionTypeDataError: The partition value doesn't match the data type for
    /// that partition column.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MissingPartitionValueError: The partitions are encrypted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// UnsupportedPartitionCharacterError: Characters inside the partition value are not
    /// supported. For example: U+0000 , U+0001, U+0002.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// InternalError: Any error which does not belong to other error codes.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BackfillError
    {
        private BackfillErrorCode _code;
        private List<PartitionValueList> _partitions = AWSConfigs.InitializeCollections ? new List<PartitionValueList>() : null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code for an error that occurred when registering partition indexes for an
        /// existing table.
        /// </para>
        /// </summary>
        public BackfillErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// A list of a limited number of partitions in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartitionValueList> Partitions
        {
            get { return this._partitions; }
            set { this._partitions = value; }
        }

        // Check to see if Partitions property is set
        internal bool IsSetPartitions()
        {
            return this._partitions != null && (this._partitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}