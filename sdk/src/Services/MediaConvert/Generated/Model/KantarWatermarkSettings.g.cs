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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use these settings only when you use Kantar watermarking. Specify the values that
    /// MediaConvert uses to generate and place Kantar watermarks in your output audio. These
    /// settings apply to every output in your job. In addition to specifying these values,
    /// you also need to store your Kantar credentials in AWS Secrets Manager. For more information,
    /// see https://docs.aws.amazon.com/mediaconvert/latest/ug/kantar-watermarking.html.
    /// </summary>
    public partial class KantarWatermarkSettings
    {
        /// <summary>
        /// Gets and sets the property ChannelName. Provide an audio channel name from your Kantar
        /// audio license.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ContentReference. Specify a unique identifier for Kantar
        /// to use for this piece of content.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ContentReference { get; set; }

        /// <summary>
        /// Checks to see if the ContentReference property is set.
        /// </summary>
        internal bool IsSetContentReference() => this.ContentReference != null;

        /// <summary>
        /// Gets and sets the property CredentialsSecretName. Provide the name of the AWS Secrets
        /// Manager secret where your Kantar credentials are stored. Note that your MediaConvert
        /// service role must provide access to this secret. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/granting-permissions-for-mediaconvert-to-access-secrets-manager-secret.html.
        /// For instructions on creating a secret, see https://docs.aws.amazon.com/secretsmanager/latest/userguide/tutorials_basic.html,
        /// in the AWS Secrets Manager User Guide.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string CredentialsSecretName { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsSecretName property is set.
        /// </summary>
        internal bool IsSetCredentialsSecretName() => this.CredentialsSecretName != null;

        /// <summary>
        /// Gets and sets the property FileOffset. Optional. Specify an offset, in whole seconds,
        /// from the start of your output and the beginning of the watermarking. When you don't
        /// specify an offset, Kantar defaults to zero.
        /// </summary>
        public double? FileOffset { get; set; }

        /// <summary>
        /// Checks to see if the FileOffset property is set.
        /// </summary>
        internal bool IsSetFileOffset() => this.FileOffset.HasValue;

        /// <summary>
        /// Gets and sets the property KantarLicenseId. Provide your Kantar license ID number.
        /// You should get this number from Kantar.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? KantarLicenseId { get; set; }

        /// <summary>
        /// Checks to see if the KantarLicenseId property is set.
        /// </summary>
        internal bool IsSetKantarLicenseId() => this.KantarLicenseId.HasValue;

        /// <summary>
        /// Gets and sets the property KantarServerUrl. Provide the HTTPS endpoint to the Kantar
        /// server. You should get this endpoint from Kantar.
        /// </summary>
        public string KantarServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the KantarServerUrl property is set.
        /// </summary>
        internal bool IsSetKantarServerUrl() => this.KantarServerUrl != null;

        /// <summary>
        /// Gets and sets the property LogDestination. Optional. Specify the Amazon S3 bucket
        /// where you want MediaConvert to store your Kantar watermark XML logs. When you don't
        /// specify a bucket, MediaConvert doesn't save these logs. Note that your MediaConvert
        /// service role must provide access to this location. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html
        /// </summary>
        public string LogDestination { get; set; }

        /// <summary>
        /// Checks to see if the LogDestination property is set.
        /// </summary>
        internal bool IsSetLogDestination() => this.LogDestination != null;

        /// <summary>
        /// Gets and sets the property Metadata3. You can optionally use this field to specify
        /// the first timestamp that Kantar embeds during watermarking. Kantar suggests that you
        /// be very cautious when using this Kantar feature, and that you use it only on channels
        /// that are managed specifically for use with this feature by your Audience Measurement
        /// Operator. For more information about this feature, contact Kantar technical support.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata3 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata3 property is set.
        /// </summary>
        internal bool IsSetMetadata3() => this.Metadata3 != null;

        /// <summary>
        /// Gets and sets the property Metadata4. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata4 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata4 property is set.
        /// </summary>
        internal bool IsSetMetadata4() => this.Metadata4 != null;

        /// <summary>
        /// Gets and sets the property Metadata5. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata5 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata5 property is set.
        /// </summary>
        internal bool IsSetMetadata5() => this.Metadata5 != null;

        /// <summary>
        /// Gets and sets the property Metadata6. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata6 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata6 property is set.
        /// </summary>
        internal bool IsSetMetadata6() => this.Metadata6 != null;

        /// <summary>
        /// Gets and sets the property Metadata7. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata7 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata7 property is set.
        /// </summary>
        internal bool IsSetMetadata7() => this.Metadata7 != null;

        /// <summary>
        /// Gets and sets the property Metadata8. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Metadata8 { get; set; }

        /// <summary>
        /// Checks to see if the Metadata8 property is set.
        /// </summary>
        internal bool IsSetMetadata8() => this.Metadata8 != null;
    }
}
