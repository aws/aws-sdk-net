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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Contains information about adapters used when analyzing a document, with each adapter
    /// specified using an AdapterId and version
    /// </summary>
    public partial class AdaptersConfig
    {
        private List<Adapter> _adapters = AWSConfigs.InitializeCollections ? new List<Adapter>() : null;

        /// <summary>
        /// Gets and sets the property Adapters. 
        /// <para>
        /// A list of adapters to be used when analyzing the specified document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<Adapter> Adapters
        {
            get { return this._adapters; }
            set { this._adapters = value; }
        }

        // Check to see if Adapters property is set
        internal bool IsSetAdapters()
        {
            return this._adapters != null && (this._adapters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}