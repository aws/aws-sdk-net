/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDestination operation.
    /// Updates the specified destination of the specified delivery stream. 
    /// 
    ///  
    /// <para>
    /// This operation can be used to change the destination type (for example, to replace
    /// the Amazon S3 destination with Amazon Redshift) or change the parameters associated
    /// with a given destination (for example, to change the bucket name of the Amazon S3
    /// destination). The update may not occur immediately. The target delivery stream remains
    /// active while the configurations are updated, so data writes to the delivery stream
    /// can continue during this process. The updated configurations are normally effective
    /// within a few minutes. 
    /// </para>
    ///  
    /// <para>
    /// If the destination type is the same, Amazon Kinesis Firehose merges the configuration
    /// parameters specified in the <a>UpdateDestination</a> request with the destination
    /// configuration that already exists on the delivery stream. If any of the parameters
    /// are not specified in the update request, then the existing configuration parameters
    /// are retained. For example, in the Amazon S3 destination, if <a>EncryptionConfiguration</a>
    /// is not specified then the existing <a>EncryptionConfiguration</a> is maintained on
    /// the destination.
    /// </para>
    ///  
    /// <para>
    /// If the destination type is not the same, for example, changing the destination from
    /// Amazon S3 to Amazon Redshift, Amazon Kinesis Firehose does not merge any parameters.
    /// In this case, all parameters must be specified.
    /// </para>
    ///  
    /// <para>
    /// Amazon Kinesis Firehose uses the <code>CurrentDeliveryStreamVersionId</code> to avoid
    /// race conditions and conflicting merges. This is a required field in every request
    /// and the service only updates the configuration if the existing configuration matches
    /// the <code>VersionId</code>. After the update is applied successfully, the <code>VersionId</code>
    /// is updated, which can be retrieved with the <a>DescribeDeliveryStream</a> operation.
    /// The new <code>VersionId</code> should be uses to set <code>CurrentDeliveryStreamVersionId</code>
    /// in the next <a>UpdateDestination</a> operation.
    /// </para>
    /// </summary>
    public partial class UpdateDestinationRequest : AmazonKinesisFirehoseRequest
    {
        private string _currentDeliveryStreamVersionId;
        private string _deliveryStreamName;
        private string _destinationId;
        private RedshiftDestinationUpdate _redshiftDestinationUpdate;
        private S3DestinationUpdate _s3DestinationUpdate;

        /// <summary>
        /// Gets and sets the property CurrentDeliveryStreamVersionId. 
        /// <para>
        /// Obtain this value from the <code>VersionId</code> result of the <a>DeliveryStreamDescription</a>
        /// operation. This value is required, and helps the service to perform conditional operations.
        /// For example, if there is a interleaving update and this value is null, then the update
        /// destination fails. After the update is successful, the <code>VersionId</code> value
        /// is updated. The service then performs a merge of the old configuration with the new
        /// configuration.
        /// </para>
        /// </summary>
        public string CurrentDeliveryStreamVersionId
        {
            get { return this._currentDeliveryStreamVersionId; }
            set { this._currentDeliveryStreamVersionId = value; }
        }

        // Check to see if CurrentDeliveryStreamVersionId property is set
        internal bool IsSetCurrentDeliveryStreamVersionId()
        {
            return this._currentDeliveryStreamVersionId != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
        /// </para>
        /// </summary>
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationUpdate.
        /// </summary>
        public RedshiftDestinationUpdate RedshiftDestinationUpdate
        {
            get { return this._redshiftDestinationUpdate; }
            set { this._redshiftDestinationUpdate = value; }
        }

        // Check to see if RedshiftDestinationUpdate property is set
        internal bool IsSetRedshiftDestinationUpdate()
        {
            return this._redshiftDestinationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationUpdate.
        /// </summary>
        public S3DestinationUpdate S3DestinationUpdate
        {
            get { return this._s3DestinationUpdate; }
            set { this._s3DestinationUpdate = value; }
        }

        // Check to see if S3DestinationUpdate property is set
        internal bool IsSetS3DestinationUpdate()
        {
            return this._s3DestinationUpdate != null;
        }

    }
}