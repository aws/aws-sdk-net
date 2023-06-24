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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// The structure containing the asset properties.
    /// </summary>
    public partial class AssetValue
    {
        private string _href;

        /// <summary>
        /// Gets and sets the property Href. 
        /// <para>
        /// Link to the asset object.
        /// </para>
        /// </summary>
        public string Href
        {
            get { return this._href; }
            set { this._href = value; }
        }

        // Check to see if Href property is set
        internal bool IsSetHref()
        {
            return this._href != null;
        }

    }
}