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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides the configuration information to connect to GitHub Enterprise Cloud (SaaS).
    /// </summary>
    public partial class SaaSConfiguration
    {
        /// <summary>
        /// Gets and sets the property HostUrl. 
        /// <para>
        /// The GitHub host URL or API endpoint URL. For example, <i>https://api.github.com</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string HostUrl { get; set; }

        /// <summary>
        /// Checks to see if the HostUrl property is set.
        /// </summary>
        internal bool IsSetHostUrl() => this.HostUrl != null;

        /// <summary>
        /// Gets and sets the property OrganizationName. 
        /// <para>
        /// The name of the organization of the GitHub Enterprise Cloud (SaaS) account you want
        /// to connect to. You can find your organization name by logging into GitHub desktop
        /// and selecting <b>Your organizations</b> under your profile picture dropdown.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationName property is set.
        /// </summary>
        internal bool IsSetOrganizationName() => this.OrganizationName != null;
    }
}
