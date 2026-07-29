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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// An access control entry specifying a principal and their access level.
    /// </summary>
    public partial class DocumentAccessControlEntry
    {
        private AccessControlAccess _access;
        private string _name;
        private AccessControlPrincipalType _type;

        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        /// Whether to allow or deny access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessControlAccess Access
        {
            get { return this._access; }
            set { this._access = value; }
        }

        // Check to see if Access property is set
        internal bool IsSetAccess()
        {
            return this._access != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessControlPrincipalType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}