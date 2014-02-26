/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents the amount of provisioned throughput capacity consumed on a table or an index. </para>
    /// </summary>
    public class Capacity
    {
        
        private double? capacityUnits;

        /// <summary>
        /// The total number of capacity units consumed on a table or an index.
        ///  
        /// </summary>
        public double CapacityUnits
        {
            get { return this.capacityUnits ?? default(double); }
            set { this.capacityUnits = value; }
        }

        /// <summary>
        /// Sets the CapacityUnits property
        /// </summary>
        /// <param name="capacityUnits">The value to set for the CapacityUnits property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Capacity WithCapacityUnits(double capacityUnits)
        {
            this.capacityUnits = capacityUnits;
            return this;
        }
            

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this.capacityUnits.HasValue;
        }
    }
}
