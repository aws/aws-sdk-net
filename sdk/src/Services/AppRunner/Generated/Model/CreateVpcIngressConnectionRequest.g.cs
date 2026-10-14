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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcIngressConnection operation. Create an
    /// App Runner VPC Ingress Connection resource. App Runner requires this resource when
    /// you want to associate your App Runner service with an Amazon VPC endpoint.
    /// </summary>
    public partial class CreateVpcIngressConnectionRequest : AmazonAppRunnerRequest
    {
        /// <summary>
        /// Gets and sets the property IngressVpcConfiguration. 
        /// <para>
        /// Specifications for the customer’s Amazon VPC and the related Amazon Web Services PrivateLink
        /// VPC endpoint that are used to create the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngressVpcConfiguration IngressVpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressVpcConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressVpcConfiguration() => this.IngressVpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this App Runner service that is used to create
        /// the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the VPC Ingress Connection
        /// resource. A tag is a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionName. 
        /// <para>
        /// A name for the VPC Ingress Connection resource. It must be unique across all the active
        /// VPC Ingress Connections in your Amazon Web Services account in the Amazon Web Services
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 40)]
        public string VpcIngressConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the VpcIngressConnectionName property is set.
        /// </summary>
        internal bool IsSetVpcIngressConnectionName() => this.VpcIngressConnectionName != null;
    }
}
