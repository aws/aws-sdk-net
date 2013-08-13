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
    /// <para>JSON-formatted object that represents an AWS Service returned by the DescribeServices action. </para>
    /// </summary>
    public class Service
    {
        
        private string code;
        private string name;
        private List<Category> categories = new List<Category>();

        /// <summary>
        /// JSON-formatted string that represents a code for an AWS service returned by <a href="API_DescribeServices.html"
        /// title="DescribeServices">DescribeServices</a> response. Has a corrsponding name represented by a service.name string.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        /// <summary>
        /// Sets the Code property
        /// </summary>
        /// <param name="code">The value to set for the Code property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Service WithCode(string code)
        {
            this.code = code;
            return this;
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

        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">The value to set for the Name property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Service WithName(string name)
        {
            this.name = name;
            return this;
        }
            

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// JSON-formatted list of categories that describe the type of support issue a case describes. Categories are strings that represent a category
        /// name and a category code. Category names and codes are passed to AWS Support when you call <a href="API_CreateCase.html"
        /// title="CreateCase">CreateCase</a>.
        ///  
        /// </summary>
        public List<Category> Categories
        {
            get { return this.categories; }
            set { this.categories = value; }
        }
        /// <summary>
        /// Adds elements to the Categories collection
        /// </summary>
        /// <param name="categories">The values to add to the Categories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Service WithCategories(params Category[] categories)
        {
            foreach (Category element in categories)
            {
                this.categories.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Categories collection
        /// </summary>
        /// <param name="categories">The values to add to the Categories collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Service WithCategories(IEnumerable<Category> categories)
        {
            foreach (Category element in categories)
            {
                this.categories.Add(element);
            }

            return this;
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this.categories.Count > 0;
        }
    }
}
