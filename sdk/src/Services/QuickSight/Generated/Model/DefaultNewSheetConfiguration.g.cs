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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The configuration for default new sheet settings.
    /// </summary>
    public partial class DefaultNewSheetConfiguration
    {
        /// <summary>
        /// Gets and sets the property InteractiveLayoutConfiguration. 
        /// <para>
        /// The options that determine the default settings for interactive layout configuration.
        /// </para>
        /// </summary>
        public DefaultInteractiveLayoutConfiguration InteractiveLayoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InteractiveLayoutConfiguration property is set.
        /// </summary>
        internal bool IsSetInteractiveLayoutConfiguration() => this.InteractiveLayoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property PaginatedLayoutConfiguration. 
        /// <para>
        /// The options that determine the default settings for a paginated layout configuration.
        /// </para>
        /// </summary>
        public DefaultPaginatedLayoutConfiguration PaginatedLayoutConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PaginatedLayoutConfiguration property is set.
        /// </summary>
        internal bool IsSetPaginatedLayoutConfiguration() => this.PaginatedLayoutConfiguration != null;

        /// <summary>
        /// Gets and sets the property SheetContentType. 
        /// <para>
        /// The option that determines the sheet content type.
        /// </para>
        /// </summary>
        public SheetContentType SheetContentType { get; set; }

        /// <summary>
        /// Checks to see if the SheetContentType property is set.
        /// </summary>
        internal bool IsSetSheetContentType() => this.SheetContentType != null;
    }
}
