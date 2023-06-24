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
    /// The URL content (text, icon) for the table link configuration.
    /// </summary>
    public partial class TableFieldLinkContentConfiguration
    {
        private TableFieldCustomIconContent _customIconContent;
        private TableFieldCustomTextContent _customTextContent;

        /// <summary>
        /// Gets and sets the property CustomIconContent. 
        /// <para>
        /// The custom icon content for the table link content configuration.
        /// </para>
        /// </summary>
        public TableFieldCustomIconContent CustomIconContent
        {
            get { return this._customIconContent; }
            set { this._customIconContent = value; }
        }

        // Check to see if CustomIconContent property is set
        internal bool IsSetCustomIconContent()
        {
            return this._customIconContent != null;
        }

        /// <summary>
        /// Gets and sets the property CustomTextContent. 
        /// <para>
        /// The custom text content (value, font configuration) for the table link content configuration.
        /// </para>
        /// </summary>
        public TableFieldCustomTextContent CustomTextContent
        {
            get { return this._customTextContent; }
            set { this._customTextContent = value; }
        }

        // Check to see if CustomTextContent property is set
        internal bool IsSetCustomTextContent()
        {
            return this._customTextContent != null;
        }

    }
}