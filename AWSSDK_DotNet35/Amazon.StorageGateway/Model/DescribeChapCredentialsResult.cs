/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// <para>A JSON object containing a .</para>
    /// </summary>
    public partial class DescribeChapCredentialsResult : AmazonWebServiceResponse
    {
        
        private List<ChapInfo> chapCredentials = new List<ChapInfo>();


        /// <summary>
        /// An array of <a>ChapInfo</a> objects that represent CHAP credentials. Each object in the array contains CHAP credential information for one
        /// target-initiator pair. If no CHAP credentials are set, an empty array is returned. CHAP credential information is provided in a JSON object
        /// with the following fields: <ul> <li> <b>InitiatorName</b>: The iSCSI initiator that connects to the target. </li> <li>
        /// <b>SecretToAuthenticateInitiator</b>: The secret key that the initiator (e.g. Windows client) must provide to participate in mutual CHAP
        /// with the target. </li> <li> <b>SecretToAuthenticateTarget</b>: The secret key that the target must provide to participate in mutual CHAP
        /// with the initiator (e.g. Windows client). </li> <li> <b>TargetARN</b>: The Amazon Resource Name (ARN) of the storage volume. </li> </ul>
        ///  
        /// </summary>
        public List<ChapInfo> ChapCredentials
        {
            get { return this.chapCredentials; }
            set { this.chapCredentials = value; }
        }

        // Check to see if ChapCredentials property is set
        internal bool IsSetChapCredentials()
        {
            return this.chapCredentials.Count > 0;
        }
    }
}
