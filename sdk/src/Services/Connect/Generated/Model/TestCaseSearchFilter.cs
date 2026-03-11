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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Filters to be applied to search results.
    /// </summary>
    public partial class TestCaseSearchFilter
    {
        private ControlPlaneTagFilter _tagFilter;

        /// <summary>
        /// Gets and sets the property TagFilter. 
        /// <para>
        /// An object that can be used to specify Tag conditions inside the SearchFilter. This
        /// accepts an OR of AND (List of List) input where: Top level list specifies conditions
        /// that need to be applied with OR operator. Inner list specifies conditions that need
        /// to be applied with AND operator.
        /// </para>
        /// </summary>
        public ControlPlaneTagFilter TagFilter
        {
            get { return this._tagFilter; }
            set { this._tagFilter = value; }
        }

        // Check to see if TagFilter property is set
        internal bool IsSetTagFilter()
        {
            return this._tagFilter != null;
        }

    }
}