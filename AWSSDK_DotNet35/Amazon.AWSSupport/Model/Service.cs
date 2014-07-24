/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Information about an AWS service returned by the <a>DescribeServices</a> operation.
    /// </summary>
    public partial class Service
    {
        private List<Category> _categories = new List<Category>();
        private string _code;
        private string _name;


        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// A list of categories that describe the type of support issue a case describes. Categories
        /// consist of a category name and a category code. Category names and codes are passed
        /// to AWS Support when you call <a>CreateCase</a>.
        /// </para>
        /// </summary>
        public List<Category> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && this._categories.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The code for an AWS service returned by the <a>DescribeServices</a> response. The
        /// <code>Name</code> element contains the corresponding friendly name.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }


        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name for an AWS service. The <code>Code</code> element contains the corresponding
        /// code.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}