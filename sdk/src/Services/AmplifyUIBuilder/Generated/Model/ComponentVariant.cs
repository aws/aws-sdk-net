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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the style configuration of a unique variation of a main component.
    /// </summary>
    public partial class ComponentVariant
    {
        private Dictionary<string, Dictionary<string, string>> _overrides = new Dictionary<string, Dictionary<string, string>>();
        private Dictionary<string, string> _variantValues = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// The properties of the component variant that can be overriden when customizing an
        /// instance of the component. You can't specify <code>tags</code> as a valid property
        /// for <code>overrides</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && this._overrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VariantValues. 
        /// <para>
        /// The combination of variants that comprise this variant. You can't specify <code>tags</code>
        /// as a valid property for <code>variantValues</code>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> VariantValues
        {
            get { return this._variantValues; }
            set { this._variantValues = value; }
        }

        // Check to see if VariantValues property is set
        internal bool IsSetVariantValues()
        {
            return this._variantValues != null && this._variantValues.Count > 0; 
        }

    }
}