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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Sets the maximum number of read and write units for the specified on-demand table.
    /// If you use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
    /// or both.
    /// </summary>
    public partial class OnDemandThroughput
    {
        private long? _maxReadRequestUnits;
        private long? _maxWriteRequestUnits;

        /// <summary>
        /// Gets and sets the property MaxReadRequestUnits. 
        /// <para>
        /// Maximum number of read request units for the specified table.
        /// </para>
        ///  
        /// <para>
        /// To specify a maximum <c>OnDemandThroughput</c> on your table, set the value of <c>MaxReadRequestUnits</c>
        /// as greater than or equal to 1. To remove the maximum <c>OnDemandThroughput</c> that
        /// is currently set on your table, set the value of <c>MaxReadRequestUnits</c> to -1.
        /// </para>
        /// </summary>
        public long? MaxReadRequestUnits
        {
            get { return this._maxReadRequestUnits; }
            set { this._maxReadRequestUnits = value; }
        }

        // Check to see if MaxReadRequestUnits property is set
        internal bool IsSetMaxReadRequestUnits()
        {
            return this._maxReadRequestUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWriteRequestUnits. 
        /// <para>
        /// Maximum number of write request units for the specified table.
        /// </para>
        ///  
        /// <para>
        /// To specify a maximum <c>OnDemandThroughput</c> on your table, set the value of <c>MaxWriteRequestUnits</c>
        /// as greater than or equal to 1. To remove the maximum <c>OnDemandThroughput</c> that
        /// is currently set on your table, set the value of <c>MaxWriteRequestUnits</c> to -1.
        /// </para>
        /// </summary>
        public long? MaxWriteRequestUnits
        {
            get { return this._maxWriteRequestUnits; }
            set { this._maxWriteRequestUnits = value; }
        }

        // Check to see if MaxWriteRequestUnits property is set
        internal bool IsSetMaxWriteRequestUnits()
        {
            return this._maxWriteRequestUnits.HasValue; 
        }

    }
}