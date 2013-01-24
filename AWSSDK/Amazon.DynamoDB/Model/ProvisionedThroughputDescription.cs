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

namespace Amazon.DynamoDB.Model
{
    /// <summary>Provisioned Throughput Description
    /// </summary>
    public class ProvisionedThroughputDescription  
    {
        
        private DateTime? lastIncreaseDateTime;
        private DateTime? lastDecreaseDateTime;
        private long? numberOfDecreasesToday;
        private long? readCapacityUnits;
        private long? writeCapacityUnits;
        public DateTime LastIncreaseDateTime
        {
            get { return this.lastIncreaseDateTime ?? default(DateTime); }
            set { this.lastIncreaseDateTime = value; }
        }

        /// <summary>
        /// Sets the LastIncreaseDateTime property
        /// </summary>
        /// <param name="lastIncreaseDateTime">The value to set for the LastIncreaseDateTime property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughputDescription WithLastIncreaseDateTime(DateTime lastIncreaseDateTime)
        {
            this.lastIncreaseDateTime = lastIncreaseDateTime;
            return this;
        }
            

        // Check to see if LastIncreaseDateTime property is set
        internal bool IsSetLastIncreaseDateTime()
        {
            return this.lastIncreaseDateTime.HasValue;       
        }
        public DateTime LastDecreaseDateTime
        {
            get { return this.lastDecreaseDateTime ?? default(DateTime); }
            set { this.lastDecreaseDateTime = value; }
        }

        /// <summary>
        /// Sets the LastDecreaseDateTime property
        /// </summary>
        /// <param name="lastDecreaseDateTime">The value to set for the LastDecreaseDateTime property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughputDescription WithLastDecreaseDateTime(DateTime lastDecreaseDateTime)
        {
            this.lastDecreaseDateTime = lastDecreaseDateTime;
            return this;
        }
            

        // Check to see if LastDecreaseDateTime property is set
        internal bool IsSetLastDecreaseDateTime()
        {
            return this.lastDecreaseDateTime.HasValue;       
        }
        public long NumberOfDecreasesToday
        {
            get { return this.numberOfDecreasesToday ?? default(long); }
            set { this.numberOfDecreasesToday = value; }
        }

        /// <summary>
        /// Sets the NumberOfDecreasesToday property
        /// </summary>
        /// <param name="numberOfDecreasesToday">The value to set for the NumberOfDecreasesToday property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughputDescription WithNumberOfDecreasesToday(long numberOfDecreasesToday)
        {
            this.numberOfDecreasesToday = numberOfDecreasesToday;
            return this;
        }
            

        // Check to see if NumberOfDecreasesToday property is set
        internal bool IsSetNumberOfDecreasesToday()
        {
            return this.numberOfDecreasesToday.HasValue;       
        }
        public long ReadCapacityUnits
        {
            get { return this.readCapacityUnits ?? default(long); }
            set { this.readCapacityUnits = value; }
        }

        /// <summary>
        /// Sets the ReadCapacityUnits property
        /// </summary>
        /// <param name="readCapacityUnits">The value to set for the ReadCapacityUnits property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughputDescription WithReadCapacityUnits(long readCapacityUnits)
        {
            this.readCapacityUnits = readCapacityUnits;
            return this;
        }
            

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this.readCapacityUnits.HasValue;       
        }
        public long WriteCapacityUnits
        {
            get { return this.writeCapacityUnits ?? default(long); }
            set { this.writeCapacityUnits = value; }
        }

        /// <summary>
        /// Sets the WriteCapacityUnits property
        /// </summary>
        /// <param name="writeCapacityUnits">The value to set for the WriteCapacityUnits property </param>
        /// <returns>this instance</returns>
        public ProvisionedThroughputDescription WithWriteCapacityUnits(long writeCapacityUnits)
        {
            this.writeCapacityUnits = writeCapacityUnits;
            return this;
        }
            

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this.writeCapacityUnits.HasValue;       
        }
    }
}
