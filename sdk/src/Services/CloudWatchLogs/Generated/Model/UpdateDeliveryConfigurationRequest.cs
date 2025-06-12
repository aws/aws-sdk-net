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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeliveryConfiguration operation.
    /// Use this operation to update the configuration of a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Delivery.html">delivery</a>
    /// to change either the S3 path pattern or the format of the delivered logs. You can't
    /// use this operation to change the source or destination of the delivery.
    /// </summary>
    public partial class UpdateDeliveryConfigurationRequest : AmazonCloudWatchLogsRequest
    {
        private string _fieldDelimiter;
        private string _id;
        private List<string> _recordFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3DeliveryConfiguration _s3DeliveryConfiguration;

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// The field delimiter to use between record fields when the final output format of a
        /// delivery is in <c>Plain</c>, <c>W3C</c>, or <c>Raw</c> format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public string FieldDelimiter
        {
            get { return this._fieldDelimiter; }
            set { this._fieldDelimiter = value; }
        }

        // Check to see if FieldDelimiter property is set
        internal bool IsSetFieldDelimiter()
        {
            return this._fieldDelimiter != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the delivery to be updated by this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RecordFields. 
        /// <para>
        /// The list of record fields to be delivered to the destination, in order. If the delivery's
        /// log source has mandatory fields, they must be included in this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public List<string> RecordFields
        {
            get { return this._recordFields; }
            set { this._recordFields = value; }
        }

        // Check to see if RecordFields property is set
        internal bool IsSetRecordFields()
        {
            return this._recordFields != null && (this._recordFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property S3DeliveryConfiguration. 
        /// <para>
        /// This structure contains parameters that are valid only when the delivery's delivery
        /// destination is an S3 bucket.
        /// </para>
        /// </summary>
        public S3DeliveryConfiguration S3DeliveryConfiguration
        {
            get { return this._s3DeliveryConfiguration; }
            set { this._s3DeliveryConfiguration = value; }
        }

        // Check to see if S3DeliveryConfiguration property is set
        internal bool IsSetS3DeliveryConfiguration()
        {
            return this._s3DeliveryConfiguration != null;
        }

    }
}