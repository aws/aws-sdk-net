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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A custom instruction that provides guidance on how the dataset should be consumed.
    /// </summary>
    public partial class CustomInstruction
    {
        private InlineCustomInstruction _inlineCustomInstruction;

        /// <summary>
        /// Gets and sets the property InlineCustomInstruction. 
        /// <para>
        /// An inline custom instruction containing text and optional uploaded document metadata.
        /// </para>
        /// </summary>
        public InlineCustomInstruction InlineCustomInstruction
        {
            get { return this._inlineCustomInstruction; }
            set { this._inlineCustomInstruction = value; }
        }

        // Check to see if InlineCustomInstruction property is set
        internal bool IsSetInlineCustomInstruction()
        {
            return this._inlineCustomInstruction != null;
        }

    }
}