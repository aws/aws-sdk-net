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
    /// This is the response object from the DeleteResourceEndpointAssociation operation.
    /// </summary>
    public partial class DeleteResourceEndpointAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource configuration associated with the VPC
        /// endpoint of type resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ResourceConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationArn property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationArn() => this.ResourceConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ResourceConfigurationId. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string ResourceConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfigurationId property is set.
        /// </summary>
        internal bool IsSetResourceConfigurationId() => this.ResourceConfigurationId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the resource VPC endpoint that is associated with the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
