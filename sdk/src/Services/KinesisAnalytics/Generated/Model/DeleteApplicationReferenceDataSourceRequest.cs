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
    /// Container for the parameters to the DeleteApplicationReferenceDataSource operation.
    /// Deletes a reference data source configuration from the specified application configuration.
    /// 
    ///  
    /// <para>
    /// If the application is running, Amazon Kinesis Analytics immediately removes the in-application
    /// table that you created using the <a>AddApplicationReferenceDataSource</a> operation.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics.DeleteApplicationReferenceDataSource</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteApplicationReferenceDataSourceRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private string _referenceId;

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
        /// Version of the application. You can use the <a>DescribeApplication</a> operation to
        /// get the current application version. If the version specified is not the current version,
        /// the <code>ConcurrentModificationException</code> is returned.
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
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// ID of the reference data source. When you add a reference data source to your application
        /// using the <a>AddApplicationReferenceDataSource</a>, Amazon Kinesis Analytics assigns
        /// an ID. You can use the <a>DescribeApplication</a> operation to get the reference ID.
        /// 
        /// </para>
        /// </summary>
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

    }
}