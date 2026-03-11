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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The input properties for the preloaded (Synthea) data store.
    /// </summary>
    public partial class PreloadDataConfig
    {
        private PreloadDataType _preloadDataType;

        /// <summary>
        /// Gets and sets the property PreloadDataType. 
        /// <para>
        /// The type of preloaded data. Only Synthea preloaded data is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PreloadDataType PreloadDataType
        {
            get { return this._preloadDataType; }
            set { this._preloadDataType = value; }
        }

        // Check to see if PreloadDataType property is set
        internal bool IsSetPreloadDataType()
        {
            return this._preloadDataType != null;
        }

    }
}