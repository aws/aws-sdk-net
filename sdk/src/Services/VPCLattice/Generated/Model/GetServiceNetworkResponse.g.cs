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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the GetServiceNetwork operation.
    /// </summary>
    public partial class GetServiceNetworkResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of IAM policy.
        /// </para>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the service network was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time of the last update, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedServices. 
        /// <para>
        /// The number of services associated with the service network.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedServices { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociatedServices property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociatedServices() => this.NumberOfAssociatedServices.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfAssociatedVPCs. 
        /// <para>
        /// The number of VPCs associated with the service network.
        /// </para>
        /// </summary>
        public long? NumberOfAssociatedVPCs { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfAssociatedVPCs property is set.
        /// </summary>
        internal bool IsSetNumberOfAssociatedVPCs() => this.NumberOfAssociatedVPCs.HasValue;

        /// <summary>
        /// Gets and sets the property SharingConfig. 
        /// <para>
        /// Specifies if the service network is enabled for sharing.
        /// </para>
        /// </summary>
        public SharingConfig SharingConfig { get; set; }

        /// <summary>
        /// Checks to see if the SharingConfig property is set.
        /// </summary>
        internal bool IsSetSharingConfig() => this.SharingConfig != null;
    }
}
