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
    /// <para>The result of an <c>IndexDocuments</c> action.</para>
    /// </summary>
    public class IndexDocumentsResult  
    {
        
        private List<string> fieldNames = new List<string>();

        /// <summary>
        /// The names of the fields that are currently being processed due to an <c>IndexDocuments</c> action.
        ///  
        /// </summary>
        public List<string> FieldNames
        {
            get { return this.fieldNames; }
            set { this.fieldNames = value; }
        }
        /// <summary>
        /// Adds elements to the FieldNames collection
        /// </summary>
        /// <param name="fieldNames">The values to add to the FieldNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexDocumentsResult WithFieldNames(params string[] fieldNames)
        {
            foreach (string element in fieldNames)
            {
                this.fieldNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the FieldNames collection
        /// </summary>
        /// <param name="fieldNames">The values to add to the FieldNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IndexDocumentsResult WithFieldNames(IEnumerable<string> fieldNames)
        {
            foreach (string element in fieldNames)
            {
                this.fieldNames.Add(element);
            }

            return this;
        }

        // Check to see if FieldNames property is set
        internal bool IsSetFieldNames()
        {
            return this.fieldNames.Count > 0;       
        }
    }
}
