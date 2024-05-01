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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The IP rules of the IP access settings.
    /// </summary>
    public partial class IpRule
    {
        private string _description;
        private string _ipRange;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IP rule.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IpRange. 
        /// <para>
        /// The IP range of the IP rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string IpRange
        {
            get { return this._ipRange; }
            set { this._ipRange = value; }
        }

        // Check to see if IpRange property is set
        internal bool IsSetIpRange()
        {
            return this._ipRange != null;
        }

    }
}