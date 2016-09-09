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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server to the request to start the user import job.
    /// </summary>
    public partial class StartUserImportJobResponse : AmazonWebServiceResponse
    {
        private UserImportJobType _userImportJob;

        /// <summary>
        /// Gets and sets the property UserImportJob. 
        /// <para>
        /// The job object that represents the user import job.
        /// </para>
        /// </summary>
        public UserImportJobType UserImportJob
        {
            get { return this._userImportJob; }
            set { this._userImportJob = value; }
        }

        // Check to see if UserImportJob property is set
        internal bool IsSetUserImportJob()
        {
            return this._userImportJob != null;
        }

    }
}