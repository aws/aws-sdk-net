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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Configuration settings to define how Amazon Q Business generates and formats responses
    /// to user queries. This includes customization options for response style, tone, length,
    /// and other characteristics.
    /// </summary>
    public partial class ResponseConfiguration
    {
        private InstructionCollection _instructionCollection;

        /// <summary>
        /// Gets and sets the property InstructionCollection. 
        /// <para>
        /// A collection of instructions that guide how Amazon Q Business generates responses,
        /// including parameters for response length, target audience, perspective, output style,
        /// identity, tone, and custom instructions.
        /// </para>
        /// </summary>
        public InstructionCollection InstructionCollection
        {
            get { return this._instructionCollection; }
            set { this._instructionCollection = value; }
        }

        // Check to see if InstructionCollection property is set
        internal bool IsSetInstructionCollection()
        {
            return this._instructionCollection != null;
        }

    }
}