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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
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
namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Sets the scaling configuration of an Amazon DocumentDB Serverless cluster.
    /// </summary>
    public partial class ServerlessV2ScalingConfiguration
    {
        private double? _maxCapacity;
        private double? _minCapacity;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of Amazon DocumentDB capacity units (DCUs) for an instance in an
        /// Amazon DocumentDB Serverless cluster. You can specify DCU values in half-step increments,
        /// such as 32, 32.5, 33, and so on.
        /// </para>
        /// </summary>
        public double? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// The minimum number of Amazon DocumentDB capacity units (DCUs) for an instance in an
        /// Amazon DocumentDB Serverless cluster. You can specify DCU values in half-step increments,
        /// such as 8, 8.5, 9, and so on.
        /// </para>
        /// </summary>
        public double? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

    }
}