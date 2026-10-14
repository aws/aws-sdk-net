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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAndAttachS3AccessPoint operation. Creates
    /// an S3 access point and attaches it to an Amazon FSx volume. For FSx for OpenZFS file
    /// systems, the volume must be hosted on a high-availability file system, either Single-AZ
    /// or Multi-AZ. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/s3accesspoints-for-FSx.html">Accessing
    /// your data using Amazon S3 access points</a>. in the Amazon FSx for OpenZFS User Guide.
    /// <para> The requester requires the following permissions to perform these actions:
    /// </para> <ul> <li> <para> <c>fsx:CreateAndAttachS3AccessPoint</c> </para> </li> <li>
    /// <para> <c>s3:CreateAccessPoint</c> </para> </li> <li> <para> <c>s3:GetAccessPoint</c>
    /// </para> </li> <li> <para> <c>s3:PutAccessPointPolicy</c> </para> </li> <li> <para>
    /// <c>s3:DeleteAccessPoint</c> </para> </li> </ul> <para> The following actions are related
    /// to <c>CreateAndAttachS3AccessPoint</c>: </para> <ul> <li> <para> <a>DescribeS3AccessPointAttachments</a>
    /// </para> </li> <li> <para> <a>DetachAndDeleteS3AccessPoint</a> </para> </li> </ul>
    /// </summary>
    public partial class CreateAndAttachS3AccessPointRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name you want to assign to this S3 access point.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OntapConfiguration.
        /// </summary>
        public CreateAndAttachS3AccessPointOntapConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// Specifies the configuration to use when creating and attaching an S3 access point
        /// to an FSx for OpenZFS volume.
        /// </para>
        /// </summary>
        public CreateAndAttachS3AccessPointOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3AccessPoint. 
        /// <para>
        /// Specifies the virtual private cloud (VPC) configuration if you're creating an access
        /// point that is restricted to a VPC. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/OpenZFSGuide/access-points-vpc.html">Creating
        /// access points restricted to a virtual private cloud</a>.
        /// </para>
        /// </summary>
        public CreateAndAttachS3AccessPointS3Configuration S3AccessPoint { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPoint property is set.
        /// </summary>
        internal bool IsSetS3AccessPoint() => this.S3AccessPoint != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of S3 access point you want to create. Only <c>OpenZFS</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3AccessPointAttachmentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
