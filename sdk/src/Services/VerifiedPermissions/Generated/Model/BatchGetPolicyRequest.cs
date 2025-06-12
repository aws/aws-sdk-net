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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetPolicy operation.
    /// Retrieves information about a group (batch) of policies.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>BatchGetPolicy</c> operation doesn't have its own IAM permission. To authorize
    /// this operation for Amazon Web Services principals, include the permission <c>verifiedpermissions:GetPolicy</c>
    /// in their IAM policies.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchGetPolicyRequest : AmazonVerifiedPermissionsRequest
    {
        private List<BatchGetPolicyInputItem> _requests = AWSConfigs.InitializeCollections ? new List<BatchGetPolicyInputItem>() : null;

        /// <summary>
        /// Gets and sets the property Requests. 
        /// <para>
        /// An array of up to 100 policies you want information about.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<BatchGetPolicyInputItem> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && (this._requests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}