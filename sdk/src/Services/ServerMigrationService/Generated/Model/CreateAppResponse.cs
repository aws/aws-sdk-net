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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// This is the response object from the CreateApp operation.
    /// </summary>
    public partial class CreateAppResponse : AmazonWebServiceResponse
    {
        private AppSummary _appSummary;
        private List<ServerGroup> _serverGroups = new List<ServerGroup>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AppSummary. 
        /// <para>
        /// Summary description of the application.
        /// </para>
        /// </summary>
        public AppSummary AppSummary
        {
            get { return this._appSummary; }
            set { this._appSummary = value; }
        }

        // Check to see if AppSummary property is set
        internal bool IsSetAppSummary()
        {
            return this._appSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ServerGroups. 
        /// <para>
        /// List of server groups included in the application.
        /// </para>
        /// </summary>
        public List<ServerGroup> ServerGroups
        {
            get { return this._serverGroups; }
            set { this._serverGroups = value; }
        }

        // Check to see if ServerGroups property is set
        internal bool IsSetServerGroups()
        {
            return this._serverGroups != null && this._serverGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of taags associated with the application.
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

    }
}