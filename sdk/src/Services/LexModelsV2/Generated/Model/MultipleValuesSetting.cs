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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Indicates whether a slot can return multiple values.
    /// </summary>
    public partial class MultipleValuesSetting
    {
        private bool? _allowMultipleValues;

        /// <summary>
        /// Gets and sets the property AllowMultipleValues. 
        /// <para>
        /// Indicates whether a slot can return multiple values. When <code>true</code>, the slot
        /// may return more than one value in a response. When <code>false</code>, the slot returns
        /// only a single value.
        /// </para>
        ///  
        /// <para>
        /// Multi-value slots are only available in the en-US locale. If you set this value to
        /// <code>true</code> in any other locale, Amazon Lex throws a <code>ValidationException</code>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>allowMutlipleValues</code> is not set, the default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool AllowMultipleValues
        {
            get { return this._allowMultipleValues.GetValueOrDefault(); }
            set { this._allowMultipleValues = value; }
        }

        // Check to see if AllowMultipleValues property is set
        internal bool IsSetAllowMultipleValues()
        {
            return this._allowMultipleValues.HasValue; 
        }

    }
}