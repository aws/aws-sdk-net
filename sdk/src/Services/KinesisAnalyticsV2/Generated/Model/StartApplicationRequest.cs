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
    /// Container for the parameters to the StartApplication operation.
    /// Starts the specified Managed Service for Apache Flink application. After creating
    /// an application, you must exclusively call this operation to start your application.
    /// </summary>
    public partial class StartApplicationRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private RunConfiguration _runConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application.
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
        /// Gets and sets the property RunConfiguration. 
        /// <para>
        /// Identifies the run configuration (start parameters) of a Managed Service for Apache
        /// Flink application.
        /// </para>
        /// </summary>
        public RunConfiguration RunConfiguration
        {
            get { return this._runConfiguration; }
            set { this._runConfiguration = value; }
        }

        // Check to see if RunConfiguration property is set
        internal bool IsSetRunConfiguration()
        {
            return this._runConfiguration != null;
        }

    }
}