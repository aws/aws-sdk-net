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

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A configuration property of an SDK type.
    /// </summary>
    public partial class SdkConfigurationProperty
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of an SdkType configuration property.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of an SdkType configuration property.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FriendlyName. 
        /// <para>
        /// The user-friendly name of an SdkType configuration property.
        /// </para>
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Checks to see if the FriendlyName property is set.
        /// </summary>
        internal bool IsSetFriendlyName() => this.FriendlyName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a an SdkType configuration property.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// A boolean flag of an SdkType configuration property to indicate if the associated
        /// SDK configuration property is required (<c>true</c>) or not (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;
    }
}
