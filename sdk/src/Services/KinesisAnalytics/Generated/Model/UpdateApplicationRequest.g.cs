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

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation. <note> <para> This
    /// documentation is for version 1 of the Amazon Kinesis Data Analytics API, which only
    /// supports SQL applications. Version 2 of the API supports SQL and Java applications.
    /// For more information about version 2, see <a href="/kinesisanalytics/latest/apiv2/Welcome.html">Amazon
    /// Kinesis Data Analytics API V2 Documentation</a>. </para> </note> <para> Updates an
    /// existing Amazon Kinesis Analytics application. Using this API, you can update application
    /// code, input configuration, and output configuration. </para> <para> Note that Amazon
    /// Kinesis Analytics updates the <c>CurrentApplicationVersionId</c> each time you update
    /// your application. </para> <para> This operation requires permission for the <c>kinesisanalytics:UpdateApplication</c>
    /// action. </para>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the Amazon Kinesis Analytics application to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ApplicationUpdate. 
        /// <para>
        /// Describes application updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationUpdate ApplicationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationUpdate property is set.
        /// </summary>
        internal bool IsSetApplicationUpdate() => this.ApplicationUpdate != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The current application version ID. You can use the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_DescribeApplication.html">DescribeApplication</a>
        /// operation to get this value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? CurrentApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersionId() => this.CurrentApplicationVersionId.HasValue;
    }
}
