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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ResourceValue. 
        /// <para>
        /// The value is dynamic and changes at run-time.
        /// </para>
        /// </summary>
        public ResourceValue ResourceValue { get; set; }

        /// <summary>
        /// Checks to see if the ResourceValue property is set.
        /// </summary>
        internal bool IsSetResourceValue() => this.ResourceValue != null;

        /// <summary>
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The value is static and does not change at run-time.
        /// </para>
        /// </summary>
        public StaticValue StaticValue { get; set; }

        /// <summary>
        /// Checks to see if the StaticValue property is set.
        /// </summary>
        internal bool IsSetStaticValue() => this.StaticValue != null;
    }
}
