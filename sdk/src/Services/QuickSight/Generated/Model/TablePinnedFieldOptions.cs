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
    /// The settings for the pinned columns of a table visual.
    /// </summary>
    public partial class TablePinnedFieldOptions
    {
        private List<string> _pinnedLeftFields = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PinnedLeftFields. 
        /// <para>
        /// A list of columns to be pinned to the left of a table visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=201)]
        public List<string> PinnedLeftFields
        {
            get { return this._pinnedLeftFields; }
            set { this._pinnedLeftFields = value; }
        }

        // Check to see if PinnedLeftFields property is set
        internal bool IsSetPinnedLeftFields()
        {
            return this._pinnedLeftFields != null && (this._pinnedLeftFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}