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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A type of <code>SuggestionQuery</code>. A suggestion query for retrieving property
    /// names that match the specified hint.
    /// </summary>
    public partial class PropertyNameQuery
    {
        private string _propertyNameHint;

        /// <summary>
        /// Gets and sets the property PropertyNameHint. 
        /// <para>
        /// Text that is part of a property's name. The property names of hyperparameter, metric,
        /// and tag key names that begin with the specified text in the <code>PropertyNameHint</code>.
        /// </para>
        /// </summary>
        public string PropertyNameHint
        {
            get { return this._propertyNameHint; }
            set { this._propertyNameHint = value; }
        }

        // Check to see if PropertyNameHint property is set
        internal bool IsSetPropertyNameHint()
        {
            return this._propertyNameHint != null;
        }

    }
}