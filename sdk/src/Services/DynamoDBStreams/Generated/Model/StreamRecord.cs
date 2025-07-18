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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// A description of a single data modification that was performed on an item in a DynamoDB
    /// table.
    /// </summary>
    public partial class StreamRecord
    {
        private DateTime? _approximateCreationDateTime;
        private Dictionary<string, AttributeValue> _keys = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private Dictionary<string, AttributeValue> _newImage = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private Dictionary<string, AttributeValue> _oldImage = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _sequenceNumber;
        private long? _sizeBytes;
        private StreamViewType _streamViewType;

        /// <summary>
        /// Gets and sets the property ApproximateCreationDateTime. 
        /// <para>
        /// The approximate date and time when the stream record was created, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a> format and rounded down to the closest second.
        /// </para>
        /// </summary>
        public DateTime? ApproximateCreationDateTime
        {
            get { return this._approximateCreationDateTime; }
            set { this._approximateCreationDateTime = value; }
        }

        // Check to see if ApproximateCreationDateTime property is set
        internal bool IsSetApproximateCreationDateTime()
        {
            return this._approximateCreationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The primary key attribute(s) for the DynamoDB item that was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && (this._keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NewImage. 
        /// <para>
        /// The item in the DynamoDB table as it appeared after it was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> NewImage
        {
            get { return this._newImage; }
            set { this._newImage = value; }
        }

        // Check to see if NewImage property is set
        internal bool IsSetNewImage()
        {
            return this._newImage != null && (this._newImage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OldImage. 
        /// <para>
        /// The item in the DynamoDB table as it appeared before it was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> OldImage
        {
            get { return this._oldImage; }
            set { this._oldImage = value; }
        }

        // Check to see if OldImage property is set
        internal bool IsSetOldImage()
        {
            return this._oldImage != null && (this._oldImage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number of the stream record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=40)]
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the stream record, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? SizeBytes
        {
            get { return this._sizeBytes; }
            set { this._sizeBytes = value; }
        }

        // Check to see if SizeBytes property is set
        internal bool IsSetSizeBytes()
        {
            return this._sizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamViewType. 
        /// <para>
        /// The type of data from the modified DynamoDB item that was captured in this stream
        /// record:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - only the key attributes of the modified item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - the entire item, as it appeared after it was modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - the entire item, as it appeared before it was modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - both the new and the old item images of the item.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamViewType StreamViewType
        {
            get { return this._streamViewType; }
            set { this._streamViewType = value; }
        }

        // Check to see if StreamViewType property is set
        internal bool IsSetStreamViewType()
        {
            return this._streamViewType != null;
        }

    }
}