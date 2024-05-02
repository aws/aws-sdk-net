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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to write a message to a Salesforce IoT Cloud Input Stream.
    /// </summary>
    public partial class SalesforceAction
    {
        private string _token;
        private string _url;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The token used to authenticate access to the Salesforce IoT Cloud Input Stream. The
        /// token is available from the Salesforce IoT Cloud platform after creation of the Input
        /// Stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=40)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL exposed by the Salesforce IoT Cloud Input Stream. The URL is available from
        /// the Salesforce IoT Cloud platform after creation of the Input Stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2000)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}