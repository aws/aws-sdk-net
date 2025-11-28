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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Contains CloudWatch log configuration metadata and settings.
    /// </summary>
    public partial class MonitoringConfiguration
    {
        private CloudWatchLogConfiguration _cloudWatchLogConfiguration;

        /// <summary>
        /// Gets and sets the property CloudWatchLogConfiguration. 
        /// <para>
        /// CloudWatch log configuration settings and metadata that specify settings like log
        /// files to monitor and where to send them.
        /// </para>
        /// </summary>
        public CloudWatchLogConfiguration CloudWatchLogConfiguration
        {
            get { return this._cloudWatchLogConfiguration; }
            set { this._cloudWatchLogConfiguration = value; }
        }

        // Check to see if CloudWatchLogConfiguration property is set
        internal bool IsSetCloudWatchLogConfiguration()
        {
            return this._cloudWatchLogConfiguration != null;
        }

    }
}