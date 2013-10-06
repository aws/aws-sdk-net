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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the index fields for a search domain.</para>
    /// </summary>
    public class DescribeIndexFieldsResult  
    {
        
        private List<IndexFieldStatus> indexFields = new List<IndexFieldStatus>();

        /// <summary>
        /// The index fields configured for the domain.
        ///  
        /// </summary>
        public List<IndexFieldStatus> IndexFields
        {
            get { return this.indexFields; }
            set { this.indexFields = value; }
        }
        /// <summary>
        /// Adds elements to the IndexFields collection
        /// </summary>
        /// <param name="indexFields">The values to add to the IndexFields collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeIndexFieldsResult WithIndexFields(params IndexFieldStatus[] indexFields)
        {
            foreach (IndexFieldStatus element in indexFields)
            {
                this.indexFields.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the IndexFields collection
        /// </summary>
        /// <param name="indexFields">The values to add to the IndexFields collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeIndexFieldsResult WithIndexFields(IEnumerable<IndexFieldStatus> indexFields)
        {
            foreach (IndexFieldStatus element in indexFields)
            {
                this.indexFields.Add(element);
            }

            return this;
        }

        // Check to see if IndexFields property is set
        internal bool IsSetIndexFields()
        {
            return this.indexFields.Count > 0;       
        }
    }
}
