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
    /// Container for the parameters to the EnableAddOn operation.
    /// Enables or modifies an add-on for an Amazon Lightsail resource. For more information,
    /// see the <a href="https://lightsail.aws.amazon.com/ls/docs/en_us/articles/amazon-lightsail-configuring-automatic-snapshots">Lightsail
    /// Dev Guide</a>.
    /// </summary>
    public partial class EnableAddOnRequest : AmazonLightsailRequest
    {
        private AddOnRequest _addOnRequest;
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property AddOnRequest. 
        /// <para>
        /// An array of strings representing the add-on to enable or modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AddOnRequest AddOnRequest
        {
            get { return this._addOnRequest; }
            set { this._addOnRequest = value; }
        }

        // Check to see if AddOnRequest property is set
        internal bool IsSetAddOnRequest()
        {
            return this._addOnRequest != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the source resource for which to enable or modify the add-on.
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