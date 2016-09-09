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
    /// Container for the parameters to the StopApplication operation.
    /// Stops the application from processing input data. You can stop an application only
    /// if it is in the running state. You can use the <a>DescribeApplication</a> operation
    /// to find the application state. After the application is stopped, Amazon Kinesis Analytics
    /// stops reading data from the input, the application stops processing data, and there
    /// is no output written to the destination. 
    /// 
    ///  
    /// <para>
    /// This operation requires permissions to perform the <code>kinesisanalytics:StopApplication</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class StopApplicationRequest : AmazonKinesisAnalyticsRequest
    {
        private string _applicationName;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// Name of the running application to stop.
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