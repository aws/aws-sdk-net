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
    /// The configuration for default new sheet settings.
    /// </summary>
    public partial class DefaultNewSheetConfiguration
    {
        private DefaultInteractiveLayoutConfiguration _interactiveLayoutConfiguration;
        private DefaultPaginatedLayoutConfiguration _paginatedLayoutConfiguration;
        private SheetContentType _sheetContentType;

        /// <summary>
        /// Gets and sets the property InteractiveLayoutConfiguration. 
        /// <para>
        /// The options that determine the default settings for interactive layout configuration.
        /// </para>
        /// </summary>
        public DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration
        {
            get { return this._interactiveLayoutConfiguration; }
            set { this._interactiveLayoutConfiguration = value; }
        }

        // Check to see if InteractiveLayoutConfiguration property is set
        internal bool IsSetInteractiveLayoutConfiguration()
        {
            return this._interactiveLayoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PaginatedLayoutConfiguration. 
        /// <para>
        /// The options that determine the default settings for a paginated layout configuration.
        /// </para>
        /// </summary>
        public DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration
        {
            get { return this._paginatedLayoutConfiguration; }
            set { this._paginatedLayoutConfiguration = value; }
        }

        // Check to see if PaginatedLayoutConfiguration property is set
        internal bool IsSetPaginatedLayoutConfiguration()
        {
            return this._paginatedLayoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SheetContentType. 
        /// <para>
        /// The option that determines the sheet content type.
        /// </para>
        /// </summary>
        public SheetContentType SheetContentType
        {
            get { return this._sheetContentType; }
            set { this._sheetContentType = value; }
        }

        // Check to see if SheetContentType property is set
        internal bool IsSetSheetContentType()
        {
            return this._sheetContentType != null;
        }

    }
}