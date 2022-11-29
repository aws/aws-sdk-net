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
    /// Dashboard publish options.
    /// </summary>
    public partial class DashboardPublishOptions
    {
        private AdHocFilteringOption _adHocFilteringOption;
        private ExportToCSVOption _exportToCSVOption;
        private SheetControlsOption _sheetControlsOption;
        private DashboardVisualPublishOptions _visualPublishOptions;

        /// <summary>
        /// Gets and sets the property AdHocFilteringOption. 
        /// <para>
        /// Ad hoc (one-time) filtering option.
        /// </para>
        /// </summary>
        public AdHocFilteringOption AdHocFilteringOption
        {
            get { return this._adHocFilteringOption; }
            set { this._adHocFilteringOption = value; }
        }

        // Check to see if AdHocFilteringOption property is set
        internal bool IsSetAdHocFilteringOption()
        {
            return this._adHocFilteringOption != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToCSVOption. 
        /// <para>
        /// Export to .csv option.
        /// </para>
        /// </summary>
        public ExportToCSVOption ExportToCSVOption
        {
            get { return this._exportToCSVOption; }
            set { this._exportToCSVOption = value; }
        }

        // Check to see if ExportToCSVOption property is set
        internal bool IsSetExportToCSVOption()
        {
            return this._exportToCSVOption != null;
        }

        /// <summary>
        /// Gets and sets the property SheetControlsOption. 
        /// <para>
        /// Sheet controls option.
        /// </para>
        /// </summary>
        public SheetControlsOption SheetControlsOption
        {
            get { return this._sheetControlsOption; }
            set { this._sheetControlsOption = value; }
        }

        // Check to see if SheetControlsOption property is set
        internal bool IsSetSheetControlsOption()
        {
            return this._sheetControlsOption != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPublishOptions.
        /// </summary>
        public DashboardVisualPublishOptions VisualPublishOptions
        {
            get { return this._visualPublishOptions; }
            set { this._visualPublishOptions = value; }
        }

        // Check to see if VisualPublishOptions property is set
        internal bool IsSetVisualPublishOptions()
        {
            return this._visualPublishOptions != null;
        }

    }
}