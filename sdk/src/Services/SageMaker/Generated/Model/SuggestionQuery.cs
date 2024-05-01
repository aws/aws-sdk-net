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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specified in the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_GetSearchSuggestions.html">GetSearchSuggestions</a>
    /// request. Limits the property names that are included in the response.
    /// </summary>
    public partial class SuggestionQuery
    {
        private PropertyNameQuery _propertyNameQuery;

        /// <summary>
        /// Gets and sets the property PropertyNameQuery. 
        /// <para>
        /// Defines a property name hint. Only property names that begin with the specified hint
        /// are included in the response.
        /// </para>
        /// </summary>
        public PropertyNameQuery PropertyNameQuery
        {
            get { return this._propertyNameQuery; }
            set { this._propertyNameQuery = value; }
        }

        // Check to see if PropertyNameQuery property is set
        internal bool IsSetPropertyNameQuery()
        {
            return this._propertyNameQuery != null;
        }

    }
}