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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Updates a blocked phrases configuration in your Amazon Q Business application.
    /// </summary>
    public partial class BlockedPhrasesConfigurationUpdate
    {
        private List<string> _blockedPhrasesToCreateOrUpdate = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _blockedPhrasesToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _systemMessageOverride;

        /// <summary>
        /// Gets and sets the property BlockedPhrasesToCreateOrUpdate. 
        /// <para>
        /// Creates or updates a blocked phrases configuration in your Amazon Q Business application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockedPhrasesToCreateOrUpdate
        {
            get { return this._blockedPhrasesToCreateOrUpdate; }
            set { this._blockedPhrasesToCreateOrUpdate = value; }
        }

        // Check to see if BlockedPhrasesToCreateOrUpdate property is set
        internal bool IsSetBlockedPhrasesToCreateOrUpdate()
        {
            return this._blockedPhrasesToCreateOrUpdate != null && (this._blockedPhrasesToCreateOrUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlockedPhrasesToDelete. 
        /// <para>
        /// Deletes a blocked phrases configuration in your Amazon Q Business application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockedPhrasesToDelete
        {
            get { return this._blockedPhrasesToDelete; }
            set { this._blockedPhrasesToDelete = value; }
        }

        // Check to see if BlockedPhrasesToDelete property is set
        internal bool IsSetBlockedPhrasesToDelete()
        {
            return this._blockedPhrasesToDelete != null && (this._blockedPhrasesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SystemMessageOverride. 
        /// <para>
        /// The configured custom message displayed to your end user when they use blocked phrase
        /// during chat.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string SystemMessageOverride
        {
            get { return this._systemMessageOverride; }
            set { this._systemMessageOverride = value; }
        }

        // Check to see if SystemMessageOverride property is set
        internal bool IsSetSystemMessageOverride()
        {
            return this._systemMessageOverride != null;
        }

    }
}