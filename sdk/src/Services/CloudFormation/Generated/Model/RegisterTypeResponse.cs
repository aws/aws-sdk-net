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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the RegisterType operation.
    /// </summary>
    public partial class RegisterTypeResponse : AmazonWebServiceResponse
    {
        private string _registrationToken;

        /// <summary>
        /// Gets and sets the property RegistrationToken. 
        /// <para>
        /// The identifier for this registration request.
        /// </para>
        ///  
        /// <para>
        /// Use this registration token when calling <a>DescribeTypeRegistration</a>, which returns
        /// information about the status and IDs of the extension registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RegistrationToken
        {
            get { return this._registrationToken; }
            set { this._registrationToken = value; }
        }

        // Check to see if RegistrationToken property is set
        internal bool IsSetRegistrationToken()
        {
            return this._registrationToken != null;
        }

    }
}