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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// The Amazon Timestream table where the Amazon Web Services IoT FleetWise campaign sends
    /// data. Timestream stores and organizes data to optimize query processing time and to
    /// reduce storage costs. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/data-modeling.html">Data
    /// modeling</a> in the <i>Amazon Timestream Developer Guide</i>.
    /// </summary>
    public partial class TimestreamConfig
    {
        private string _executionRoleArn;
        private string _timestreamTableArn;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role that grants Amazon Web Services
        /// IoT FleetWise permission to deliver data to the Amazon Timestream table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Timestream table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TimestreamTableArn
        {
            get { return this._timestreamTableArn; }
            set { this._timestreamTableArn = value; }
        }

        // Check to see if TimestreamTableArn property is set
        internal bool IsSetTimestreamTableArn()
        {
            return this._timestreamTableArn != null;
        }

    }
}