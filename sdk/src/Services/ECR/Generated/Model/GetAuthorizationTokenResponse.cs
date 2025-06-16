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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the GetAuthorizationToken operation.
    /// </summary>
    public partial class GetAuthorizationTokenResponse : AmazonWebServiceResponse
    {
        private List<AuthorizationData> _authorizationData = AWSConfigs.InitializeCollections ? new List<AuthorizationData>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizationData. 
        /// <para>
        /// A list of authorization token data objects that correspond to the <c>registryIds</c>
        /// values in the request.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the authorization token returned by Amazon ECR is not fixed. We recommend
        /// that you don't make assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthorizationData> AuthorizationData
        {
            get { return this._authorizationData; }
            set { this._authorizationData = value; }
        }

        // Check to see if AuthorizationData property is set
        internal bool IsSetAuthorizationData()
        {
            return this._authorizationData != null && (this._authorizationData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}