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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Configuration for receiving events from an external provider, such as a SaaS application,
    /// that sends them as HTTPS POST requests to a webhook URL. The provider authenticates
    /// with an HTTP scheme instead of AWS credentials.
    /// </summary>
    public partial class WebhookEventsSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property AuthConfiguration. 
        /// <para>
        /// How the provider authenticates its requests. Exactly one authentication type must
        /// be set, and it can't be changed after the EventSource is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WebhookAuthConfiguration AuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthConfiguration() => this.AuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeduplicationConfiguration. 
        /// <para>
        /// Optional. Deduplicates this EventSource's events on the event bus. Omit it to deduplicate
        /// nothing.
        /// </para>
        /// </summary>
        public WebhookDeduplicationConfiguration DeduplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeduplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetDeduplicationConfiguration() => this.DeduplicationConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// Optional. The AWS KMS key that encrypts the EventSource's secret in AWS Secrets Manager.
        /// Omit it to encrypt the secret with the AWS managed key aws/secretsmanager. A key you
        /// supply must be an enabled customer managed key in your account and Region. Changing
        /// it re-encrypts the secret under the new key. The previous key can still decrypt the
        /// stored versions until the credential is next rotated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// Optional. Controls the log records EventBridge delivers for this EventSource's webhook
        /// requests. Omit it to deliver no logs. Logs are delivered to the destinations you configure
        /// with Amazon CloudWatch Logs vended log delivery.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property MetadataHttpHeaders. 
        /// <para>
        /// The HTTP request headers to add to each event's metadata, up to 20. Header names are
        /// case-insensitive and can't repeat. Each header is added under its lowercase name.
        /// Omit the list to add no headers. Headers that carry credentials or that describe the
        /// network path, and the header that carries the static token, can't be listed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> MetadataHttpHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetadataHttpHeaders property is set.
        /// </summary>
        internal bool IsSetMetadataHttpHeaders() => this.MetadataHttpHeaders != null && (this.MetadataHttpHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// IAM role the service assumes to put the webhook's events on the event bus. Must belong
        /// to the calling account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
