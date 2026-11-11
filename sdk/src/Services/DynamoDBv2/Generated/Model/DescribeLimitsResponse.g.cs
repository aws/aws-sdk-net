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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the DescribeLimits operation.
    /// </summary>
    public partial class DescribeLimitsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountMaxReadCapacityUnits. 
        /// <para>
        /// The maximum total read capacity units that your account allows you to provision across
        /// all of your tables in this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? AccountMaxReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the AccountMaxReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetAccountMaxReadCapacityUnits() => this.AccountMaxReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property AccountMaxWriteCapacityUnits. 
        /// <para>
        /// The maximum total write capacity units that your account allows you to provision across
        /// all of your tables in this Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? AccountMaxWriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the AccountMaxWriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetAccountMaxWriteCapacityUnits() => this.AccountMaxWriteCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property TableMaxReadCapacityUnits. 
        /// <para>
        /// The maximum read capacity units that your account allows you to provision for a new
        /// table that you are creating in this Region, including the read capacity units provisioned
        /// for its global secondary indexes (GSIs).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? TableMaxReadCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the TableMaxReadCapacityUnits property is set.
        /// </summary>
        internal bool IsSetTableMaxReadCapacityUnits() => this.TableMaxReadCapacityUnits.HasValue;

        /// <summary>
        /// Gets and sets the property TableMaxWriteCapacityUnits. 
        /// <para>
        /// The maximum write capacity units that your account allows you to provision for a new
        /// table that you are creating in this Region, including the write capacity units provisioned
        /// for its global secondary indexes (GSIs).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? TableMaxWriteCapacityUnits { get; set; }

        /// <summary>
        /// Checks to see if the TableMaxWriteCapacityUnits property is set.
        /// </summary>
        internal bool IsSetTableMaxWriteCapacityUnits() => this.TableMaxWriteCapacityUnits.HasValue;
    }
}
