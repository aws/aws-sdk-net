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
    /// The source entity of the template.
    /// </summary>
    public partial class TemplateSourceEntity
    {
        private TemplateSourceAnalysis _sourceAnalysis;
        private TemplateSourceTemplate _sourceTemplate;

        /// <summary>
        /// Gets and sets the property SourceAnalysis. 
        /// <para>
        /// The source analysis, if it is based on an analysis.
        /// </para>
        /// </summary>
        public TemplateSourceAnalysis SourceAnalysis
        {
            get { return this._sourceAnalysis; }
            set { this._sourceAnalysis = value; }
        }

        // Check to see if SourceAnalysis property is set
        internal bool IsSetSourceAnalysis()
        {
            return this._sourceAnalysis != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTemplate. 
        /// <para>
        /// The source template, if it is based on an template.
        /// </para>
        /// </summary>
        public TemplateSourceTemplate SourceTemplate
        {
            get { return this._sourceTemplate; }
            set { this._sourceTemplate = value; }
        }

        // Check to see if SourceTemplate property is set
        internal bool IsSetSourceTemplate()
        {
            return this._sourceTemplate != null;
        }

    }
}