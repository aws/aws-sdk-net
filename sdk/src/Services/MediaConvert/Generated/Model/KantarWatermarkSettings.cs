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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
        private string _channelName;
        private string _contentReference;
        private string _credentialsSecretName;
        private double? _fileOffset;
        private int? _kantarLicenseId;
        private string _kantarServerUrl;
        private string _logDestination;
        private string _metadata3;
        private string _metadata4;
        private string _metadata5;
        private string _metadata6;
        private string _metadata7;
        private string _metadata8;

        /// <summary>
        /// Gets and sets the property ChannelName. Provide an audio channel name from your Kantar
        /// audio license.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ContentReference. Specify a unique identifier for Kantar
        /// to use for this piece of content.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ContentReference
        {
            get { return this._contentReference; }
            set { this._contentReference = value; }
        }

        // Check to see if ContentReference property is set
        internal bool IsSetContentReference()
        {
            return this._contentReference != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretName. Provide the name of the AWS Secrets
        /// Manager secret where your Kantar credentials are stored. Note that your MediaConvert
        /// service role must provide access to this secret. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/granting-permissions-for-mediaconvert-to-access-secrets-manager-secret.html.
        /// For instructions on creating a secret, see https://docs.aws.amazon.com/secretsmanager/latest/userguide/tutorials_basic.html,
        /// in the AWS Secrets Manager User Guide.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CredentialsSecretName
        {
            get { return this._credentialsSecretName; }
            set { this._credentialsSecretName = value; }
        }

        // Check to see if CredentialsSecretName property is set
        internal bool IsSetCredentialsSecretName()
        {
            return this._credentialsSecretName != null;
        }

        /// <summary>
        /// Gets and sets the property FileOffset. Optional. Specify an offset, in whole seconds,
        /// from the start of your output and the beginning of the watermarking. When you don't
        /// specify an offset, Kantar defaults to zero.
        /// </summary>
        public double? FileOffset
        {
            get { return this._fileOffset; }
            set { this._fileOffset = value; }
        }

        // Check to see if FileOffset property is set
        internal bool IsSetFileOffset()
        {
            return this._fileOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KantarLicenseId. Provide your Kantar license ID number.
        /// You should get this number from Kantar.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? KantarLicenseId
        {
            get { return this._kantarLicenseId; }
            set { this._kantarLicenseId = value; }
        }

        // Check to see if KantarLicenseId property is set
        internal bool IsSetKantarLicenseId()
        {
            return this._kantarLicenseId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KantarServerUrl. Provide the HTTPS endpoint to the Kantar
        /// server. You should get this endpoint from Kantar.
        /// </summary>
        public string KantarServerUrl
        {
            get { return this._kantarServerUrl; }
            set { this._kantarServerUrl = value; }
        }

        // Check to see if KantarServerUrl property is set
        internal bool IsSetKantarServerUrl()
        {
            return this._kantarServerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LogDestination. Optional. Specify the Amazon S3 bucket
        /// where you want MediaConvert to store your Kantar watermark XML logs. When you don't
        /// specify a bucket, MediaConvert doesn't save these logs. Note that your MediaConvert
        /// service role must provide access to this location. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/iam-role.html
        /// </summary>
        public string LogDestination
        {
            get { return this._logDestination; }
            set { this._logDestination = value; }
        }

        // Check to see if LogDestination property is set
        internal bool IsSetLogDestination()
        {
            return this._logDestination != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata3. You can optionally use this field to specify
        /// the first timestamp that Kantar embeds during watermarking. Kantar suggests that you
        /// be very cautious when using this Kantar feature, and that you use it only on channels
        /// that are managed specifically for use with this feature by your Audience Measurement
        /// Operator. For more information about this feature, contact Kantar technical support.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata3
        {
            get { return this._metadata3; }
            set { this._metadata3 = value; }
        }

        // Check to see if Metadata3 property is set
        internal bool IsSetMetadata3()
        {
            return this._metadata3 != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata4. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata4
        {
            get { return this._metadata4; }
            set { this._metadata4 = value; }
        }

        // Check to see if Metadata4 property is set
        internal bool IsSetMetadata4()
        {
            return this._metadata4 != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata5. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata5
        {
            get { return this._metadata5; }
            set { this._metadata5 = value; }
        }

        // Check to see if Metadata5 property is set
        internal bool IsSetMetadata5()
        {
            return this._metadata5 != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata6. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata6
        {
            get { return this._metadata6; }
            set { this._metadata6 = value; }
        }

        // Check to see if Metadata6 property is set
        internal bool IsSetMetadata6()
        {
            return this._metadata6 != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata7. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata7
        {
            get { return this._metadata7; }
            set { this._metadata7 = value; }
        }

        // Check to see if Metadata7 property is set
        internal bool IsSetMetadata7()
        {
            return this._metadata7 != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata8. Additional metadata that MediaConvert sends
        /// to Kantar. Maximum length is 50 characters.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Metadata8
        {
            get { return this._metadata8; }
            set { this._metadata8 = value; }
        }

        // Check to see if Metadata8 property is set
        internal bool IsSetMetadata8()
        {
            return this._metadata8 != null;
        }

    }
}