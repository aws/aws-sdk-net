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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the GetWhatsAppMessageMedia operation. Get a media
    /// file from the WhatsApp service. On successful completion the media file is retrieved
    /// from Meta and stored in the specified Amazon S3 bucket. Use either <c>destinationS3File</c>
    /// or <c>destinationS3PresignedUrl</c> for the destination. If both are used then an
    /// <c>InvalidParameterException</c> is returned.
    /// </summary>
    public partial class GetWhatsAppMessageMediaRequest : AmazonSocialMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationS3File. 
        /// <para>
        /// The <c>bucketName</c> and <c>key</c> of the S3 media file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public S3File DestinationS3File { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3File property is set.
        /// </summary>
        internal bool IsSetDestinationS3File() => this.DestinationS3File != null;

        /// <summary>
        /// Gets and sets the property DestinationS3PresignedUrl. 
        /// <para>
        /// The presign url of the media file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public S3PresignedUrl DestinationS3PresignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3PresignedUrl property is set.
        /// </summary>
        internal bool IsSetDestinationS3PresignedUrl() => this.DestinationS3PresignedUrl != null;

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The unique identifier for the media file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string MediaId { get; set; }

        /// <summary>
        /// Checks to see if the MediaId property is set.
        /// </summary>
        internal bool IsSetMediaId() => this.MediaId != null;

        /// <summary>
        /// Gets and sets the property MetadataOnly. 
        /// <para>
        /// Set to <c>True</c> to get only the metadata for the file.
        /// </para>
        /// </summary>
        public bool? MetadataOnly { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOnly property is set.
        /// </summary>
        internal bool IsSetMetadataOnly() => this.MetadataOnly.HasValue;

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the originating phone number for the WhatsApp message media.
        /// The phone number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_GetLinkedWhatsAppBusinessAccount.html">GetLinkedWhatsAppBusinessAccount</a>
        /// to find a phone number's id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string OriginationPhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the OriginationPhoneNumberId property is set.
        /// </summary>
        internal bool IsSetOriginationPhoneNumberId() => this.OriginationPhoneNumberId != null;
    }
}
