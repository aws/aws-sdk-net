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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// This is the response object from the UpdatePackagingGroup operation.
    /// </summary>
    public partial class UpdatePackagingGroupResponse : AmazonWebServiceResponse
    {
        private int? _approximateAssetCount;
        private string _arn;
        private Authorization _authorization;
        private string _domainName;
        private EgressAccessLogs _egressAccessLogs;
        private string _id;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ApproximateAssetCount. The approximate asset count of the
        /// PackagingGroup.
        /// </summary>
        public int ApproximateAssetCount
        {
            get { return this._approximateAssetCount.GetValueOrDefault(); }
            set { this._approximateAssetCount = value; }
        }

        // Check to see if ApproximateAssetCount property is set
        internal bool IsSetApproximateAssetCount()
        {
            return this._approximateAssetCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. The ARN of the PackagingGroup.
        /// </summary>
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
        /// Gets and sets the property Authorization.
        /// </summary>
        public Authorization Authorization
        {
            get { return this._authorization; }
            set { this._authorization = value; }
        }

        // Check to see if Authorization property is set
        internal bool IsSetAuthorization()
        {
            return this._authorization != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. The fully qualified domain name for Assets
        /// in the PackagingGroup.
        /// </summary>
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
        /// Gets and sets the property EgressAccessLogs.
        /// </summary>
        public EgressAccessLogs EgressAccessLogs
        {
            get { return this._egressAccessLogs; }
            set { this._egressAccessLogs = value; }
        }

        // Check to see if EgressAccessLogs property is set
        internal bool IsSetEgressAccessLogs()
        {
            return this._egressAccessLogs != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the PackagingGroup.
        /// </summary>
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
        /// Gets and sets the property Tags.
        /// </summary>
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