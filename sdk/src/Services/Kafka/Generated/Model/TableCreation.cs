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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Configuration controlling whether MSK creates the destination Apache Iceberg table
    /// if it does not already exist.
    /// </summary>
    public partial class TableCreation
    {
        private bool? _enableTableCreation;

        /// <summary>
        /// Gets and sets the property EnableTableCreation. 
        /// <para>
        /// Whether MSK creates the destination table on the customer's behalf. Must be true for
        /// the current release.
        /// </para>
        /// </summary>
        public bool? EnableTableCreation
        {
            get { return this._enableTableCreation; }
            set { this._enableTableCreation = value; }
        }

        // Check to see if EnableTableCreation property is set
        internal bool IsSetEnableTableCreation()
        {
            return this._enableTableCreation.HasValue; 
        }

    }
}