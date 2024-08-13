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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// A structure that contains the configuration information of a delta time session window.
    /// 
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/iotanalytics/latest/APIReference/API_DeltaTime.html">
    /// <c>DeltaTime</c> </a> specifies a time interval. You can use <c>DeltaTime</c> to create
    /// dataset contents with data that has arrived in the data store since the last execution.
    /// For an example of <c>DeltaTime</c>, see <a href="https://docs.aws.amazon.com/iotanalytics/latest/userguide/automate-create-dataset.html#automate-example6">
    /// Creating a SQL dataset with a delta window (CLI)</a> in the <i>IoT Analytics User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeltaTimeSessionWindowConfiguration
    {
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// A time interval. You can use <c>timeoutInMinutes</c> so that IoT Analytics can batch
        /// up late data notifications that have been generated since the last execution. IoT
        /// Analytics sends one batch of notifications to Amazon CloudWatch Events at one time.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to write a timestamp expression, see <a href="https://prestodb.io/docs/0.172/functions/datetime.html">Date
        /// and Time Functions and Operators</a>, in the <i>Presto 0.172 Documentation</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}