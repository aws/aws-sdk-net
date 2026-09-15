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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about an association between a connection and a resiliency group.
    /// </summary>
    public partial class ResiliencyGroupAssociation
    {
        private string _connectionArn;
        private string _resiliencyGroupId;
        private ResiliencyGroupAssociationState _state;

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the associated connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyGroupId. 
        /// <para>
        /// The ID of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string ResiliencyGroupId
        {
            get { return this._resiliencyGroupId; }
            set { this._resiliencyGroupId = value; }
        }

        // Check to see if ResiliencyGroupId property is set
        internal bool IsSetResiliencyGroupId()
        {
            return this._resiliencyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the association. The valid values are <c>associating</c>, <c>associated</c>,
        /// <c>disassociating</c>, and <c>disassociated</c>.
        /// </para>
        /// </summary>
        public ResiliencyGroupAssociationState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}