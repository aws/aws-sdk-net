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
    /// The operation that is defined by the custom action.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class VisualCustomActionOperation
    {
        private CustomActionFilterOperation _filterOperation;
        private CustomActionNavigationOperation _navigationOperation;
        private CustomActionSetParametersOperation _setParametersOperation;
        private CustomActionURLOperation _urlOperation;

        /// <summary>
        /// Gets and sets the property FilterOperation. 
        /// <para>
        /// The filter operation that filters data included in a visual or in an entire sheet.
        /// </para>
        /// </summary>
        public CustomActionFilterOperation FilterOperation
        {
            get { return this._filterOperation; }
            set { this._filterOperation = value; }
        }

        // Check to see if FilterOperation property is set
        internal bool IsSetFilterOperation()
        {
            return this._filterOperation != null;
        }

        /// <summary>
        /// Gets and sets the property NavigationOperation. 
        /// <para>
        /// The navigation operation that navigates between different sheets in the same analysis.
        /// </para>
        /// </summary>
        public CustomActionNavigationOperation NavigationOperation
        {
            get { return this._navigationOperation; }
            set { this._navigationOperation = value; }
        }

        // Check to see if NavigationOperation property is set
        internal bool IsSetNavigationOperation()
        {
            return this._navigationOperation != null;
        }

        /// <summary>
        /// Gets and sets the property SetParametersOperation. 
        /// <para>
        /// The set parameter operation that sets parameters in custom action.
        /// </para>
        /// </summary>
        public CustomActionSetParametersOperation SetParametersOperation
        {
            get { return this._setParametersOperation; }
            set { this._setParametersOperation = value; }
        }

        // Check to see if SetParametersOperation property is set
        internal bool IsSetSetParametersOperation()
        {
            return this._setParametersOperation != null;
        }

        /// <summary>
        /// Gets and sets the property URLOperation. 
        /// <para>
        /// The URL operation that opens a link to another webpage.
        /// </para>
        /// </summary>
        public CustomActionURLOperation URLOperation
        {
            get { return this._urlOperation; }
            set { this._urlOperation = value; }
        }

        // Check to see if URLOperation property is set
        internal bool IsSetURLOperation()
        {
            return this._urlOperation != null;
        }

    }
}