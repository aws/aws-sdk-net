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
    /// This is the response object from the CreateSecurityProfile operation.
    /// </summary>
    public partial class CreateSecurityProfileResponse : AmazonWebServiceResponse
    {
        private string _securityProfileArn;
        private string _securityProfileName;

        /// <summary>
        /// Gets and sets the property SecurityProfileArn. 
        /// <para>
        /// The ARN of the security profile.
        /// </para>
        /// </summary>
        public string SecurityProfileArn
        {
            get { return this._securityProfileArn; }
            set { this._securityProfileArn = value; }
        }

        // Check to see if SecurityProfileArn property is set
        internal bool IsSetSecurityProfileArn()
        {
            return this._securityProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name you gave to the security profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

    }
}