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
    /// Container for the parameters to the DeleteApplication operation.
    /// Deletes the specified application. Amazon Kinesis Analytics halts application execution
    /// and deletes the application, including any application artifacts (such as in-application
    /// streams, reference table, and application code).
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics:DeleteApplication</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;
        private DateTime? _createTimestamp;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the Amazon Kinesis Analytics application to delete.
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
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        ///  You can use the <code>DescribeApplication</code> operation to get this value. 
        /// </para>
        /// </summary>
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

    }
}