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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// A Channel resource configuration.
    /// </summary>
    public partial class Channel
    {
        private string _arn;
        private string _createdAt;
        private string _description;
        private EgressAccessLogs _egressAccessLogs;
        private HlsIngest _hlsIngest;
        private string _id;
        private IngressAccessLogs _ingressAccessLogs;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the Channel.
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
        /// Gets and sets the property CreatedAt. The date and time the Channel was created.
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property Description. A short text description of the Channel.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
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
        /// Gets and sets the property HlsIngest.
        /// </summary>
        public HlsIngest HlsIngest
        {
            get { return this._hlsIngest; }
            set { this._hlsIngest = value; }
        }

        // Check to see if HlsIngest property is set
        internal bool IsSetHlsIngest()
        {
            return this._hlsIngest != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the Channel.
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
        /// Gets and sets the property IngressAccessLogs.
        /// </summary>
        public IngressAccessLogs IngressAccessLogs
        {
            get { return this._ingressAccessLogs; }
            set { this._ingressAccessLogs = value; }
        }

        // Check to see if IngressAccessLogs property is set
        internal bool IsSetIngressAccessLogs()
        {
            return this._ingressAccessLogs != null;
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