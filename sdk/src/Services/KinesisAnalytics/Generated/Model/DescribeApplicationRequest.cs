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
    /// Container for the parameters to the DescribeApplication operation.
    /// Returns information about a specific Amazon Kinesis Analytics application.
    /// 
    ///  
    /// <para>
    /// If you want to retrieve a list of all applications in your account, use the <a>ListApplications</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics:DescribeApplication</code>
    /// action. You can use <code>DescribeApplication</code> to get the current application
    /// versionId, which you need to call other operations such as <code>Update</code>. 
    /// </para>
    /// </summary>
    public partial class DescribeApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the application.
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

    }
}