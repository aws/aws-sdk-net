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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>Represents an AWS Service returned by the DescribeServices action. </para>
    /// </summary>
    public class Service
    {
        
        private string code;
        private string name;
        private List<Category> categories = new List<Category>();


        /// <summary>
        /// The code for an AWS service returned by <a>DescribeServices</a> response. Has a corresponding name represented by Service.name.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// The friendly name for an AWS service. Has a corresponding code represented by Service.code.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// A list of categories that describe the type of support issue a case describes. Categories consist of a category name and a category code.
        /// Category names and codes are passed to AWS Support when you call <a>CreateCase</a>.
        ///  
        /// </summary>
        public List<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this.categories.Count > 0;
        }
    }
}
