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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// This is the response object from the ListSigningProfiles operation.
    /// </summary>
    public partial class ListSigningProfilesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SigningProfile> _profiles = AWSConfigs.InitializeCollections ? new List<SigningProfile>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Value for specifying the next set of paginated results to return.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Profiles. 
        /// <para>
        /// A list of profiles that are available in the AWS account. This includes profiles with
        /// the status of <c>CANCELED</c> if the <c>includeCanceled</c> parameter is set to <c>true</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SigningProfile> Profiles
        {
            get { return this._profiles; }
            set { this._profiles = value; }
        }

        // Check to see if Profiles property is set
        internal bool IsSetProfiles()
        {
            return this._profiles != null && (this._profiles.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}