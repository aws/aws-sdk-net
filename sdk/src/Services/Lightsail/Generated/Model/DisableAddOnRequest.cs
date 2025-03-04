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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DisableAddOn operation.
    /// Disables an add-on for an Amazon Lightsail resource. For more information, see the
    /// <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-configuring-automatic-snapshots">Amazon
    /// Lightsail Developer Guide</a>.
    /// </summary>
    public partial class DisableAddOnRequest : AmazonLightsailRequest
    {
        private AddOnType _addOnType;
        private string _resourceName;

        /// <summary>
        /// Gets and sets the property AddOnType. 
        /// <para>
        /// The add-on type to disable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AddOnType AddOnType
        {
            get { return this._addOnType; }
            set { this._addOnType = value; }
        }

        // Check to see if AddOnType property is set
        internal bool IsSetAddOnType()
        {
            return this._addOnType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the source resource for which to disable the add-on.
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