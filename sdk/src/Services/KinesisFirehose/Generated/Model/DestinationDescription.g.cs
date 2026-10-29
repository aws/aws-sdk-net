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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the destination for a Firehose stream.
    /// </summary>
    public partial class DestinationDescription
    {
        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationDescription. 
        /// <para>
        /// The destination in the Serverless offering for Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationDescription AmazonOpenSearchServerlessDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the AmazonOpenSearchServerlessDestinationDescription property is set.
        /// </summary>
        internal bool IsSetAmazonOpenSearchServerlessDestinationDescription() => this.AmazonOpenSearchServerlessDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationDescription. 
        /// <para>
        /// The destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationDescription AmazonopensearchserviceDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the AmazonopensearchserviceDestinationDescription property is set.
        /// </summary>
        internal bool IsSetAmazonopensearchserviceDestinationDescription() => this.AmazonopensearchserviceDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationId property is set.
        /// </summary>
        internal bool IsSetDestinationId() => this.DestinationId != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationDescription. 
        /// <para>
        /// The destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationDescription ElasticsearchDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchDestinationDescription property is set.
        /// </summary>
        internal bool IsSetElasticsearchDestinationDescription() => this.ElasticsearchDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationDescription. 
        /// <para>
        /// The destination in Amazon S3.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationDescription ExtendedS3DestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedS3DestinationDescription property is set.
        /// </summary>
        internal bool IsSetExtendedS3DestinationDescription() => this.ExtendedS3DestinationDescription != null;

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationDescription. 
        /// <para>
        /// Describes the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationDescription HttpEndpointDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpointDestinationDescription property is set.
        /// </summary>
        internal bool IsSetHttpEndpointDestinationDescription() => this.HttpEndpointDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property IcebergDestinationDescription. 
        /// <para>
        ///  Describes a destination in Apache Iceberg Tables. 
        /// </para>
        /// </summary>
        public IcebergDestinationDescription IcebergDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the IcebergDestinationDescription property is set.
        /// </summary>
        internal bool IsSetIcebergDestinationDescription() => this.IcebergDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property RedshiftDestinationDescription. 
        /// <para>
        /// The destination in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftDestinationDescription RedshiftDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDestinationDescription property is set.
        /// </summary>
        internal bool IsSetRedshiftDestinationDescription() => this.RedshiftDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// [Deprecated] The destination in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationDescription property is set.
        /// </summary>
        internal bool IsSetS3DestinationDescription() => this.S3DestinationDescription != null;

        /// <summary>
        /// Gets and sets the property SnowflakeDestinationDescription. 
        /// <para>
        /// Optional description for the destination
        /// </para>
        /// </summary>
        public SnowflakeDestinationDescription SnowflakeDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeDestinationDescription property is set.
        /// </summary>
        internal bool IsSetSnowflakeDestinationDescription() => this.SnowflakeDestinationDescription != null;

        /// <summary>
        /// Gets and sets the property SplunkDestinationDescription. 
        /// <para>
        /// The destination in Splunk.
        /// </para>
        /// </summary>
        public SplunkDestinationDescription SplunkDestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the SplunkDestinationDescription property is set.
        /// </summary>
        internal bool IsSetSplunkDestinationDescription() => this.SplunkDestinationDescription != null;
    }
}
