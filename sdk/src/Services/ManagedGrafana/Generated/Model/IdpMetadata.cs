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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// A structure containing the identity provider (IdP) metadata used to integrate the
    /// identity provider with this workspace. You can specify the metadata either by providing
    /// a URL to its location in the <code>url</code> parameter, or by specifying the full
    /// metadata in XML format in the <code>xml</code> parameter. Specifying both will cause
    /// an error.
    /// </summary>
    public partial class IdpMetadata
    {
        private string _url;
        private string _xml;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the location containing the IdP metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property Xml. 
        /// <para>
        /// The full IdP metadata, in XML format.
        /// </para>
        /// </summary>
        public string Xml
        {
            get { return this._xml; }
            set { this._xml = value; }
        }

        // Check to see if Xml property is set
        internal bool IsSetXml()
        {
            return this._xml != null;
        }

    }
}