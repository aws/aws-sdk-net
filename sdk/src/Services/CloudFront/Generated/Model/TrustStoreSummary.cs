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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A trust store summary.
    /// </summary>
    public partial class TrustStoreSummary
    {
        private string _arn;
        private string _eTag;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _name;
        private int? _numberOfCaCertificates;
        private string _reason;
        private TrustStoreStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The trust store's Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The version identifier for the current version of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The trust store's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The trust store's last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The trust store's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfCaCertificates. 
        /// <para>
        /// The trust store's number of CA certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NumberOfCaCertificates
        {
            get { return this._numberOfCaCertificates.GetValueOrDefault(); }
            set { this._numberOfCaCertificates = value; }
        }

        // Check to see if NumberOfCaCertificates property is set
        internal bool IsSetNumberOfCaCertificates()
        {
            return this._numberOfCaCertificates.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The trust store's reason.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The trust store's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrustStoreStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}