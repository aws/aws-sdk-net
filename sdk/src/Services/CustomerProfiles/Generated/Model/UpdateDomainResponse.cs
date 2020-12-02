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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the UpdateDomain operation.
    /// </summary>
    public partial class UpdateDomainResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _deadLetterQueueUrl;
        private string _defaultEncryptionKey;
        private int? _defaultExpirationDays;
        private string _domainName;
        private DateTime? _lastUpdatedAt;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the domain was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeadLetterQueueUrl. 
        /// <para>
        /// The URL of the SQS dead letter queue, which is used for reporting errors associated
        /// with ingesting data from third party applications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string DeadLetterQueueUrl
        {
            get { return this._deadLetterQueueUrl; }
            set { this._deadLetterQueueUrl = value; }
        }

        // Check to see if DeadLetterQueueUrl property is set
        internal bool IsSetDeadLetterQueueUrl()
        {
            return this._deadLetterQueueUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultEncryptionKey. 
        /// <para>
        /// The default encryption key, which is an AWS managed key, is used when no specific
        /// type of encryption key is specified. It is used to encrypt all data before it is placed
        /// in permanent or semi-permanent storage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string DefaultEncryptionKey
        {
            get { return this._defaultEncryptionKey; }
            set { this._defaultEncryptionKey = value; }
        }

        // Check to see if DefaultEncryptionKey property is set
        internal bool IsSetDefaultEncryptionKey()
        {
            return this._defaultEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultExpirationDays. 
        /// <para>
        /// The default number of days until the data within the domain expires.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1098)]
        public int DefaultExpirationDays
        {
            get { return this._defaultExpirationDays.GetValueOrDefault(); }
            set { this._defaultExpirationDays = value; }
        }

        // Check to see if DefaultExpirationDays property is set
        internal bool IsSetDefaultExpirationDays()
        {
            return this._defaultExpirationDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the domain was most recently edited.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}