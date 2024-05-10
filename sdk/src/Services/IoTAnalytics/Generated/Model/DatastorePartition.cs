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
    /// A single dimension to partition a data store. The dimension must be an <c>AttributePartition</c>
    /// or a <c>TimestampPartition</c>.
    /// </summary>
    public partial class DatastorePartition
    {
        private Partition _attributePartition;
        private TimestampPartition _timestampPartition;

        /// <summary>
        /// Gets and sets the property AttributePartition. 
        /// <para>
        ///  A partition dimension defined by an <c>attributeName</c>. 
        /// </para>
        /// </summary>
        public Partition AttributePartition
        {
            get { return this._attributePartition; }
            set { this._attributePartition = value; }
        }

        // Check to see if AttributePartition property is set
        internal bool IsSetAttributePartition()
        {
            return this._attributePartition != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampPartition. 
        /// <para>
        ///  A partition dimension defined by a timestamp attribute. 
        /// </para>
        /// </summary>
        public TimestampPartition TimestampPartition
        {
            get { return this._timestampPartition; }
            set { this._timestampPartition = value; }
        }

        // Check to see if TimestampPartition property is set
        internal bool IsSetTimestampPartition()
        {
            return this._timestampPartition != null;
        }

    }
}