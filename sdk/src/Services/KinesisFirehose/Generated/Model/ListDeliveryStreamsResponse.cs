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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
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
namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// This is the response object from the ListDeliveryStreams operation.
    /// </summary>
    public partial class ListDeliveryStreamsResponse : AmazonWebServiceResponse
    {
        private List<string> _deliveryStreamNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _hasMoreDeliveryStreams;

        /// <summary>
        /// Gets and sets the property DeliveryStreamNames. 
        /// <para>
        /// The names of the Firehose streams.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DeliveryStreamNames
        {
            get { return this._deliveryStreamNames; }
            set { this._deliveryStreamNames = value; }
        }

        // Check to see if DeliveryStreamNames property is set
        internal bool IsSetDeliveryStreamNames()
        {
            return this._deliveryStreamNames != null && (this._deliveryStreamNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HasMoreDeliveryStreams. 
        /// <para>
        /// Indicates whether there are more Firehose streams available to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? HasMoreDeliveryStreams
        {
            get { return this._hasMoreDeliveryStreams; }
            set { this._hasMoreDeliveryStreams = value; }
        }

        // Check to see if HasMoreDeliveryStreams property is set
        internal bool IsSetHasMoreDeliveryStreams()
        {
            return this._hasMoreDeliveryStreams.HasValue; 
        }

    }
}