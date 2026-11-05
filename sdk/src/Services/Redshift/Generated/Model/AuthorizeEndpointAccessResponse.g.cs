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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the AuthorizeEndpointAccess operation.
    /// </summary>
    public partial class AuthorizeEndpointAccessResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowedAllVPCs. 
        /// <para>
        /// Indicates whether all VPCs in the grantee account are allowed access to the cluster.
        /// </para>
        /// </summary>
        public bool? AllowedAllVPCs { get; set; }

        /// <summary>
        /// Checks to see if the AllowedAllVPCs property is set.
        /// </summary>
        internal bool IsSetAllowedAllVPCs() => this.AllowedAllVPCs.HasValue;

        /// <summary>
        /// Gets and sets the property AllowedVPCs. 
        /// <para>
        /// The VPCs allowed access to the cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedVPCs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedVPCs property is set.
        /// </summary>
        internal bool IsSetAllowedVPCs() => this.AllowedVPCs != null && (this.AllowedVPCs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AuthorizeTime. 
        /// <para>
        /// The time (UTC) when the authorization was created.
        /// </para>
        /// </summary>
        public DateTime? AuthorizeTime { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizeTime property is set.
        /// </summary>
        internal bool IsSetAuthorizeTime() => this.AuthorizeTime.HasValue;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property EndpointCount. 
        /// <para>
        /// The number of Redshift-managed VPC endpoints created for the authorization.
        /// </para>
        /// </summary>
        public int? EndpointCount { get; set; }

        /// <summary>
        /// Checks to see if the EndpointCount property is set.
        /// </summary>
        internal bool IsSetEndpointCount() => this.EndpointCount.HasValue;

        /// <summary>
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The Amazon Web Services account ID of the grantee of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Grantee { get; set; }

        /// <summary>
        /// Checks to see if the Grantee property is set.
        /// </summary>
        internal bool IsSetGrantee() => this.Grantee != null;

        /// <summary>
        /// Gets and sets the property Grantor. 
        /// <para>
        /// The Amazon Web Services account ID of the cluster owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Grantor { get; set; }

        /// <summary>
        /// Checks to see if the Grantor property is set.
        /// </summary>
        internal bool IsSetGrantor() => this.Grantor != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the authorization action.
        /// </para>
        /// </summary>
        public AuthorizationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
