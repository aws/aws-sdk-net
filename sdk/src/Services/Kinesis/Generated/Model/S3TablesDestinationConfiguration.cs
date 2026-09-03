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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// The configuration for delivery to streaming tables on Apache Iceberg. Used in <a>CreateChannel</a>.
    /// </summary>
    public partial class S3TablesDestinationConfiguration
    {
        private int? _dataFreshnessInSeconds;
        private DeadLetterQueueS3Configuration _deadLetterQueueS3Configuration;
        private List<S3TablesConfiguration> _s3TablesConfigurationList = AWSConfigs.InitializeCollections ? new List<S3TablesConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property DataFreshnessInSeconds. 
        /// <para>
        /// The maximum age, in seconds, of undelivered data. Valid range is 300 to 900 seconds
        /// (5 to 15 minutes). The default value is 300 seconds.
        /// </para>
        /// </summary>
        public int? DataFreshnessInSeconds
        {
            get { return this._dataFreshnessInSeconds; }
            set { this._dataFreshnessInSeconds = value; }
        }

        // Check to see if DataFreshnessInSeconds property is set
        internal bool IsSetDataFreshnessInSeconds()
        {
            return this._dataFreshnessInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeadLetterQueueS3Configuration. 
        /// <para>
        /// The dead-letter queue configuration for records that cannot be delivered. Required
        /// for streaming table destinations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeadLetterQueueS3Configuration DeadLetterQueueS3Configuration
        {
            get { return this._deadLetterQueueS3Configuration; }
            set { this._deadLetterQueueS3Configuration = value; }
        }

        // Check to see if DeadLetterQueueS3Configuration property is set
        internal bool IsSetDeadLetterQueueS3Configuration()
        {
            return this._deadLetterQueueS3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property S3TablesConfigurationList. 
        /// <para>
        /// The list of streaming table configurations. Currently, one table is supported per
        /// channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public List<S3TablesConfiguration> S3TablesConfigurationList
        {
            get { return this._s3TablesConfigurationList; }
            set { this._s3TablesConfigurationList = value; }
        }

        // Check to see if S3TablesConfigurationList property is set
        internal bool IsSetS3TablesConfigurationList()
        {
            return this._s3TablesConfigurationList != null && (this._s3TablesConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}