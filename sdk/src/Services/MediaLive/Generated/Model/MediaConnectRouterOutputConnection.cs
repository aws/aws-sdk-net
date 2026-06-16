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
    /// Connection details for a single pipeline of a MediaConnect Router output.
    /// </summary>
    public partial class MediaConnectRouterOutputConnection
    {
        private string _routerInputArn;

        /// <summary>
        /// Gets and sets the property RouterInputArn. The ARN of the MediaConnect Router Input
        /// connected to this pipeline.
        /// </summary>
        public string RouterInputArn
        {
            get { return this._routerInputArn; }
            set { this._routerInputArn = value; }
        }

        // Check to see if RouterInputArn property is set
        internal bool IsSetRouterInputArn()
        {
            return this._routerInputArn != null;
        }

    }
}