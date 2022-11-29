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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The layout configuration of a section.
    /// </summary>
    public partial class SectionLayoutConfiguration
    {
        private FreeFormSectionLayoutConfiguration _freeFormLayout;

        /// <summary>
        /// Gets and sets the property FreeFormLayout. 
        /// <para>
        /// The free-form layout configuration of a section.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FreeFormSectionLayoutConfiguration FreeFormLayout
        {
            get { return this._freeFormLayout; }
            set { this._freeFormLayout = value; }
        }

        // Check to see if FreeFormLayout property is set
        internal bool IsSetFreeFormLayout()
        {
            return this._freeFormLayout != null;
        }

    }
}