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
    /// <summary>Delete Table Result
    /// </summary>
    public class DeleteTableResult  
    {
        
        private TableDescription tableDescription;
        public TableDescription TableDescription
        {
            get { return this.tableDescription; }
            set { this.tableDescription = value; }
        }

        /// <summary>
        /// Sets the TableDescription property
        /// </summary>
        /// <param name="tableDescription">The value to set for the TableDescription property </param>
        /// <returns>this instance</returns>
        public DeleteTableResult WithTableDescription(TableDescription tableDescription)
        {
            this.tableDescription = tableDescription;
            return this;
        }
            

        // Check to see if TableDescription property is set
        internal bool IsSetTableDescription()
        {
            return this.tableDescription != null;       
        }
    }
}
