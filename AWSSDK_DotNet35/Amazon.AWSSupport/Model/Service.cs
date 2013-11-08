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
    /// <para>JSON-formatted object that represents an AWS Service returned by the <a
    /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" >DescribeServices</a> action. </para>
    /// </summary>
    public class Service
    {
        
        private string code;
        private string name;
        private List<Category> categories = new List<Category>();

        /// <summary>
        /// JSON-formatted string that represents a code for an AWS service returned by <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_DescribeServices.html" title="DescribeServices">DescribeServices</a>
        /// response. Has a corrsponding name represented by a service.name string.
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
        /// JSON-formatted string that represents the friendly name for an AWS service. Has a corresponding code reprsented by a Service.code string.
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
        /// JSON-formatted list of categories that describe the type of support issue a case describes. Categories are strings that represent a category
        /// name and a category code. Category names and codes are passed to AWS Support when you call <a
        /// href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_CreateCase.html" title="CreateCase">CreateCase</a>.
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
