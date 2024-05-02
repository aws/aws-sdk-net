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
    /// When dataset contents are created, they are delivered to destination specified here.
    /// </summary>
    public partial class DatasetContentDeliveryRule
    {
        private DatasetContentDeliveryDestination _destination;
        private string _entryName;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination to which dataset contents are delivered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DatasetContentDeliveryDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property EntryName. 
        /// <para>
        /// The name of the dataset content delivery rules entry.
        /// </para>
        /// </summary>
        public string EntryName
        {
            get { return this._entryName; }
            set { this._entryName = value; }
        }

        // Check to see if EntryName property is set
        internal bool IsSetEntryName()
        {
            return this._entryName != null;
        }

    }
}