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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the CreatePresignedPortalUrl operation.
    /// </summary>
    public partial class CreatePresignedPortalUrlResponse : AmazonWebServiceResponse
    {
        private string _presignedPortalUrl;

        /// <summary>
        /// Gets and sets the property PresignedPortalUrl. 
        /// <para>
        /// The pre-signed URL to the portal. The URL contains the portal ID and a session token
        /// that lets you access the portal. The URL has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>https://&lt;portal-id&gt;.app.iotsitewise.aws/auth?token=&lt;encrypted-token&gt;</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PresignedPortalUrl
        {
            get { return this._presignedPortalUrl; }
            set { this._presignedPortalUrl = value; }
        }

        // Check to see if PresignedPortalUrl property is set
        internal bool IsSetPresignedPortalUrl()
        {
            return this._presignedPortalUrl != null;
        }

    }
}