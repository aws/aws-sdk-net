/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The parameter key/value pair used to update a ProvisionedProduct object. If <code>UsePreviousValue</code>
    /// is set to true, <code>Value</code> is ignored and the value for <code>Key</code> is
    /// kept as previously set (current value).
    /// </summary>
    public partial class UpdateProvisioningParameter
    {
        private string _key;
        private bool? _usePreviousValue;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The <code>ProvisioningArtifactParameter.ParameterKey</code> parameter from <a>DescribeProvisioningParameters</a>.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property UsePreviousValue. 
        /// <para>
        /// If true, uses the currently set value for <code>Key</code>, ignoring <code>UpdateProvisioningParameter.Value</code>.
        /// </para>
        /// </summary>
        public bool UsePreviousValue
        {
            get { return this._usePreviousValue.GetValueOrDefault(); }
            set { this._usePreviousValue = value; }
        }

        // Check to see if UsePreviousValue property is set
        internal bool IsSetUsePreviousValue()
        {
            return this._usePreviousValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to use for updating the product provisioning. Any constraints on this value
        /// can be found in the <code>ProvisioningArtifactParameter</code> parameter for <code>Key</code>.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}