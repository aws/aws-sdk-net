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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// This data type represents the information you need to connect to an Amazon Neptune
    /// DB cluster. This data type is used as a response element in the following actions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateDBClusterEndpoint</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeDBClusterEndpoints</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ModifyDBClusterEndpoint</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteDBClusterEndpoint</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the data structure that represents Amazon Neptune DB instance endpoints, see <c>Endpoint</c>.
    /// </para>
    /// </summary>
    public partial class DBClusterEndpoint
    {
        private string _customEndpointType;
        private string _dbClusterEndpointArn;
        private string _dbClusterEndpointIdentifier;
        private string _dbClusterEndpointResourceIdentifier;
        private string _dbClusterIdentifier;
        private string _endpoint;
        private string _endpointType;
        private List<string> _excludedMembers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _staticMembers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;

        /// <summary>
        /// Gets and sets the property CustomEndpointType. 
        /// <para>
        /// The type associated with a custom endpoint. One of: <c>READER</c>, <c>WRITER</c>,
        /// <c>ANY</c>.
        /// </para>
        /// </summary>
        public string CustomEndpointType
        {
            get { return this._customEndpointType; }
            set { this._customEndpointType = value; }
        }

        // Check to see if CustomEndpointType property is set
        internal bool IsSetCustomEndpointType()
        {
            return this._customEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the endpoint.
        /// </para>
        /// </summary>
        public string DBClusterEndpointArn
        {
            get { return this._dbClusterEndpointArn; }
            set { this._dbClusterEndpointArn = value; }
        }

        // Check to see if DBClusterEndpointArn property is set
        internal bool IsSetDBClusterEndpointArn()
        {
            return this._dbClusterEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterEndpointIdentifier. 
        /// <para>
        /// The identifier associated with the endpoint. This parameter is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        public string DBClusterEndpointIdentifier
        {
            get { return this._dbClusterEndpointIdentifier; }
            set { this._dbClusterEndpointIdentifier = value; }
        }

        // Check to see if DBClusterEndpointIdentifier property is set
        internal bool IsSetDBClusterEndpointIdentifier()
        {
            return this._dbClusterEndpointIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterEndpointResourceIdentifier. 
        /// <para>
        /// A unique system-generated identifier for an endpoint. It remains the same for the
        /// whole life of the endpoint.
        /// </para>
        /// </summary>
        public string DBClusterEndpointResourceIdentifier
        {
            get { return this._dbClusterEndpointResourceIdentifier; }
            set { this._dbClusterEndpointResourceIdentifier = value; }
        }

        // Check to see if DBClusterEndpointResourceIdentifier property is set
        internal bool IsSetDBClusterEndpointResourceIdentifier()
        {
            return this._dbClusterEndpointResourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier of the DB cluster associated with the endpoint. This parameter
        /// is stored as a lowercase string.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The DNS address of the endpoint.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of the endpoint. One of: <c>READER</c>, <c>WRITER</c>, <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public string EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedMembers. 
        /// <para>
        /// List of DB instance identifiers that aren't part of the custom endpoint group. All
        /// other eligible instances are reachable through the custom endpoint. Only relevant
        /// if the list of static members is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExcludedMembers
        {
            get { return this._excludedMembers; }
            set { this._excludedMembers = value; }
        }

        // Check to see if ExcludedMembers property is set
        internal bool IsSetExcludedMembers()
        {
            return this._excludedMembers != null && (this._excludedMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StaticMembers. 
        /// <para>
        /// List of DB instance identifiers that are part of the custom endpoint group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StaticMembers
        {
            get { return this._staticMembers; }
            set { this._staticMembers = value; }
        }

        // Check to see if StaticMembers property is set
        internal bool IsSetStaticMembers()
        {
            return this._staticMembers != null && (this._staticMembers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the endpoint. One of: <c>creating</c>, <c>available</c>, <c>deleting</c>,
        /// <c>inactive</c>, <c>modifying</c>. The <c>inactive</c> state applies to an endpoint
        /// that cannot be used for a certain kind of cluster, such as a <c>writer</c> endpoint
        /// for a read-only secondary cluster in a global database.
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

    }
}