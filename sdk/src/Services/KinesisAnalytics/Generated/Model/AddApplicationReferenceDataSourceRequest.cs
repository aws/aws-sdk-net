/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Container for the parameters to the AddApplicationReferenceDataSource operation.
    /// Adds a reference data source to an existing application.
    /// 
    ///  
    /// <para>
    /// Amazon Kinesis Analytics reads reference data (that is, an Amazon S3 object) and creates
    /// an in-application table within your application. In the request, you provide the source
    /// (S3 bucket name and object key name), name of the in-application table to create,
    /// and the necessary mapping information that describes how data in Amazon S3 object
    /// maps to columns in the resulting in-application table.
    /// </para>
    ///  
    /// <para>
    ///  For conceptual information, see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/how-it-works-input.html">Configuring
    /// Application Input</a>. For the limits on data sources you can add to your application,
    /// see <a href="http://docs.aws.amazon.com/kinesisanalytics/latest/dev/limits.html">Limits</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permissions to perform the <code>kinesisanalytics:AddApplicationOutput</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class AddApplicationReferenceDataSourceRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private ReferenceDataSource _referenceDataSource;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of an existing application.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// Version of the application for which you are adding the reference data source. You
        /// can use the <a>DescribeApplication</a> operation to get the current application version.
        /// If the version specified is not the current version, the <code>ConcurrentModificationException</code>
        /// is returned.
        /// </para>
        /// </summary>
        public long CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId.GetValueOrDefault(); }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceDataSource. 
        /// <para>
        /// The reference data source can be an object in your Amazon S3 bucket. Amazon Kinesis
        /// Analytics reads the object and copies the data into the in-application table that
        /// is created. You provide an S3 bucket, object key name, and the resulting in-application
        /// table that is created. You must also provide an IAM role with the necessary permissions
        /// that Amazon Kinesis Analytics can assume to read the object from your S3 bucket on
        /// your behalf.
        /// </para>
        /// </summary>
        public ReferenceDataSource ReferenceDataSource
        {
            get { return this._referenceDataSource; }
            set { this._referenceDataSource = value; }
        }

        // Check to see if ReferenceDataSource property is set
        internal bool IsSetReferenceDataSource()
        {
            return this._referenceDataSource != null;
        }

    }
}