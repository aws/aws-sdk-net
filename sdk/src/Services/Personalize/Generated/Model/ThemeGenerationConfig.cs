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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The configuration details for generating themes with a batch inference job.
    /// </summary>
    public partial class ThemeGenerationConfig
    {
        private FieldsForThemeGeneration _fieldsForThemeGeneration;

        /// <summary>
        /// Gets and sets the property FieldsForThemeGeneration. 
        /// <para>
        /// Fields used to generate descriptive themes for a batch inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldsForThemeGeneration FieldsForThemeGeneration
        {
            get { return this._fieldsForThemeGeneration; }
            set { this._fieldsForThemeGeneration = value; }
        }

        // Check to see if FieldsForThemeGeneration property is set
        internal bool IsSetFieldsForThemeGeneration()
        {
            return this._fieldsForThemeGeneration != null;
        }

    }
}