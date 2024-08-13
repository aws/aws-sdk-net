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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTestGridUrl operation.
    /// Creates a signed, short-term URL that can be passed to a Selenium <c>RemoteWebDriver</c>
    /// constructor.
    /// </summary>
    public partial class CreateTestGridUrlRequest : AmazonDeviceFarmRequest
    {
        private int? _expiresInSeconds;
        private string _projectArn;

        /// <summary>
        /// Gets and sets the property ExpiresInSeconds. 
        /// <para>
        /// Lifetime, in seconds, of the URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=60, Max=86400)]
        public int? ExpiresInSeconds
        {
            get { return this._expiresInSeconds; }
            set { this._expiresInSeconds = value; }
        }

        // Check to see if ExpiresInSeconds property is set
        internal bool IsSetExpiresInSeconds()
        {
            return this._expiresInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// ARN (from <a>CreateTestGridProject</a> or <a>ListTestGridProjects</a>) to associate
        /// with the short-term URL. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

    }
}