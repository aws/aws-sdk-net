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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A structure containing information about the deafult settings and available settings
    /// that you can use to configure a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Delivery.html">delivery</a>
    /// or a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DeliveryDestination.html">delivery
    /// destination</a>.
    /// </summary>
    public partial class ConfigurationTemplate
    {
        /// <summary>
        /// Gets and sets the property AllowedActionForAllowVendedLogsDeliveryForResource. 
        /// <para>
        /// The action permissions that a caller needs to have to be able to successfully create
        /// a delivery source on the desired resource type when calling <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        /// </summary>
        public string AllowedActionForAllowVendedLogsDeliveryForResource { get; set; }

        /// <summary>
        /// Checks to see if the AllowedActionForAllowVendedLogsDeliveryForResource property is set.
        /// </summary>
        internal bool IsSetAllowedActionForAllowVendedLogsDeliveryForResource() => this.AllowedActionForAllowVendedLogsDeliveryForResource != null;

        /// <summary>
        /// Gets and sets the property AllowedFieldDelimiters. 
        /// <para>
        /// The valid values that a caller can use as field delimiters when calling <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>
        /// on a delivery that delivers in <c>Plain</c>, <c>W3C</c>, or <c>Raw</c> format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedFieldDelimiters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedFieldDelimiters property is set.
        /// </summary>
        internal bool IsSetAllowedFieldDelimiters() => this.AllowedFieldDelimiters != null && (this.AllowedFieldDelimiters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedFields. 
        /// <para>
        /// The allowed fields that a caller can use in the <c>recordFields</c> parameter of a
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordField> AllowedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordField>() : null;

        /// <summary>
        /// Checks to see if the AllowedFields property is set.
        /// </summary>
        internal bool IsSetAllowedFields() => this.AllowedFields != null && (this.AllowedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedOutputFormats. 
        /// <para>
        /// The list of delivery destination output formats that are supported by this log source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedOutputFormats { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedOutputFormats property is set.
        /// </summary>
        internal bool IsSetAllowedOutputFormats() => this.AllowedOutputFormats != null && (this.AllowedOutputFormats.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllowedSuffixPathFields. 
        /// <para>
        /// The list of variable fields that can be used in the suffix path of a delivery that
        /// delivers to an S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public List<string> AllowedSuffixPathFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedSuffixPathFields property is set.
        /// </summary>
        internal bool IsSetAllowedSuffixPathFields() => this.AllowedSuffixPathFields != null && (this.AllowedSuffixPathFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultDeliveryConfigValues. 
        /// <para>
        /// A mapping that displays the default value of each property within a delivery's configuration,
        /// if it is not specified in the request.
        /// </para>
        /// </summary>
        public ConfigurationTemplateDeliveryConfigValues DefaultDeliveryConfigValues { get; set; }

        /// <summary>
        /// Checks to see if the DefaultDeliveryConfigValues property is set.
        /// </summary>
        internal bool IsSetDefaultDeliveryConfigValues() => this.DefaultDeliveryConfigValues != null;

        /// <summary>
        /// Gets and sets the property DeliveryDestinationType. 
        /// <para>
        /// A string specifying which destination type this configuration template applies to.
        /// </para>
        /// </summary>
        public DeliveryDestinationType DeliveryDestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryDestinationType property is set.
        /// </summary>
        internal bool IsSetDeliveryDestinationType() => this.DeliveryDestinationType != null;

        /// <summary>
        /// Gets and sets the property DeliverySourceConfiguration. 
        /// <para>
        /// The schema of the delivery source configuration that is available for this log type.
        /// Each element describes a configuration that can be set when calling <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>,
        /// including the configuration name, type, and default value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeliverySourceConfigurationSchema> DeliverySourceConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<DeliverySourceConfigurationSchema>() : null;

        /// <summary>
        /// Checks to see if the DeliverySourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDeliverySourceConfiguration() => this.DeliverySourceConfiguration != null && (this.DeliverySourceConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// A string specifying which log type this configuration template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LogType { get; set; }

        /// <summary>
        /// Checks to see if the LogType property is set.
        /// </summary>
        internal bool IsSetLogType() => this.LogType != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// A string specifying which resource type this configuration template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property S3TablesIntegration. 
        /// <para>
        /// The S3 Tables integration configuration for this configuration template, including
        /// the datasource name and type.
        /// </para>
        /// </summary>
        public S3TablesIntegration S3TablesIntegration { get; set; }

        /// <summary>
        /// Checks to see if the S3TablesIntegration property is set.
        /// </summary>
        internal bool IsSetS3TablesIntegration() => this.S3TablesIntegration != null;

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// A string specifying which service this configuration template applies to. For more
        /// information about supported services see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;
    }
}
