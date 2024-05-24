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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Short for uniform resource locator. A URL is used as a unique identifier to locate
    /// a resource on the internet.
    /// </summary>
    public partial class URL
    {
        private string _hyperlinkName;
        private string _link;

        /// <summary>
        /// Gets and sets the property HyperlinkName. 
        /// <para>
        ///  The name or word that's used as a hyperlink to the URL. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string HyperlinkName
        {
            get { return this._hyperlinkName; }
            set { this._hyperlinkName = value; }
        }

        // Check to see if HyperlinkName property is set
        internal bool IsSetHyperlinkName()
        {
            return this._hyperlinkName != null;
        }

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        ///  The unique identifier for the internet resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string Link
        {
            get { return this._link; }
            set { this._link = value; }
        }

        // Check to see if Link property is set
        internal bool IsSetLink()
        {
            return this._link != null;
        }

    }
}