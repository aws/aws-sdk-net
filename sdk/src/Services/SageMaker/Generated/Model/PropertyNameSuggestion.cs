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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A property name returned from a <code>GetSearchSuggestions</code> call that specifies
    /// a value in the <code>PropertyNameQuery</code> field.
    /// </summary>
    public partial class PropertyNameSuggestion
    {
        private string _propertyName;

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// A suggested property name based on what you entered in the search textbox in the SageMaker
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PropertyName
        {
            get { return this._propertyName; }
            set { this._propertyName = value; }
        }

        // Check to see if PropertyName property is set
        internal bool IsSetPropertyName()
        {
            return this._propertyName != null;
        }

    }
}