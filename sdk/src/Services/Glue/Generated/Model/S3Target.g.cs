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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a data store in Amazon Simple Storage Service (Amazon S3).
    /// </summary>
    public partial class S3Target
    {
        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The name of a connection which allows a job or crawler to access data in Amazon S3
        /// within an Amazon Virtual Private Cloud environment (Amazon VPC).
        /// </para>
        /// </summary>
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property DlqEventQueueArn. 
        /// <para>
        /// A valid Amazon dead-letter SQS ARN. For example, <c>arn:aws:sqs:region:account:deadLetterQueue</c>.
        /// </para>
        /// </summary>
        public string DlqEventQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the DlqEventQueueArn property is set.
        /// </summary>
        internal bool IsSetDlqEventQueueArn() => this.DlqEventQueueArn != null;

        /// <summary>
        /// Gets and sets the property EventQueueArn. 
        /// <para>
        /// A valid Amazon SQS ARN. For example, <c>arn:aws:sqs:region:account:sqs</c>.
        /// </para>
        /// </summary>
        public string EventQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the EventQueueArn property is set.
        /// </summary>
        internal bool IsSetEventQueueArn() => this.EventQueueArn != null;

        /// <summary>
        /// Gets and sets the property Exclusions. 
        /// <para>
        /// A list of glob patterns used to exclude from the crawl. For more information, see
        /// <a href="https://docs.aws.amazon.com/glue/latest/dg/add-crawler.html">Catalog Tables
        /// with a Crawler</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Exclusions property is set.
        /// </summary>
        internal bool IsSetExclusions() => this.Exclusions != null && (this.Exclusions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the Amazon S3 target.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// Sets the number of files in each leaf folder to be crawled when crawling sample files
        /// in a dataset. If not set, all the files are crawled. A valid value is an integer between
        /// 1 and 249.
        /// </para>
        /// </summary>
        public int? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;
    }
}
