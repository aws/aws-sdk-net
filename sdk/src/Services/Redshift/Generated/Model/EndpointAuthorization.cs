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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an endpoint authorization for authorizing Redshift-managed VPC endpoint
    /// access to a cluster across Amazon Web Services accounts.
    /// </summary>
    public partial class EndpointAuthorization
    {
        private bool? _allowedAllVPCs;
        private List<string> _allowedVPCs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _authorizeTime;
        private string _clusterIdentifier;
        private string _clusterStatus;
        private int? _endpointCount;
        private string _grantee;
        private string _grantor;
        private AuthorizationStatus _status;

        /// <summary>
        /// Gets and sets the property AllowedAllVPCs. 
        /// <para>
        /// Indicates whether all VPCs in the grantee account are allowed access to the cluster.
        /// </para>
        /// </summary>
        public bool? AllowedAllVPCs
        {
            get { return this._allowedAllVPCs; }
            set { this._allowedAllVPCs = value; }
        }

        // Check to see if AllowedAllVPCs property is set
        internal bool IsSetAllowedAllVPCs()
        {
            return this._allowedAllVPCs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllowedVPCs. 
        /// <para>
        /// The VPCs allowed access to the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedVPCs
        {
            get { return this._allowedVPCs; }
            set { this._allowedVPCs = value; }
        }

        // Check to see if AllowedVPCs property is set
        internal bool IsSetAllowedVPCs()
        {
            return this._allowedVPCs != null && (this._allowedVPCs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AuthorizeTime. 
        /// <para>
        /// The time (UTC) when the authorization was created.
        /// </para>
        /// </summary>
        public DateTime? AuthorizeTime
        {
            get { return this._authorizeTime; }
            set { this._authorizeTime = value; }
        }

        // Check to see if AuthorizeTime property is set
        internal bool IsSetAuthorizeTime()
        {
            return this._authorizeTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterStatus
        {
            get { return this._clusterStatus; }
            set { this._clusterStatus = value; }
        }

        // Check to see if ClusterStatus property is set
        internal bool IsSetClusterStatus()
        {
            return this._clusterStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointCount. 
        /// <para>
        /// The number of Redshift-managed VPC endpoints created for the authorization.
        /// </para>
        /// </summary>
        public int? EndpointCount
        {
            get { return this._endpointCount; }
            set { this._endpointCount = value; }
        }

        // Check to see if EndpointCount property is set
        internal bool IsSetEndpointCount()
        {
            return this._endpointCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The Amazon Web Services account ID of the grantee of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Grantee
        {
            get { return this._grantee; }
            set { this._grantee = value; }
        }

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this._grantee != null;
        }

        /// <summary>
        /// Gets and sets the property Grantor. 
        /// <para>
        /// The Amazon Web Services account ID of the cluster owner.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Grantor
        {
            get { return this._grantor; }
            set { this._grantor = value; }
        }

        // Check to see if Grantor property is set
        internal bool IsSetGrantor()
        {
            return this._grantor != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the authorization action.
        /// </para>
        /// </summary>
        public AuthorizationStatus Status
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