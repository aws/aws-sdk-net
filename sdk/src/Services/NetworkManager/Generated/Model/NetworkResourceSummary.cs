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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a network resource.
    /// </summary>
    public partial class NetworkResourceSummary
    {
        private string _definition;
        private bool? _isMiddlebox;
        private string _nameTag;
        private string _registeredGatewayArn;
        private string _resourceArn;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Information about the resource, in JSON format. Network Manager gets this information
        /// by describing the resource using its Describe API call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Definition
        {
            get { return this._definition; }
            set { this._definition = value; }
        }

        // Check to see if Definition property is set
        internal bool IsSetDefinition()
        {
            return this._definition != null;
        }

        /// <summary>
        /// Gets and sets the property IsMiddlebox. 
        /// <para>
        /// Indicates whether this is a middlebox appliance.
        /// </para>
        /// </summary>
        public bool? IsMiddlebox
        {
            get { return this._isMiddlebox; }
            set { this._isMiddlebox = value; }
        }

        // Check to see if IsMiddlebox property is set
        internal bool IsSetIsMiddlebox()
        {
            return this._isMiddlebox.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameTag. 
        /// <para>
        /// The value for the Name tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NameTag
        {
            get { return this._nameTag; }
            set { this._nameTag = value; }
        }

        // Check to see if NameTag property is set
        internal bool IsSetNameTag()
        {
            return this._nameTag != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredGatewayArn. 
        /// <para>
        /// The ARN of the gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string RegisteredGatewayArn
        {
            get { return this._registeredGatewayArn; }
            set { this._registeredGatewayArn = value; }
        }

        // Check to see if RegisteredGatewayArn property is set
        internal bool IsSetRegisteredGatewayArn()
        {
            return this._registeredGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1500)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}