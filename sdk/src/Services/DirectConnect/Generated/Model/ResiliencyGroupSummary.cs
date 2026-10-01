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
    /// Summary information about a resiliency group.
    /// </summary>
    public partial class ResiliencyGroupSummary
    {
        private string _ownerAccount;
        private string _resiliencyGroupArn;
        private string _resiliencyGroupId;
        private string _resiliencyGroupName;
        private ResiliencyGroupType _resiliencyGroupType;
        private ResiliencyGroupState _state;

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the resiliency group.
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ResiliencyGroupArn
        {
            get { return this._resiliencyGroupArn; }
            set { this._resiliencyGroupArn = value; }
        }

        // Check to see if ResiliencyGroupArn property is set
        internal bool IsSetResiliencyGroupArn()
        {
            return this._resiliencyGroupArn != null;
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
        /// Gets and sets the property ResiliencyGroupName. 
        /// <para>
        /// The name of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ResiliencyGroupName
        {
            get { return this._resiliencyGroupName; }
            set { this._resiliencyGroupName = value; }
        }

        // Check to see if ResiliencyGroupName property is set
        internal bool IsSetResiliencyGroupName()
        {
            return this._resiliencyGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyGroupType. 
        /// <para>
        /// The type of the resiliency group. The valid value is <c>Managed</c>.
        /// </para>
        /// </summary>
        public ResiliencyGroupType ResiliencyGroupType
        {
            get { return this._resiliencyGroupType; }
            set { this._resiliencyGroupType = value; }
        }

        // Check to see if ResiliencyGroupType property is set
        internal bool IsSetResiliencyGroupType()
        {
            return this._resiliencyGroupType != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the resiliency group.
        /// </para>
        /// </summary>
        public ResiliencyGroupState State
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