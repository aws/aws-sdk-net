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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// When using MediaConnect Router as the source of a MediaLive input there's a special
    /// handoff that occurs when a router outputis created. This group of settings is set
    /// on your behalf by the MediaConnect Router service using this set of settings. Thissetting
    /// object can only by used by that service.
    /// </summary>
    public partial class SpecialRouterSettings
    {
        private string _routerArn;

        /// <summary>
        /// Gets and sets the property RouterArn. This is the arn of the MediaConnect Router resource
        /// being associated with the MediaLive Input.
        /// </summary>
        public string RouterArn
        {
            get { return this._routerArn; }
            set { this._routerArn = value; }
        }

        // Check to see if RouterArn property is set
        internal bool IsSetRouterArn()
        {
            return this._routerArn != null;
        }

    }
}