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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Instructions for generating a specific section of a clinical note
    /// </summary>
    public partial class TemplateSectionInstruction
    {
        private string _sectionHeader;
        private string _sectionInstruction;

        /// <summary>
        /// Gets and sets the property SectionHeader. 
        /// <para>
        /// The header for this section of the template
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string SectionHeader
        {
            get { return this._sectionHeader; }
            set { this._sectionHeader = value; }
        }

        // Check to see if SectionHeader property is set
        internal bool IsSetSectionHeader()
        {
            return this._sectionHeader != null;
        }

        /// <summary>
        /// Gets and sets the property SectionInstruction. 
        /// <para>
        /// The instruction for generating this section
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string SectionInstruction
        {
            get { return this._sectionInstruction; }
            set { this._sectionInstruction = value; }
        }

        // Check to see if SectionInstruction property is set
        internal bool IsSetSectionInstruction()
        {
            return this._sectionInstruction != null;
        }

    }
}