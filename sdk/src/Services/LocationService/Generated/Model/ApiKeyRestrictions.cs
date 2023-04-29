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
        /// A list of allowed actions that an API key resource grants permissions to perform
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, the only valid action is <code>geo:GetMap*</code> as an input to the list.
        /// For example, <code>["geo:GetMap*"]</code> is valid but <code>["geo:GetMapTile"]</code>
        /// is not.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
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
        /// A list of allowed resource ARNs that a API key bearer can perform actions on
        /// </para>
        ///  
        /// <para>
        /// For more information about ARN format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// In this preview, you can allow only map resources.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be prefixed with <code>arn</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>partition</code> and <code>service</code> must not be empty and should begin
        /// with only alphanumeric characters (A–Z, a–z, 0–9) and contain only alphanumeric numbers,
        /// hyphens (-) and periods (.).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>region</code> and <code>account-id</code> can be empty or should begin with
        /// only alphanumeric characters (A–Z, a–z, 0–9) and contain only alphanumeric numbers,
        /// hyphens (-) and periods (.).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>resource-id</code> can begin with any character except for forward slash (/)
        /// and contain any characters after, including forward slashes to form a path.
        /// </para>
        ///  
        /// <para>
        ///  <code>resource-id</code> can also include wildcard characters, denoted by an asterisk
        /// (*).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn</code>, <code>partition</code>, <code>service</code>, <code>region</code>,
        /// <code>account-id</code> and <code>resource-id</code> must be delimited by a colon
        /// (:).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// No spaces allowed. For example, <code>arn:aws:geo:region:<i>account-id</i>:map/ExampleMap*</code>.
        /// </para>
        ///  </li> </ul>
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