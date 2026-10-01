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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSite operation. Updates the information
    /// for an existing site. To remove information for any of the parameters, specify an
    /// empty string.
    /// </summary>
    public partial class UpdateSiteRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of your site.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum length of 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlobalNetworkId. 
        /// <para>
        /// The ID of the global network.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string GlobalNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalNetworkId property is set.
        /// </summary>
        internal bool IsSetGlobalNetworkId() => this.GlobalNetworkId != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The site location:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Address</c>: The physical address of the site.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Latitude</c>: The latitude of the site. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Longitude</c>: The longitude of the site.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Location Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property SiteId. 
        /// <para>
        /// The ID of your site.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string SiteId { get; set; }

        /// <summary>
        /// Checks to see if the SiteId property is set.
        /// </summary>
        internal bool IsSetSiteId() => this.SiteId != null;
    }
}
