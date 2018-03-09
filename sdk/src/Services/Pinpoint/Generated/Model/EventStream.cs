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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Model for an event publishing subscription export.
    /// </summary>
    public partial class EventStream
    {
        private string _applicationId;
        private string _destinationStreamArn;
        private string _externalId;
        private string _lastModifiedDate;
        private string _lastUpdatedBy;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplicationId. The ID of the application from which events
        /// should be published.
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationStreamArn. The Amazon Resource Name (ARN) of
        /// the Amazon Kinesis stream or Firehose delivery stream to which you want to publish
        /// events. Firehose ARN: arn:aws:firehose:REGION:ACCOUNT_ID:deliverystream/STREAM_NAME
        /// Kinesis ARN: arn:aws:kinesis:REGION:ACCOUNT_ID:stream/STREAM_NAME
        /// </summary>
        public string DestinationStreamArn
        {
            get { return this._destinationStreamArn; }
            set { this._destinationStreamArn = value; }
        }

        // Check to see if DestinationStreamArn property is set
        internal bool IsSetDestinationStreamArn()
        {
            return this._destinationStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. DEPRECATED. Your AWS account ID, which you
        /// assigned to the ExternalID key in an IAM trust policy. Used by Amazon Pinpoint to
        /// assume an IAM role. This requirement is removed, and external IDs are not recommended
        /// for IAM roles assumed by Amazon Pinpoint.
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. The date the event stream was last updated
        /// in ISO 8601 format.
        /// </summary>
        public string LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. The IAM user who last modified the event
        /// stream.
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The IAM role that authorizes Amazon Pinpoint to
        /// publish events to the stream in your account.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}