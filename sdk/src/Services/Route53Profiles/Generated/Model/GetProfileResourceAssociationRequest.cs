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
    /// Container for the parameters to the GetProfileResourceAssociation operation.
    /// Returns information about a specified Route 53 Profile resource association.
    /// </summary>
    public partial class GetProfileResourceAssociationRequest : AmazonRoute53ProfilesRequest
    {
        private string _profileResourceAssociationId;

        /// <summary>
        /// Gets and sets the property ProfileResourceAssociationId. 
        /// <para>
        ///  
        /// <para>
        /// The ID of the profile resource association that you want to get information about.
        /// </para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileResourceAssociationId
        {
            get { return this._profileResourceAssociationId; }
            set { this._profileResourceAssociationId = value; }
        }

        // Check to see if ProfileResourceAssociationId property is set
        internal bool IsSetProfileResourceAssociationId()
        {
            return this._profileResourceAssociationId != null;
        }

    }
}