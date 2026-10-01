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

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetComponentVersionArtifact operation. Gets the
    /// pre-signed URL to download a public or a Lambda component artifact. Core devices call
    /// this operation to identify the URL that they can use to download an artifact to install.
    /// </summary>
    public partial class GetComponentVersionArtifactRequest : AmazonGreengrassV2Request
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the component version. Specify the ARN of a public or a Lambda component version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ArtifactName. 
        /// <para>
        /// The name of the artifact.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a href="https://docs.aws.amazon.com/greengrass/v2/APIReference/API_GetComponent.html">GetComponent</a>
        /// operation to download the component recipe, which includes the URI of the artifact.
        /// The artifact name is the section of the URI after the scheme. For example, in the
        /// artifact URI <c>greengrass:SomeArtifact.zip</c>, the artifact name is <c>SomeArtifact.zip</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ArtifactName { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactName property is set.
        /// </summary>
        internal bool IsSetArtifactName() => this.ArtifactName != null;

        /// <summary>
        /// Gets and sets the property IotEndpointType. 
        /// <para>
        /// Determines if the Amazon S3 URL returned is a FIPS pre-signed URL endpoint. Specify
        /// <c>fips</c> if you want the returned Amazon S3 pre-signed URL to point to an Amazon
        /// S3 FIPS endpoint. If you don't specify a value, the default is <c>standard</c>.
        /// </para>
        /// </summary>
        public IotEndpointType IotEndpointType { get; set; }

        /// <summary>
        /// Checks to see if the IotEndpointType property is set.
        /// </summary>
        internal bool IsSetIotEndpointType() => this.IotEndpointType != null;

        /// <summary>
        /// Gets and sets the property S3EndpointType. 
        /// <para>
        /// Specifies the endpoint to use when getting Amazon S3 pre-signed URLs.
        /// </para>
        ///  
        /// <para>
        /// All Amazon Web Services Regions except US East (N. Virginia) use <c>REGIONAL</c> in
        /// all cases. In the US East (N. Virginia) Region the default is <c>GLOBAL</c>, but you
        /// can change it to <c>REGIONAL</c> with this parameter.
        /// </para>
        /// </summary>
        public S3EndpointType S3EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the S3EndpointType property is set.
        /// </summary>
        internal bool IsSetS3EndpointType() => this.S3EndpointType != null;
    }
}
