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
    /// A structure that contains the following elements:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The <c>DashboardId</c> of the dashboard that has the visual that you want to embed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>SheetId</c> of the sheet that has the visual that you want to embed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>VisualId</c> of the visual that you want to embed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The <c>DashboardId</c>, <c>SheetId</c>, and <c>VisualId</c> can be found in the <c>IDs
    /// for developers</c> section of the <c>Embed visual</c> pane of the visual's on-visual
    /// menu of the Amazon QuickSight console. You can also get the <c>DashboardId</c> with
    /// a <c>ListDashboards</c> API operation.
    /// </para>
    /// </summary>
    public partial class DashboardVisualId
    {
        private string _dashboardId;
        private string _sheetId;
        private string _visualId;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID of the dashboard that has the visual that you want to embed. The <c>DashboardId</c>
        /// can be found in the <c>IDs for developers</c> section of the <c>Embed visual</c> pane
        /// of the visual's on-visual menu of the Amazon QuickSight console. You can also get
        /// the <c>DashboardId</c> with a <c>ListDashboards</c> API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property SheetId. 
        /// <para>
        /// The ID of the sheet that the has visual that you want to embed. The <c>SheetId</c>
        /// can be found in the <c>IDs for developers</c> section of the <c>Embed visual</c> pane
        /// of the visual's on-visual menu of the Amazon QuickSight console.
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
        /// Gets and sets the property VisualId. 
        /// <para>
        /// The ID of the visual that you want to embed. The <c>VisualID</c> can be found in the
        /// <c>IDs for developers</c> section of the <c>Embed visual</c> pane of the visual's
        /// on-visual menu of the Amazon QuickSight console.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string VisualId
        {
            get { return this._visualId; }
            set { this._visualId = value; }
        }

        // Check to see if VisualId property is set
        internal bool IsSetVisualId()
        {
            return this._visualId != null;
        }

    }
}