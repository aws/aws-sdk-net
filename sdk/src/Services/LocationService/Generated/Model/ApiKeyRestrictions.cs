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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// API Restrictions on the allowed actions, resources, and referers for an API key resource.
    /// </summary>
    public partial class ApiKeyRestrictions
    {
        private List<string> _allowActions = new List<string>();
        private List<string> _allowReferers = new List<string>();
        private List<string> _allowResources = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowActions. 
        /// <para>
        /// A list of allowed actions that an API key resource grants permissions to perform.
        /// You must have at least one action for each type of resource. For example, if you have
        /// a place resource, you must include at least one place action.
        /// </para>
        ///  
        /// <para>
        /// The following are valid values for the actions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Map actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>geo:GetMap*</code> - Allows all actions needed for map rendering.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Place actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>geo:SearchPlaceIndexForText</code> - Allows geocoding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>geo:SearchPlaceIndexForPosition</code> - Allows reverse geocoding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>geo:SearchPlaceIndexForSuggestions</code> - Allows generating suggestions from
        /// text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetPlace</code> - Allows finding a place by place ID.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Route actions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>geo:CalculateRoute</code> - Allows point to point routing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>geo:CalculateRouteMatrix</code> - Allows calculating a matrix of routes.
        /// </para>
        ///  </li> </ul> </li> </ul> <note> 
        /// <para>
        /// You must use these strings exactly. For example, to provide access to map rendering,
        /// the only valid action is <code>geo:GetMap*</code> as an input to the list. <code>["geo:GetMap*"]</code>
        /// is valid but <code>["geo:GetMapTile"]</code> is not. Similarly, you cannot use <code>["geo:SearchPlaceIndexFor*"]</code>
        /// - you must list each of the Place actions separately.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public List<string> AllowActions
        {
            get { return this._allowActions; }
            set { this._allowActions = value; }
        }

        // Check to see if AllowActions property is set
        internal bool IsSetAllowActions()
        {
            return this._allowActions != null && this._allowActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowReferers. 
        /// <para>
        /// An optional list of allowed HTTP referers for which requests must originate from.
        /// Requests using this API key from other domains will not be allowed.
        /// </para>
        ///  
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only alphanumeric characters (A–Z, a–z, 0–9) or any symbols in this list <code>$\-._+!*`(),;/?:@=&amp;</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// May contain a percent (%) if followed by 2 hexadecimal digits (A-F, a-f, 0-9); this
        /// is used for URL encoding purposes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// May contain wildcard characters question mark (?) and asterisk (*).
        /// </para>
        ///  
        /// <para>
        /// Question mark (?) will replace any single character (including hexadecimal digits).
        /// </para>
        ///  
        /// <para>
        /// Asterisk (*) will replace any multiple characters (including multiple hexadecimal
        /// digits).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>https://example.com</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> AllowReferers
        {
            get { return this._allowReferers; }
            set { this._allowReferers = value; }
        }

        // Check to see if AllowReferers property is set
        internal bool IsSetAllowReferers()
        {
            return this._allowReferers != null && this._allowReferers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowResources. 
        /// <para>
        /// A list of allowed resource ARNs that a API key bearer can perform actions on.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The ARN must be the correct ARN for a map, place, or route ARN. You may include wildcards
        /// in the resource-id to match multiple resources of the same type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The resources must be in the same <code>partition</code>, <code>region</code>, and
        /// <code>account-id</code> as the key that is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Other than wildcards, you must include the full ARN, including the <code>arn</code>,
        /// <code>partition</code>, <code>service</code>, <code>region</code>, <code>account-id</code>
        /// and <code>resource-id</code>, delimited by colons (:).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed, even with wildcards. For example, <code>arn:aws:geo:region:<i>account-id</i>:map/ExampleMap*</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about ARN format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> AllowResources
        {
            get { return this._allowResources; }
            set { this._allowResources = value; }
        }

        // Check to see if AllowResources property is set
        internal bool IsSetAllowResources()
        {
            return this._allowResources != null && this._allowResources.Count > 0; 
        }

    }
}