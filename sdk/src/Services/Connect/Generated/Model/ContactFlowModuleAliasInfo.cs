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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about an alias.
    /// </summary>
    public partial class ContactFlowModuleAliasInfo
    {
        private string _aliasId;
        private string _contactFlowModuleArn;
        private string _contactFlowModuleId;
        private string _description;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private string _name;
        private long? _version;

        /// <summary>
        /// Gets and sets the property AliasId. 
        /// <para>
        /// The identifier of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string AliasId
        {
            get { return this._aliasId; }
            set { this._aliasId = value; }
        }

        // Check to see if AliasId property is set
        internal bool IsSetAliasId()
        {
            return this._aliasId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowModuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow module.
        /// </para>
        /// </summary>
        public string ContactFlowModuleArn
        {
            get { return this._contactFlowModuleArn; }
            set { this._contactFlowModuleArn = value; }
        }

        // Check to see if ContactFlowModuleArn property is set
        internal bool IsSetContactFlowModuleArn()
        {
            return this._contactFlowModuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowModuleId. 
        /// <para>
        /// The identifier of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string ContactFlowModuleId
        {
            get { return this._contactFlowModuleId; }
            set { this._contactFlowModuleId = value; }
        }

        // Check to see if ContactFlowModuleId property is set
        internal bool IsSetContactFlowModuleId()
        {
            return this._contactFlowModuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}