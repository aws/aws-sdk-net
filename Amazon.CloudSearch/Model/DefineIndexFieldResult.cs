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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the status of an updated index field.</para>
    /// </summary>
    public class DefineIndexFieldResult  
    {
        
        private IndexFieldStatus indexField;

        /// <summary>
        /// The value of an <c>IndexField</c> and its current status.
        ///  
        /// </summary>
        public IndexFieldStatus IndexField
        {
            get { return this.indexField; }
            set { this.indexField = value; }
        }

        /// <summary>
        /// Sets the IndexField property
        /// </summary>
        /// <param name="indexField">The value to set for the IndexField property </param>
        /// <returns>this instance</returns>
        public DefineIndexFieldResult WithIndexField(IndexFieldStatus indexField)
        {
            this.indexField = indexField;
            return this;
        }
            

        // Check to see if IndexField property is set
        internal bool IsSetIndexField()
        {
            return this.indexField != null;       
        }
    }
}
