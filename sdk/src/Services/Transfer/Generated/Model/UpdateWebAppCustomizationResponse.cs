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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the UpdateWebAppCustomization operation.
    /// </summary>
    public partial class UpdateWebAppCustomizationResponse : AmazonWebServiceResponse
    {
        private string _webAppId;

        /// <summary>
        /// Gets and sets the property WebAppId. 
        /// <para>
        /// Returns the unique identifier for the web app being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24, Max=24)]
        public string WebAppId
        {
            get { return this._webAppId; }
            set { this._webAppId = value; }
        }

        // Check to see if WebAppId property is set
        internal bool IsSetWebAppId()
        {
            return this._webAppId != null;
        }

    }
}