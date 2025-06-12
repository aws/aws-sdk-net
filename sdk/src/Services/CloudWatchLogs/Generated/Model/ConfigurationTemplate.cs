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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
        private string _allowedActionForAllowVendedLogsDeliveryForResource;
        private List<string> _allowedFieldDelimiters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<RecordField> _allowedFields = AWSConfigs.InitializeCollections ? new List<RecordField>() : null;
        private List<string> _allowedOutputFormats = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedSuffixPathFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ConfigurationTemplateDeliveryConfigValues _defaultDeliveryConfigValues;
        private DeliveryDestinationType _deliveryDestinationType;
        private string _logType;
        private string _resourceType;
        private string _service;

        /// <summary>
        /// Gets and sets the property AllowedActionForAllowVendedLogsDeliveryForResource. 
        /// <para>
        /// The action permissions that a caller needs to have to be able to successfully create
        /// a delivery source on the desired resource type when calling <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        /// </summary>
        public string AllowedActionForAllowVendedLogsDeliveryForResource
        {
            get { return this._allowedActionForAllowVendedLogsDeliveryForResource; }
            set { this._allowedActionForAllowVendedLogsDeliveryForResource = value; }
        }

        // Check to see if AllowedActionForAllowVendedLogsDeliveryForResource property is set
        internal bool IsSetAllowedActionForAllowVendedLogsDeliveryForResource()
        {
            return this._allowedActionForAllowVendedLogsDeliveryForResource != null;
        }

        /// <summary>
        /// Gets and sets the property AllowedFieldDelimiters. 
        /// <para>
        /// The valid values that a caller can use as field delimiters when calling <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>
        /// on a delivery that delivers in <c>Plain</c>, <c>W3C</c>, or <c>Raw</c> format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedFieldDelimiters
        {
            get { return this._allowedFieldDelimiters; }
            set { this._allowedFieldDelimiters = value; }
        }

        // Check to see if AllowedFieldDelimiters property is set
        internal bool IsSetAllowedFieldDelimiters()
        {
            return this._allowedFieldDelimiters != null && (this._allowedFieldDelimiters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedFields. 
        /// <para>
        /// The allowed fields that a caller can use in the <c>recordFields</c> parameter of a
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>
        /// operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordField> AllowedFields
        {
            get { return this._allowedFields; }
            set { this._allowedFields = value; }
        }

        // Check to see if AllowedFields property is set
        internal bool IsSetAllowedFields()
        {
            return this._allowedFields != null && (this._allowedFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedOutputFormats. 
        /// <para>
        /// The list of delivery destination output formats that are supported by this log source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedOutputFormats
        {
            get { return this._allowedOutputFormats; }
            set { this._allowedOutputFormats = value; }
        }

        // Check to see if AllowedOutputFormats property is set
        internal bool IsSetAllowedOutputFormats()
        {
            return this._allowedOutputFormats != null && (this._allowedOutputFormats.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedSuffixPathFields. 
        /// <para>
        /// The list of variable fields that can be used in the suffix path of a delivery that
        /// delivers to an S3 bucket.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public List<string> AllowedSuffixPathFields
        {
            get { return this._allowedSuffixPathFields; }
            set { this._allowedSuffixPathFields = value; }
        }

        // Check to see if AllowedSuffixPathFields property is set
        internal bool IsSetAllowedSuffixPathFields()
        {
            return this._allowedSuffixPathFields != null && (this._allowedSuffixPathFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultDeliveryConfigValues. 
        /// <para>
        /// A mapping that displays the default value of each property within a delivery's configuration,
        /// if it is not specified in the request.
        /// </para>
        /// </summary>
        public ConfigurationTemplateDeliveryConfigValues DefaultDeliveryConfigValues
        {
            get { return this._defaultDeliveryConfigValues; }
            set { this._defaultDeliveryConfigValues = value; }
        }

        // Check to see if DefaultDeliveryConfigValues property is set
        internal bool IsSetDefaultDeliveryConfigValues()
        {
            return this._defaultDeliveryConfigValues != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryDestinationType. 
        /// <para>
        /// A string specifying which destination type this configuration template applies to.
        /// </para>
        /// </summary>
        public DeliveryDestinationType DeliveryDestinationType
        {
            get { return this._deliveryDestinationType; }
            set { this._deliveryDestinationType = value; }
        }

        // Check to see if DeliveryDestinationType property is set
        internal bool IsSetDeliveryDestinationType()
        {
            return this._deliveryDestinationType != null;
        }

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// A string specifying which log type this configuration template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LogType
        {
            get { return this._logType; }
            set { this._logType = value; }
        }

        // Check to see if LogType property is set
        internal bool IsSetLogType()
        {
            return this._logType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// A string specifying which resource type this configuration template applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Service. 
        /// <para>
        /// A string specifying which service this configuration template applies to. For more
        /// information about supported services see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

    }
}