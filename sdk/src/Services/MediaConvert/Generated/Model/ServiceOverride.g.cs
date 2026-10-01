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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// A service override applied by MediaConvert to the settings that you have configured.
    /// If you see any overrides, we recommend that you contact AWS Support.
    /// </summary>
    public partial class ServiceOverride
    {
        /// <summary>
        /// Gets and sets the property Message. Details about the service override that MediaConvert
        /// has applied.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the setting that MediaConvert has applied
        /// an override to.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OverrideValue. The current value of the service override
        /// that MediaConvert has applied.
        /// </summary>
        public string OverrideValue { get; set; }

        /// <summary>
        /// Checks to see if the OverrideValue property is set.
        /// </summary>
        internal bool IsSetOverrideValue() => this.OverrideValue != null;

        /// <summary>
        /// Gets and sets the property Value. The value of the setting that you configured, prior
        /// to any overrides that MediaConvert has applied.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
