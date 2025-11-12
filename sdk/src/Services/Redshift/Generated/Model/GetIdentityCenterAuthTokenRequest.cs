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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the GetIdentityCenterAuthToken operation.
    /// Generates an encrypted authentication token that propagates the caller's Amazon Web
    /// Services IAM Identity Center identity to Amazon Redshift clusters. This API extracts
    /// the Amazon Web Services IAM Identity Center identity from enhanced credentials and
    /// creates a secure token that Amazon Redshift drivers can use for authentication.
    /// 
    ///  
    /// <para>
    /// The token is encrypted using Key Management Service (KMS) and can only be decrypted
    /// by the specified Amazon Redshift clusters. The token contains the caller's Amazon
    /// Web Services IAM Identity Center identity information and is valid for a limited time
    /// period.
    /// </para>
    ///  
    /// <para>
    /// This API is exclusively for use with Amazon Web Services IAM Identity Center enhanced
    /// credentials. If the caller is not using enhanced credentials with embedded Amazon
    /// Web Services IAM Identity Center identity, the API will return an error.
    /// </para>
    /// </summary>
    public partial class GetIdentityCenterAuthTokenRequest : AmazonRedshiftRequest
    {
        private List<string> _clusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterIds. 
        /// <para>
        /// A list of cluster identifiers that the generated token can be used with. The token
        /// will be scoped to only allow authentication to the specified clusters.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ClusterIds</c> must contain at least 1 cluster identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ClusterIds</c> can hold a maximum of 20 cluster identifiers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cluster identifiers must be 1 to 63 characters in length.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The characters accepted for cluster identifiers are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Alphanumeric characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hyphens
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Cluster identifiers must start with a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cluster identifiers can't end with a hyphen or contain two consecutive hyphens.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ClusterIds
        {
            get { return this._clusterIds; }
            set { this._clusterIds = value; }
        }

        // Check to see if ClusterIds property is set
        internal bool IsSetClusterIds()
        {
            return this._clusterIds != null && (this._clusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}