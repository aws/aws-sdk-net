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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Field attributes for Text field type.
    /// </summary>
    public partial class TextAttributes
    {
        private bool? _isMultiline;

        /// <summary>
        /// Gets and sets the property IsMultiline. 
        /// <para>
        /// Attribute that defines rendering component and validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsMultiline
        {
            get { return this._isMultiline.GetValueOrDefault(); }
            set { this._isMultiline = value; }
        }

        // Check to see if IsMultiline property is set
        internal bool IsSetIsMultiline()
        {
            return this._isMultiline.HasValue; 
        }

    }
}