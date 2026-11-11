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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Describes a trust relationship between an Managed Microsoft AD directory and an external
    /// domain.
    /// </summary>
    public partial class Trust
    {
        /// <summary>
        /// Gets and sets the property CreatedDateTime. 
        /// <para>
        /// The date and time that the trust relationship was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDateTime property is set.
        /// </summary>
        internal bool IsSetCreatedDateTime() => this.CreatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The Directory ID of the Amazon Web Services directory involved in the trust relationship.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time that the trust relationship was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RemoteDomainName. 
        /// <para>
        /// The Fully Qualified Domain Name (FQDN) of the external domain involved in the trust
        /// relationship.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RemoteDomainName { get; set; }

        /// <summary>
        /// Checks to see if the RemoteDomainName property is set.
        /// </summary>
        internal bool IsSetRemoteDomainName() => this.RemoteDomainName != null;

        /// <summary>
        /// Gets and sets the property SelectiveAuth. 
        /// <para>
        /// Current state of selective authentication for the trust.
        /// </para>
        /// </summary>
        public SelectiveAuth SelectiveAuth { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveAuth property is set.
        /// </summary>
        internal bool IsSetSelectiveAuth() => this.SelectiveAuth != null;

        /// <summary>
        /// Gets and sets the property StateLastUpdatedDateTime. 
        /// <para>
        /// The date and time that the TrustState was last updated.
        /// </para>
        /// </summary>
        public DateTime? StateLastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StateLastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetStateLastUpdatedDateTime() => this.StateLastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrustDirection. 
        /// <para>
        /// The trust relationship direction.
        /// </para>
        /// </summary>
        public TrustDirection TrustDirection { get; set; }

        /// <summary>
        /// Checks to see if the TrustDirection property is set.
        /// </summary>
        internal bool IsSetTrustDirection() => this.TrustDirection != null;

        /// <summary>
        /// Gets and sets the property TrustId. 
        /// <para>
        /// The unique ID of the trust relationship.
        /// </para>
        /// </summary>
        public string TrustId { get; set; }

        /// <summary>
        /// Checks to see if the TrustId property is set.
        /// </summary>
        internal bool IsSetTrustId() => this.TrustId != null;

        /// <summary>
        /// Gets and sets the property TrustState. 
        /// <para>
        /// The trust relationship state.
        /// </para>
        /// </summary>
        public TrustState TrustState { get; set; }

        /// <summary>
        /// Checks to see if the TrustState property is set.
        /// </summary>
        internal bool IsSetTrustState() => this.TrustState != null;

        /// <summary>
        /// Gets and sets the property TrustStateReason. 
        /// <para>
        /// The reason for the TrustState.
        /// </para>
        /// </summary>
        public string TrustStateReason { get; set; }

        /// <summary>
        /// Checks to see if the TrustStateReason property is set.
        /// </summary>
        internal bool IsSetTrustStateReason() => this.TrustStateReason != null;

        /// <summary>
        /// Gets and sets the property TrustType. 
        /// <para>
        /// The trust relationship type. <c>Forest</c> is the default.
        /// </para>
        /// </summary>
        public TrustType TrustType { get; set; }

        /// <summary>
        /// Checks to see if the TrustType property is set.
        /// </summary>
        internal bool IsSetTrustType() => this.TrustType != null;
    }
}
