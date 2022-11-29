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
    /// The filter that is applied to the options.
    /// </summary>
    public partial class SheetVisualScopingConfiguration
    {
        private FilterVisualScope _scope;
        private string _sheetId;
        private List<string> _visualIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the applied entities. Choose one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL_VISUALS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SELECTED_VISUALS</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterVisualScope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The selected sheet that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string SheetId
        {
            get { return this._sheetId; }
            set { this._sheetId = value; }
        }

        // Check to see if SheetId property is set
        internal bool IsSetSheetId()
        {
            return this._sheetId != null;
        }

        /// <summary>
        /// Gets and sets the property VisualIds. 
        /// <para>
        /// The selected visuals that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> VisualIds
        {
            get { return this._visualIds; }
            set { this._visualIds = value; }
        }

        // Check to see if VisualIds property is set
        internal bool IsSetVisualIds()
        {
            return this._visualIds != null && this._visualIds.Count > 0; 
        }

    }
}