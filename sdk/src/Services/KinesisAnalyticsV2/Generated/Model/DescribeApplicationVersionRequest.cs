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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
    /// Container for the parameters to the DescribeApplicationVersion operation.
    /// Provides a detailed description of a specified version of the application. To see
    /// a list of all the versions of an application, invoke the <a>ListApplicationVersions</a>
    /// operation.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is supported only for Managed Service for Apache Flink.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeApplicationVersionRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private long? _applicationVersionId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application for which you want to get the version description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property ApplicationVersionId. 
        /// <para>
        /// The ID of the application version for which you want to get the description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? ApplicationVersionId
        {
            get { return this._applicationVersionId; }
            set { this._applicationVersionId = value; }
        }

        // Check to see if ApplicationVersionId property is set
        internal bool IsSetApplicationVersionId()
        {
            return this._applicationVersionId.HasValue; 
        }

    }
}