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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains a list of load IDs.
    /// </summary>
    public partial class LoaderIdResult
    {
        private List<string> _loadIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LoadIds. 
        /// <para>
        /// A list of load IDs.
        /// </para>
        /// </summary>
        public List<string> LoadIds
        {
            get { return this._loadIds; }
            set { this._loadIds = value; }
        }

        // Check to see if LoadIds property is set
        internal bool IsSetLoadIds()
        {
            return this._loadIds != null && (this._loadIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}