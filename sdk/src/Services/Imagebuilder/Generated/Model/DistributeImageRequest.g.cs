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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the DistributeImage operation. Distributes an existing
    /// AMI to target Regions and accounts without running the full image build process. This
    /// operation only runs the distribution phase on an image that has already been built.
    /// </summary>
    public partial class DistributeImageRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure that the operation runs
        /// no more than one time. If you retry a request with the same client token, Image Builder
        /// returns the original response without running the operation again. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DistributionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the distribution configuration. The configuration
        /// defines target Regions, accounts, and AMI settings. The distribution configuration
        /// must be in the same Region as this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DistributionConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the DistributionConfigurationArn property is set.
        /// </summary>
        internal bool IsSetDistributionConfigurationArn() => this.DistributionConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role that Image Builder assumes
        /// to distribute the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration for the distribution.
        /// </para>
        /// </summary>
        public ImageLoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceImage. 
        /// <para>
        /// The source image to distribute. You can specify the source in any of the following
        /// formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An AMI ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Web Services Systems Manager Parameter Store reference, prefixed by <c>ssm:</c>,
        /// followed by the parameter name or ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Image Builder image Amazon Resource Name (ARN). An image version ARN resolves to
        /// the latest available build version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Whichever format you use, the source must resolve to an AMI in the current Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string SourceImage { get; set; }

        /// <summary>
        /// Checks to see if the SourceImage property is set.
        /// </summary>
        internal bool IsSetSourceImage() => this.SourceImage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the new Image Builder image resource that this operation creates.
        /// To tag the output AMIs, use <c>amiTags</c> in the distribution configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
