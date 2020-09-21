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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePresignedPortalUrl operation.
    /// Creates a pre-signed URL to a portal. Use this operation to create URLs to portals
    /// that use AWS Identity and Access Management (IAM) to authenticate users. An IAM user
    /// with access to a portal can call this API to get a URL to that portal. The URL contains
    /// a session token that lets the IAM user access the portal.
    /// </summary>
    public partial class CreatePresignedPortalUrlRequest : AmazonIoTSiteWiseRequest
    {
        private string _portalId;
        private int? _sessionDurationSeconds;

        /// <summary>
        /// Gets and sets the property PortalId. 
        /// <para>
        /// The ID of the portal to access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PortalId
        {
            get { return this._portalId; }
            set { this._portalId = value; }
        }

        // Check to see if PortalId property is set
        internal bool IsSetPortalId()
        {
            return this._portalId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionDurationSeconds. 
        /// <para>
        /// The duration (in seconds) for which the session at the URL is valid.
        /// </para>
        ///  
        /// <para>
        /// Default: 900 seconds (15 minutes)
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int SessionDurationSeconds
        {
            get { return this._sessionDurationSeconds.GetValueOrDefault(); }
            set { this._sessionDurationSeconds = value; }
        }

        // Check to see if SessionDurationSeconds property is set
        internal bool IsSetSessionDurationSeconds()
        {
            return this._sessionDurationSeconds.HasValue; 
        }

    }
}