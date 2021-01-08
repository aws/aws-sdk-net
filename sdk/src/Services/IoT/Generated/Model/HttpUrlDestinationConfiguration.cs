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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// HTTP URL destination configuration used by the topic rule's HTTP action.
    /// </summary>
    public partial class HttpUrlDestinationConfiguration
    {
        private string _confirmationUrl;

        /// <summary>
        /// Gets and sets the property ConfirmationUrl. 
        /// <para>
        /// The URL AWS IoT uses to confirm ownership of or access to the topic rule destination
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2000)]
        public string ConfirmationUrl
        {
            get { return this._confirmationUrl; }
            set { this._confirmationUrl = value; }
        }

        // Check to see if ConfirmationUrl property is set
        internal bool IsSetConfirmationUrl()
        {
            return this._confirmationUrl != null;
        }

    }
}