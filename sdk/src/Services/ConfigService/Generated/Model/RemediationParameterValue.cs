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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The value is either a dynamic (resource) value or a static value. You must select
    /// either a dynamic value or a static value.
    /// </summary>
    public partial class RemediationParameterValue
    {
        private ResourceValue _resourceValue;
        private StaticValue _staticValue;

        /// <summary>
        /// Gets and sets the property ResourceValue. 
        /// <para>
        /// The value is dynamic and changes at run-time.
        /// </para>
        /// </summary>
        public ResourceValue ResourceValue
        {
            get { return this._resourceValue; }
            set { this._resourceValue = value; }
        }

        // Check to see if ResourceValue property is set
        internal bool IsSetResourceValue()
        {
            return this._resourceValue != null;
        }

        /// <summary>
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The value is static and does not change at run-time.
        /// </para>
        /// </summary>
        public StaticValue StaticValue
        {
            get { return this._staticValue; }
            set { this._staticValue = value; }
        }

        // Check to see if StaticValue property is set
        internal bool IsSetStaticValue()
        {
            return this._staticValue != null;
        }

    }
}