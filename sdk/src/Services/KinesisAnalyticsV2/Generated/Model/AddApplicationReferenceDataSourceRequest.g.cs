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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationReferenceDataSource operation. Adds
    /// a reference data source to an existing SQL-based Kinesis Data Analytics application.
    /// <para> Kinesis Data Analytics reads reference data (that is, an Amazon S3 object)
    /// and creates an in-application table within your application. In the request, you provide
    /// the source (S3 bucket name and object key name), name of the in-application table
    /// to create, and the necessary mapping information that describes how data in an Amazon
    /// S3 object maps to columns in the resulting in-application table. </para>
    /// </summary>
    public partial class AddApplicationReferenceDataSourceRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an existing application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The version of the application for which you are adding the reference data source.
        /// You can use the <a>DescribeApplication</a> operation to get the current application
        /// version. If the version specified is not the current version, the <c>ConcurrentModificationException</c>
        /// is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 999999999)]
        public long? CurrentApplicationVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentApplicationVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentApplicationVersionId() => this.CurrentApplicationVersionId.HasValue;

        /// <summary>
        /// Gets and sets the property ReferenceDataSource. 
        /// <para>
        /// The reference data source can be an object in your Amazon S3 bucket. Kinesis Data
        /// Analytics reads the object and copies the data into the in-application table that
        /// is created. You provide an S3 bucket, object key name, and the resulting in-application
        /// table that is created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReferenceDataSource ReferenceDataSource { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceDataSource property is set.
        /// </summary>
        internal bool IsSetReferenceDataSource() => this.ReferenceDataSource != null;
    }
}
