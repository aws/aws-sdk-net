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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains text content to which the SiteWise Assistant refers to, and generate the
    /// final response. It also contains information about the source.
    /// </summary>
    public partial class Citation
    {
        private Content _content;
        private Reference _reference;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains the cited text from the data source.
        /// </para>
        /// </summary>
        public Content Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// Contains information about the data source.
        /// </para>
        /// </summary>
        public Reference Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

    }
}