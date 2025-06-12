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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Information for a release of the mobile SDK, including release notes and tags.
    /// 
    ///  
    /// <para>
    /// The mobile SDK is not generally available. Customers who have access to the mobile
    /// SDK can use it to establish and manage WAF tokens for use in HTTP(S) requests from
    /// a mobile device to WAF. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-application-integration.html">WAF
    /// client application integration</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class MobileSdkRelease
    {
        private string _releaseNotes;
        private string _releaseVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ReleaseNotes. 
        /// <para>
        /// Notes describing the release.
        /// </para>
        /// </summary>
        public string ReleaseNotes
        {
            get { return this._releaseNotes; }
            set { this._releaseNotes = value; }
        }

        // Check to see if ReleaseNotes property is set
        internal bool IsSetReleaseNotes()
        {
            return this._releaseNotes != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseVersion. 
        /// <para>
        /// The release version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ReleaseVersion
        {
            get { return this._releaseVersion; }
            set { this._releaseVersion = value; }
        }

        // Check to see if ReleaseVersion property is set
        internal bool IsSetReleaseVersion()
        {
            return this._releaseVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that are associated with the release. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the release. 
        /// </para>
        /// </summary>
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}