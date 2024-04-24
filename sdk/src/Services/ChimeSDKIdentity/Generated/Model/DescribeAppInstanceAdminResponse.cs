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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// This is the response object from the DescribeAppInstanceAdmin operation.
    /// </summary>
    public partial class DescribeAppInstanceAdminResponse : AmazonWebServiceResponse
    {
        private AppInstanceAdmin _appInstanceAdmin;

        /// <summary>
        /// Gets and sets the property AppInstanceAdmin. 
        /// <para>
        /// The ARN and name of the <c>AppInstanceUser</c>, the ARN of the <c>AppInstance</c>,
        /// and the created and last-updated timestamps. All timestamps use epoch milliseconds.
        /// </para>
        /// </summary>
        public AppInstanceAdmin AppInstanceAdmin
        {
            get { return this._appInstanceAdmin; }
            set { this._appInstanceAdmin = value; }
        }

        // Check to see if AppInstanceAdmin property is set
        internal bool IsSetAppInstanceAdmin()
        {
            return this._appInstanceAdmin != null;
        }

    }
}