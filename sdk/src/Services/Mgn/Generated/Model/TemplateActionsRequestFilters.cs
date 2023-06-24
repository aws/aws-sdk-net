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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Template post migration custom action filters.
    /// </summary>
    public partial class TemplateActionsRequestFilters
    {
        private List<string> _actioniDs = new List<string>();

        /// <summary>
        /// Gets and sets the property ActionIDs. 
        /// <para>
        /// Action IDs to filter template post migration custom actions by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> ActionIDs
        {
            get { return this._actioniDs; }
            set { this._actioniDs = value; }
        }

        // Check to see if ActionIDs property is set
        internal bool IsSetActionIDs()
        {
            return this._actioniDs != null && this._actioniDs.Count > 0; 
        }

    }
}