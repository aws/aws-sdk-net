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
    /// The rendering rules of a sheet that uses a free-form layout.
    /// </summary>
    public partial class SheetElementRenderingRule
    {
        private SheetElementConfigurationOverrides _configurationOverrides;
        private string _expression;

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The override configuration of the rendering rules of a sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SheetElementConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The expression of the rendering rules of a sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

    }
}