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
    /// The registered Amazon Timestream resources that Amazon Web Services IoT FleetWise
    /// edge agent software can transfer your vehicle data to.
    /// </summary>
    public partial class TimestreamResources
    {
        private string _timestreamDatabaseName;
        private string _timestreamTableName;

        /// <summary>
        /// Gets and sets the property TimestreamDatabaseName. 
        /// <para>
        /// The name of the registered Amazon Timestream database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string TimestreamDatabaseName
        {
            get { return this._timestreamDatabaseName; }
            set { this._timestreamDatabaseName = value; }
        }

        // Check to see if TimestreamDatabaseName property is set
        internal bool IsSetTimestreamDatabaseName()
        {
            return this._timestreamDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TimestreamTableName. 
        /// <para>
        /// The name of the registered Amazon Timestream database table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string TimestreamTableName
        {
            get { return this._timestreamTableName; }
            set { this._timestreamTableName = value; }
        }

        // Check to see if TimestreamTableName property is set
        internal bool IsSetTimestreamTableName()
        {
            return this._timestreamTableName != null;
        }

    }
}