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

namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// This is the response object from the AssociateBrowserSettings operation.
    /// </summary>
    public partial class AssociateBrowserSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BrowserSettingsArn. 
        /// <para>
        /// The ARN of the browser settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string BrowserSettingsArn { get; set; }

        /// <summary>
        /// Checks to see if the BrowserSettingsArn property is set.
        /// </summary>
        internal bool IsSetBrowserSettingsArn() => this.BrowserSettingsArn != null;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the web portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string PortalArn { get; set; }

        /// <summary>
        /// Checks to see if the PortalArn property is set.
        /// </summary>
        internal bool IsSetPortalArn() => this.PortalArn != null;
    }
}
