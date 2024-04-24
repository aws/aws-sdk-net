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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private RouteTableAssociationState _associationState;
        private string _newAssociationId;

        /// <summary>
        /// Gets and sets the property AssociationState. 
        /// <para>
        /// The state of the association.
        /// </para>
        /// </summary>
        public RouteTableAssociationState AssociationState
        {
            get { return this._associationState; }
            set { this._associationState = value; }
        }

        // Check to see if AssociationState property is set
        internal bool IsSetAssociationState()
        {
            return this._associationState != null;
        }

        /// <summary>
        /// Gets and sets the property NewAssociationId. 
        /// <para>
        /// The ID of the new association.
        /// </para>
        /// </summary>
        public string NewAssociationId
        {
            get { return this._newAssociationId; }
            set { this._newAssociationId = value; }
        }

        // Check to see if NewAssociationId property is set
        internal bool IsSetNewAssociationId()
        {
            return this._newAssociationId != null;
        }

    }
}