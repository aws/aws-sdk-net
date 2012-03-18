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

namespace Amazon.AutoScaling.Model
{
    /// <summary>Describe Tags Result
    /// </summary>
    public class DescribeTagsResult  
    {
        
        private List<TagDescription> tags = new List<TagDescription>();
        private string nextToken;
        public List<TagDescription> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public DescribeTagsResult WithTags(params TagDescription[] tags)
        {
            foreach (TagDescription element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public DescribeTagsResult WithTags(IEnumerable<TagDescription> tags)
        {
            foreach (TagDescription element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;       
        }
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public DescribeTagsResult WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;       
        }
    }
}
