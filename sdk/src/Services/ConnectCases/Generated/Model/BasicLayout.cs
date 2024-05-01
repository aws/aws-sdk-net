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
    /// Content specific to <c>BasicLayout</c> type. It configures fields in the top panel
    /// and More Info tab of agent application.
    /// </summary>
    public partial class BasicLayout
    {
        private LayoutSections _moreInfo;
        private LayoutSections _topPanel;

        /// <summary>
        /// Gets and sets the property MoreInfo. 
        /// <para>
        /// This represents sections in a tab of the page layout.
        /// </para>
        /// </summary>
        public LayoutSections MoreInfo
        {
            get { return this._moreInfo; }
            set { this._moreInfo = value; }
        }

        // Check to see if MoreInfo property is set
        internal bool IsSetMoreInfo()
        {
            return this._moreInfo != null;
        }

        /// <summary>
        /// Gets and sets the property TopPanel. 
        /// <para>
        /// This represents sections in a panel of the page layout.
        /// </para>
        /// </summary>
        public LayoutSections TopPanel
        {
            get { return this._topPanel; }
            set { this._topPanel = value; }
        }

        // Check to see if TopPanel property is set
        internal bool IsSetTopPanel()
        {
            return this._topPanel != null;
        }

    }
}