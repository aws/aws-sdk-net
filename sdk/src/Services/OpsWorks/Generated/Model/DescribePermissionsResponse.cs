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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <c>DescribePermissions</c> request.
    /// </summary>
    public partial class DescribePermissionsResponse : AmazonWebServiceResponse
    {
        private List<Permission> _permissions = AWSConfigs.InitializeCollections ? new List<Permission>() : null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// An array of <c>Permission</c> objects that describe the stack permissions.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the request object contains only a stack ID, the array contains a <c>Permission</c>
        /// object with permissions for each of the stack IAM ARNs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the request object contains only an IAM ARN, the array contains a <c>Permission</c>
        /// object with permissions for each of the user's stack IDs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the request contains a stack ID and an IAM ARN, the array contains a single <c>Permission</c>
        /// object with permissions for the specified stack and IAM ARN.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Permission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}