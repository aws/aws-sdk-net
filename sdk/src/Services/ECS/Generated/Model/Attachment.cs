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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// An object representing a container instance or task attachment.
    /// </summary>
    public partial class Attachment
    {
        private List<KeyValuePair> _details = AWSConfigs.InitializeCollections ? new List<KeyValuePair>() : null;
        private string _id;
        private string _status;
        private string _type;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Details of the attachment.
        /// </para>
        ///  
        /// <para>
        /// For elastic network interfaces, this includes the network interface ID, the MAC address,
        /// the subnet ID, and the private IPv4 address.
        /// </para>
        ///  
        /// <para>
        /// For Service Connect services, this includes <c>portName</c>, <c>clientAliases</c>,
        /// <c>discoveryName</c>, and <c>ingressPortOverride</c>.
        /// </para>
        ///  
        /// <para>
        /// For Elastic Block Storage, this includes <c>roleArn</c>, <c>deleteOnTermination</c>,
        /// <c>volumeName</c>, <c>volumeId</c>, and <c>statusReason</c> (only when the attachment
        /// fails to create or attach).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KeyValuePair> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the attachment.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the attachment. Valid values are <c>PRECREATED</c>, <c>CREATED</c>,
        /// <c>ATTACHING</c>, <c>ATTACHED</c>, <c>DETACHING</c>, <c>DETACHED</c>, <c>DELETED</c>,
        /// and <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the attachment, such as <c>ElasticNetworkInterface</c>, <c>Service Connect</c>,
        /// and <c>AmazonElasticBlockStorage</c>.
        /// </para>
        /// </summary>
        public string Type
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