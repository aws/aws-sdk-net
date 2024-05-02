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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// This is the response object from the GetServiceRoleForAccount operation.
    /// </summary>
    public partial class GetServiceRoleForAccountResponse : AmazonWebServiceResponse
    {
        private string _associatedAt;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AssociatedAt. The time when the service role was associated
        /// with the account.
        /// </summary>
        public string AssociatedAt
        {
            get { return this._associatedAt; }
            set { this._associatedAt = value; }
        }

        // Check to see if AssociatedAt property is set
        internal bool IsSetAssociatedAt()
        {
            return this._associatedAt != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The ARN of the role which is associated with the
        /// account.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}