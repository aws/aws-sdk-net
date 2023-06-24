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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the destination for a delivery stream.
    /// </summary>
    public partial class DestinationDescription
    {
        private AmazonOpenSearchServerlessDestinationDescription _amazonOpenSearchServerlessDestinationDescription;
        private AmazonopensearchserviceDestinationDescription _amazonopensearchserviceDestinationDescription;
        private string _destinationId;
        private ElasticsearchDestinationDescription _elasticsearchDestinationDescription;
        private ExtendedS3DestinationDescription _extendedS3DestinationDescription;
        private HttpEndpointDestinationDescription _httpEndpointDestinationDescription;
        private RedshiftDestinationDescription _redshiftDestinationDescription;
        private S3DestinationDescription _s3DestinationDescription;
        private SplunkDestinationDescription _splunkDestinationDescription;

        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationDescription. 
        /// <para>
        /// The destination in the Serverless offering for Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationDescription AmazonOpenSearchServerlessDestinationDescription
        {
            get { return this._amazonOpenSearchServerlessDestinationDescription; }
            set { this._amazonOpenSearchServerlessDestinationDescription = value; }
        }

        // Check to see if AmazonOpenSearchServerlessDestinationDescription property is set
        internal bool IsSetAmazonOpenSearchServerlessDestinationDescription()
        {
            return this._amazonOpenSearchServerlessDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationDescription. 
        /// <para>
        /// The destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationDescription AmazonopensearchserviceDestinationDescription
        {
            get { return this._amazonopensearchserviceDestinationDescription; }
            set { this._amazonopensearchserviceDestinationDescription = value; }
        }

        // Check to see if AmazonopensearchserviceDestinationDescription property is set
        internal bool IsSetAmazonopensearchserviceDestinationDescription()
        {
            return this._amazonopensearchserviceDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationDescription. 
        /// <para>
        /// The destination in Amazon ES.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationDescription ElasticsearchDestinationDescription
        {
            get { return this._elasticsearchDestinationDescription; }
            set { this._elasticsearchDestinationDescription = value; }
        }

        // Check to see if ElasticsearchDestinationDescription property is set
        internal bool IsSetElasticsearchDestinationDescription()
        {
            return this._elasticsearchDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationDescription. 
        /// <para>
        /// The destination in Amazon S3.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationDescription ExtendedS3DestinationDescription
        {
            get { return this._extendedS3DestinationDescription; }
            set { this._extendedS3DestinationDescription = value; }
        }

        // Check to see if ExtendedS3DestinationDescription property is set
        internal bool IsSetExtendedS3DestinationDescription()
        {
            return this._extendedS3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationDescription. 
        /// <para>
        /// Describes the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationDescription HttpEndpointDestinationDescription
        {
            get { return this._httpEndpointDestinationDescription; }
            set { this._httpEndpointDestinationDescription = value; }
        }

        // Check to see if HttpEndpointDestinationDescription property is set
        internal bool IsSetHttpEndpointDestinationDescription()
        {
            return this._httpEndpointDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationDescription. 
        /// <para>
        /// The destination in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftDestinationDescription RedshiftDestinationDescription
        {
            get { return this._redshiftDestinationDescription; }
            set { this._redshiftDestinationDescription = value; }
        }

        // Check to see if RedshiftDestinationDescription property is set
        internal bool IsSetRedshiftDestinationDescription()
        {
            return this._redshiftDestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// [Deprecated] The destination in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SplunkDestinationDescription. 
        /// <para>
        /// The destination in Splunk.
        /// </para>
        /// </summary>
        public SplunkDestinationDescription SplunkDestinationDescription
        {
            get { return this._splunkDestinationDescription; }
            set { this._splunkDestinationDescription = value; }
        }

        // Check to see if SplunkDestinationDescription property is set
        internal bool IsSetSplunkDestinationDescription()
        {
            return this._splunkDestinationDescription != null;
        }

    }
}