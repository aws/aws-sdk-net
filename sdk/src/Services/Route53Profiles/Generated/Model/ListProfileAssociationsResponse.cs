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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
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
namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// This is the response object from the ListProfileAssociations operation.
    /// </summary>
    public partial class ListProfileAssociationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProfileAssociation> _profileAssociations = AWSConfigs.InitializeCollections ? new List<ProfileAssociation>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If more than <c>MaxResults</c> profile associations match the specified criteria,
        /// you can submit another <c>ListProfileAssociations</c> request to get the next group
        /// of results. In the next request, specify the value of <c>NextToken</c> from the previous
        /// response. 
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
        /// Gets and sets the property ProfileAssociations. 
        /// <para>
        ///  A complex type that containts settings information about the profile's VPC associations.
        /// 
        /// </para>
        /// </summary>
        public List<ProfileAssociation> ProfileAssociations
        {
            get { return this._profileAssociations; }
            set { this._profileAssociations = value; }
        }

        // Check to see if ProfileAssociations property is set
        internal bool IsSetProfileAssociations()
        {
            return this._profileAssociations != null && (this._profileAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}