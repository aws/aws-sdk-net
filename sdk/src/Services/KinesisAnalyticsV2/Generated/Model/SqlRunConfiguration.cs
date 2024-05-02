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
    /// Describes the starting parameters for a SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class SqlRunConfiguration
    {
        private string _inputId;
        private InputStartingPositionConfiguration _inputStartingPositionConfiguration;

        /// <summary>
        /// Gets and sets the property InputId. 
        /// <para>
        /// The input source ID. You can get this ID by calling the <a>DescribeApplication</a>
        /// operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        // Check to see if InputId property is set
        internal bool IsSetInputId()
        {
            return this._inputId != null;
        }

        /// <summary>
        /// Gets and sets the property InputStartingPositionConfiguration. 
        /// <para>
        /// The point at which you want the application to start processing records from the streaming
        /// source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputStartingPositionConfiguration InputStartingPositionConfiguration
        {
            get { return this._inputStartingPositionConfiguration; }
            set { this._inputStartingPositionConfiguration = value; }
        }

        // Check to see if InputStartingPositionConfiguration property is set
        internal bool IsSetInputStartingPositionConfiguration()
        {
            return this._inputStartingPositionConfiguration != null;
        }

    }
}