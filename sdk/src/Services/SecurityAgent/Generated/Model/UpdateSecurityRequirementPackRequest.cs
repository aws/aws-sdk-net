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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityRequirementPack operation.
    /// Updates a security requirement pack. For customer managed packs, both metadata and
    /// status can be updated. For AWS managed packs, only status can be updated.
    /// </summary>
    public partial class UpdateSecurityRequirementPackRequest : AmazonSecurityAgentRequest
    {
        private string _description;
        private string _name;
        private string _packId;
        private SecurityRequirementPackStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the security requirement pack.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the security requirement pack.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PackId. 
        /// <para>
        /// The unique identifier of the security requirement pack to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackId
        {
            get { return this._packId; }
            set { this._packId = value; }
        }

        // Check to see if PackId property is set
        internal bool IsSetPackId()
        {
            return this._packId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status of the security requirement pack.
        /// </para>
        /// </summary>
        public SecurityRequirementPackStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}