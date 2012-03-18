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
    /// <summary>Filter
    /// </summary>
    public class Filter  
    {
        
        private string name;
        private List<string> values = new List<string>();
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        public Filter WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;       
        }
        public List<string> Values
        {
            get { return this.values; }
            set { this.values = value; }
        }
        /// <summary>
        /// Adds elements to the Values collection
        /// </summary>
        /// <param name="values">The values to add to the Values collection </param>
        /// <returns>this instance</returns>
        public Filter WithValues(params string[] values)
        {
            foreach (string element in values)
            {
                this.values.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Values collection
        /// </summary>
        /// <param name="values">The values to add to the Values collection </param>
        /// <returns>this instance</returns>
        public Filter WithValues(IEnumerable<string> values)
        {
            foreach (string element in values)
            {
                this.values.Add(element);
            }

            return this;
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this.values.Count > 0;       
        }
    }
}
