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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// An AudienceMedia object contains an Audience and a list of AlternateMedia.
    /// </summary>
    public partial class AudienceMedia
    {
        private List<AlternateMedia> _alternateMedia = AWSConfigs.InitializeCollections ? new List<AlternateMedia>() : null;
        private string _audience;

        /// <summary>
        /// Gets and sets the property AlternateMedia. 
        /// <para>
        /// The list of AlternateMedia defined in AudienceMedia.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AlternateMedia> AlternateMedia
        {
            get { return this._alternateMedia; }
            set { this._alternateMedia = value; }
        }

        // Check to see if AlternateMedia property is set
        internal bool IsSetAlternateMedia()
        {
            return this._alternateMedia != null && (this._alternateMedia.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The Audience defined in AudienceMedia.
        /// </para>
        /// </summary>
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }

    }
}