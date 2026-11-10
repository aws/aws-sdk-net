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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ReplaceRouteTableAssociation operation.
    /// </summary>
    public partial class ReplaceRouteTableAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The state of the association.
        /// </para>
        /// </summary>
        public RouteTableAssociationState AssociationState { get; set; }

        /// <summary>
        /// Checks to see if the AssociationState property is set.
        /// </summary>
        internal bool IsSetAssociationState() => this.AssociationState != null;

        /// <summary>
        /// Gets and sets the property NewAssociationId. 
        /// <para>
        /// The ID of the new association.
        /// </para>
        /// </summary>
        public string NewAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the NewAssociationId property is set.
        /// </summary>
        internal bool IsSetNewAssociationId() => this.NewAssociationId != null;
    }
}
