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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Verified Access instance.
    /// </summary>
    public partial class VerifiedAccessInstance
    {
        private string _creationTime;
        private string _description;
        private string _lastUpdatedTime;
        private List<Tag> _tags = new List<Tag>();
        private string _verifiedAccessInstanceId;
        private List<VerifiedAccessTrustProviderCondensed> _verifiedAccessTrustProviders = new List<VerifiedAccessTrustProviderCondensed>();

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time.
        /// </para>
        /// </summary>
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Web Services Verified Access instance.
        /// </para>
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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The last updated time.
        /// </para>
        /// </summary>
        public string LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessInstanceId. 
        /// <para>
        /// The ID of the Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        public string VerifiedAccessInstanceId
        {
            get { return this._verifiedAccessInstanceId; }
            set { this._verifiedAccessInstanceId = value; }
        }

        // Check to see if VerifiedAccessInstanceId property is set
        internal bool IsSetVerifiedAccessInstanceId()
        {
            return this._verifiedAccessInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property VerifiedAccessTrustProviders. 
        /// <para>
        /// The IDs of the Amazon Web Services Verified Access trust providers.
        /// </para>
        /// </summary>
        public List<VerifiedAccessTrustProviderCondensed> VerifiedAccessTrustProviders
        {
            get { return this._verifiedAccessTrustProviders; }
            set { this._verifiedAccessTrustProviders = value; }
        }

        // Check to see if VerifiedAccessTrustProviders property is set
        internal bool IsSetVerifiedAccessTrustProviders()
        {
            return this._verifiedAccessTrustProviders != null && this._verifiedAccessTrustProviders.Count > 0; 
        }

    }
}