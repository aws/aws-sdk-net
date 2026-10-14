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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A property name returned from a <c>GetSearchSuggestions</c> call that specifies a
    /// value in the <c>PropertyNameQuery</c> field.
    /// </summary>
    public partial class PropertyNameSuggestion
    {
        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// A suggested property name based on what you entered in the search textbox in the SageMaker
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Checks to see if the PropertyName property is set.
        /// </summary>
        internal bool IsSetPropertyName() => this.PropertyName != null;
    }
}
