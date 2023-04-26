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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGUISessionAccessDetails operation.
    /// Creates two URLs that are used to access a virtual computer’s graphical user interface
    /// (GUI) session. The primary URL initiates a web-based NICE DCV session to the virtual
    /// computer's application. The secondary URL initiates a web-based NICE DCV session to
    /// the virtual computer's operating session. 
    /// 
    ///  
    /// <para>
    /// Use <code>StartGUISession</code> to open the session.
    /// </para>
    /// </summary>
    public partial class CreateGUISessionAccessDetailsRequest : AmazonLightsailRequest
    {
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

    }
}