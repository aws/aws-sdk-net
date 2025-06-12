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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// The external URL source for the application.
    /// </summary>
    public partial class ExternalUrlConfig
    {
        private string _accessUrl;
        private List<string> _approvedOrigins = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccessUrl. 
        /// <para>
        /// The URL to access the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string AccessUrl
        {
            get { return this._accessUrl; }
            set { this._accessUrl = value; }
        }

        // Check to see if AccessUrl property is set
        internal bool IsSetAccessUrl()
        {
            return this._accessUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ApprovedOrigins. 
        /// <para>
        /// Additional URLs to allow list if different than the access URL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ApprovedOrigins
        {
            get { return this._approvedOrigins; }
            set { this._approvedOrigins = value; }
        }

        // Check to see if ApprovedOrigins property is set
        internal bool IsSetApprovedOrigins()
        {
            return this._approvedOrigins != null && (this._approvedOrigins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}