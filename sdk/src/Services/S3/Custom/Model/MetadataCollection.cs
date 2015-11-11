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
using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class contains the meta data for an S3 object.
    /// </summary>
    public sealed class MetadataCollection
    {
        
        IDictionary<string, string> values = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets meta data for the object. Meta data names must start with "x-amz-meta-". If the name passeed in as the indexer 
        /// doesn't start with "x-amz-meta-" then it will be prepended.
        /// </summary>
        /// <param name="name">The name of the meta data.</param>
        /// <returns>The value for the meta data</returns>
        public string this[string name]
        {
            get
            {
                if (!name.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase))
                    name = "x-amz-meta-" + name;

                string value;
                if (values.TryGetValue(name, out value))
                    return value;

                return null;
            }
            set
            {
                if (!name.StartsWith("x-amz-meta-", StringComparison.OrdinalIgnoreCase))
                    name = "x-amz-meta-" + name;

                values[name] = value;
            }
        }

        /// <summary>
        /// Adds the metadata to the collection, if the name already exists it will be overwritten.
        /// </summary>
        /// <param name="name">The name of the metadata element</param>
        /// <param name="value">The value for the metadata</param>
        public void Add(string name, string value)
        {
            this[name] = value;
        }

        /// <summary>
        /// Gets the count of headers.
        /// </summary>
        public int Count
        {
            get { return this.values.Count; }
        }

        /// <summary>
        /// Gets the names of the meta data elements.
        /// </summary>
        public ICollection<string> Keys
        {
            get { return values.Keys; }
        }
    }
}
