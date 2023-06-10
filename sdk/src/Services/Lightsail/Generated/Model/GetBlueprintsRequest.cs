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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBlueprints operation.
    /// Returns the list of available instance images, or <i>blueprints</i>. You can use a
    /// blueprint to create a new instance already running a specific operating system, as
    /// well as a preinstalled app or development stack. The software each instance is running
    /// depends on the blueprint image you choose.
    /// 
    ///  <note> 
    /// <para>
    /// Use active blueprints when creating new instances. Inactive blueprints are listed
    /// to support customers with existing instances and are not necessarily available to
    /// create new instances. Blueprints are marked inactive when they become outdated due
    /// to operating system updates or new application releases.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetBlueprintsRequest : AmazonLightsailRequest
    {
        private AppCategory _appCategory;
        private bool? _includeInactive;
        private string _pageToken;

        /// <summary>
        /// Gets and sets the property AppCategory. 
        /// <para>
        /// Returns a list of blueprints that are specific to Lightsail for Research.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must use this parameter to view Lightsail for Research blueprints.
        /// </para>
        ///  </important>
        /// </summary>
        public AppCategory AppCategory
        {
            get { return this._appCategory; }
            set { this._appCategory = value; }
        }

        // Check to see if AppCategory property is set
        internal bool IsSetAppCategory()
        {
            return this._appCategory != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeInactive. 
        /// <para>
        /// A Boolean value that indicates whether to include inactive (unavailable) blueprints
        /// in the response of your request.
        /// </para>
        /// </summary>
        public bool IncludeInactive
        {
            get { return this._includeInactive.GetValueOrDefault(); }
            set { this._includeInactive = value; }
        }

        // Check to see if IncludeInactive property is set
        internal bool IsSetIncludeInactive()
        {
            return this._includeInactive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <code>GetBlueprints</code> request. If your
        /// results are paginated, the response will return a next page token that you can specify
        /// as the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken
        {
            get { return this._pageToken; }
            set { this._pageToken = value; }
        }

        // Check to see if PageToken property is set
        internal bool IsSetPageToken()
        {
            return this._pageToken != null;
        }

    }
}