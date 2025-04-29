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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetAccessToken operation.
    /// Returns a credentials set to be used with just-in-time node access.
    /// </summary>
    public partial class GetAccessTokenRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _accessRequestId;

        /// <summary>
        /// Gets and sets the property AccessRequestId. 
        /// <para>
        /// The ID of a just-in-time node access request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessRequestId
        {
            get { return this._accessRequestId; }
            set { this._accessRequestId = value; }
        }

        // Check to see if AccessRequestId property is set
        internal bool IsSetAccessRequestId()
        {
            return this._accessRequestId != null;
        }

    }
}