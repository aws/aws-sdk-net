/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>Describe Table Result
    /// </summary>
    public class DescribeTableResult  
    {
        
        private TableDescription table;
        public TableDescription Table
        {
            get { return this.table; }
            set { this.table = value; }
        }

        /// <summary>
        /// Sets the Table property
        /// </summary>
        /// <param name="table">The value to set for the Table property </param>
        /// <returns>this instance</returns>
        public DescribeTableResult WithTable(TableDescription table)
        {
            this.table = table;
            return this;
        }
            

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this.table != null;       
        }
    }
}
