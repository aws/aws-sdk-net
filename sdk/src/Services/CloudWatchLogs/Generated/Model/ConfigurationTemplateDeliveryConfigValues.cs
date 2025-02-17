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
    /// This structure contains the default values that are used for each configuration parameter
    /// when you use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
    /// to create a deliver under the current service type, resource type, and log type.
    /// </summary>
    public partial class ConfigurationTemplateDeliveryConfigValues
    {
        private string _fieldDelimiter;
        private List<string> _recordFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private S3DeliveryConfiguration _s3DeliveryConfiguration;

        /// <summary>
        /// Gets and sets the property FieldDelimiter. 
        /// <para>
        /// The default field delimiter that is used in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// operation when the field delimiter is not specified in that operation. The field delimiter
        /// is used only when the final output delivery is in <c>Plain</c>, <c>W3C</c>, or <c>Raw</c>
        /// format.
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
        /// Gets and sets the property RecordFields. 
        /// <para>
        /// The default record fields that will be delivered when a list of record fields is not
        /// provided in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// operation.
        /// </para>
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
        /// The delivery parameters that are used when you create a delivery to a delivery destination
        /// that is an S3 Bucket.
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