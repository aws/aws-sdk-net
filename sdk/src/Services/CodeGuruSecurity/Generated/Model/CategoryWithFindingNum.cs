/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about a finding category with open findings.
    /// </summary>
    public partial class CategoryWithFindingNum
    {
        private string _categoryName;
        private int? _findingNumber;

        /// <summary>
        /// Gets and sets the property CategoryName. 
        /// <para>
        /// The name of the finding category. A finding category is determined by the detector
        /// that detected the finding.
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

        /// <summary>
        /// Gets and sets the property FindingNumber. 
        /// <para>
        /// The number of open findings in the category.
        /// </para>
        /// </summary>
        public int? FindingNumber
        {
            get { return this._findingNumber; }
            set { this._findingNumber = value; }
        }

        // Check to see if FindingNumber property is set
        internal bool IsSetFindingNumber()
        {
            return this._findingNumber.HasValue; 
        }

    }
}