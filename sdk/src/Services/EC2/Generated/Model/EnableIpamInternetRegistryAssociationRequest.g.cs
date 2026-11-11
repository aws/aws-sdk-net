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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableIpamInternetRegistryAssociation operation.
    /// Enables Resource Public Key Infrastructure (RPKI) on an existing IPAM internet registry
    /// association by providing BGP Public Key Infrastructure (BPKI) certificate details.
    /// After enabling, you can create Route Origin Authorizations (ROAs) for prefixes registered
    /// with the internet registry.
    /// </summary>
    public partial class EnableIpamInternetRegistryAssociationRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ChildHandle. 
        /// <para>
        /// The child handle for the BPKI certificate hierarchy from the Parent Response XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ChildHandle { get; set; }

        /// <summary>
        /// Checks to see if the ChildHandle property is set.
        /// </summary>
        internal bool IsSetChildHandle() => this.ChildHandle != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the operation ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamInternetRegistryAssociationId. 
        /// <para>
        /// The ID of the IPAM internet registry association to enable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamInternetRegistryAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the IpamInternetRegistryAssociationId property is set.
        /// </summary>
        internal bool IsSetIpamInternetRegistryAssociationId() => this.IpamInternetRegistryAssociationId != null;

        /// <summary>
        /// Gets and sets the property ParentBpkiTa. 
        /// <para>
        /// The parent BPKI Trust Anchor certificate in PEM format from the Parent Response XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ParentBpkiTa { get; set; }

        /// <summary>
        /// Checks to see if the ParentBpkiTa property is set.
        /// </summary>
        internal bool IsSetParentBpkiTa() => this.ParentBpkiTa != null;

        /// <summary>
        /// Gets and sets the property ParentHandle. 
        /// <para>
        /// The parent handle for the BPKI certificate hierarchy from the Parent Response XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ParentHandle { get; set; }

        /// <summary>
        /// Checks to see if the ParentHandle property is set.
        /// </summary>
        internal bool IsSetParentHandle() => this.ParentHandle != null;

        /// <summary>
        /// Gets and sets the property RpkiVersion. 
        /// <para>
        /// The RPKI version to use from the Parent Response XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RpkiVersion { get; set; }

        /// <summary>
        /// Checks to see if the RpkiVersion property is set.
        /// </summary>
        internal bool IsSetRpkiVersion() => this.RpkiVersion != null;

        /// <summary>
        /// Gets and sets the property ServiceUri. 
        /// <para>
        /// The RPKI service URI for the publication point from the Parent Response XML.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceUri { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUri property is set.
        /// </summary>
        internal bool IsSetServiceUri() => this.ServiceUri != null;
    }
}
