/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the TestAuthorization operation.
    /// </summary>
    public partial class TestAuthorizationResponse : AmazonWebServiceResponse
    {
        private List<AuthResult> _authResults = new List<AuthResult>();

        /// <summary>
        /// Gets and sets the property AuthResults. 
        /// <para>
        /// The authentication results.
        /// </para>
        /// </summary>
        public List<AuthResult> AuthResults
        {
            get { return this._authResults; }
            set { this._authResults = value; }
        }

        // Check to see if AuthResults property is set
        internal bool IsSetAuthResults()
        {
            return this._authResults != null && this._authResults.Count > 0; 
        }

    }
}