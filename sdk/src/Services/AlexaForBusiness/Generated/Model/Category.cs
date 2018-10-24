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

/*
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The skill store category that is shown. Alexa skills are assigned a specific skill
    /// category during creation, such as News, Social, and Sports.
    /// </summary>
    public partial class Category
    {
        private long? _categoryId;
        private string _categoryName;

        /// <summary>
        /// Gets and sets the property CategoryId. 
        /// <para>
        /// The ID of the skill store category.
        /// </para>
        /// </summary>
        public long CategoryId
        {
            get { return this._categoryId.GetValueOrDefault(); }
            set { this._categoryId = value; }
        }

        // Check to see if CategoryId property is set
        internal bool IsSetCategoryId()
        {
            return this._categoryId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// The name of the skill store category.
        /// </para>
        /// </summary>
        public string CategoryName
        {
            get { return this._categoryName; }
            set { this._categoryName = value; }
        }

        // Check to see if CategoryName property is set
        internal bool IsSetCategoryName()
        {
            return this._categoryName != null;
        }

    }
}