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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// This is the response object from the CreateDirectoryRegistration operation.
    /// </summary>
    public partial class CreateDirectoryRegistrationResponse : AmazonWebServiceResponse
    {
        private string _directoryRegistrationArn;

        /// <summary>
        /// Gets and sets the property DirectoryRegistrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration.html">CreateDirectoryRegistration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=200)]
        public string DirectoryRegistrationArn
        {
            get { return this._directoryRegistrationArn; }
            set { this._directoryRegistrationArn = value; }
        }

        // Check to see if DirectoryRegistrationArn property is set
        internal bool IsSetDirectoryRegistrationArn()
        {
            return this._directoryRegistrationArn != null;
        }

    }
}