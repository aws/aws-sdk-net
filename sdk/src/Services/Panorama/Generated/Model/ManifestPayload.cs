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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A application verion's manifest file. This is a JSON document that has a single key
    /// (<c>PayloadData</c>) where the value is an escaped string representation of the application
    /// manifest (<c>graph.json</c>). This file is located in the <c>graphs</c> folder in
    /// your application source.
    /// </summary>
    public partial class ManifestPayload
    {
        private string _payloadData;

        /// <summary>
        /// Gets and sets the property PayloadData. 
        /// <para>
        /// The application manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=51200)]
        public string PayloadData
        {
            get { return this._payloadData; }
            set { this._payloadData = value; }
        }

        // Check to see if PayloadData property is set
        internal bool IsSetPayloadData()
        {
            return this._payloadData != null;
        }

    }
}