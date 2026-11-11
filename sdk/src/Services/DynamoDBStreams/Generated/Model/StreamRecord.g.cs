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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApproximateCreationDateTime. 
        /// <para>
        /// The approximate date and time when the stream record was created, in <a href="http://www.epochconverter.com/">UNIX
        /// epoch time</a> format and rounded down to the closest second. Some tools and SDKs
        /// may convert this value to a different format, such as <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601</a>.
        /// </para>
        /// </summary>
        public DateTime? ApproximateCreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateCreationDateTime property is set.
        /// </summary>
        internal bool IsSetApproximateCreationDateTime() => this.ApproximateCreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// The primary key attribute(s) for the DynamoDB item that was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Keys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NewImage. 
        /// <para>
        /// The item in the DynamoDB table as it appeared after it was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> NewImage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the NewImage property is set.
        /// </summary>
        internal bool IsSetNewImage() => this.NewImage != null && (this.NewImage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OldImage. 
        /// <para>
        /// The item in the DynamoDB table as it appeared before it was modified.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> OldImage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Checks to see if the OldImage property is set.
        /// </summary>
        internal bool IsSetOldImage() => this.OldImage != null && (this.OldImage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// The sequence number of the stream record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 40)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;

        /// <summary>
        /// Gets and sets the property SizeBytes. 
        /// <para>
        /// The size of the stream record, in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeBytes property is set.
        /// </summary>
        internal bool IsSetSizeBytes() => this.SizeBytes.HasValue;

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
        public StreamViewType StreamViewType { get; set; }

        /// <summary>
        /// Checks to see if the StreamViewType property is set.
        /// </summary>
        internal bool IsSetStreamViewType() => this.StreamViewType != null;
    }
}
