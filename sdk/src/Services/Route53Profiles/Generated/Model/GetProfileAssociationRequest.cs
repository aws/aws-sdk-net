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
    /// Container for the parameters to the GetProfileAssociation operation.
    /// Retrieves a Route 53 Profile association for a VPC. A VPC can have only one Profile
    /// association, but a Profile can be associated with up to 5000 VPCs.
    /// </summary>
    public partial class GetProfileAssociationRequest : AmazonRoute53ProfilesRequest
    {
        private string _profileAssociationId;

        /// <summary>
        /// Gets and sets the property ProfileAssociationId. 
        /// <para>
        ///  The identifier of the association you want to get information about. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ProfileAssociationId
        {
            get { return this._profileAssociationId; }
            set { this._profileAssociationId = value; }
        }

        // Check to see if ProfileAssociationId property is set
        internal bool IsSetProfileAssociationId()
        {
            return this._profileAssociationId != null;
        }

    }
}