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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a parameter used to provision a product.
    /// </summary>
    public partial class ProvisioningArtifactParameter
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value.
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
        /// The description of the parameter.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsNoEcho. 
        /// <para>
        /// If this value is true, the value for this parameter is obfuscated from view when the
        /// parameter is retrieved. This parameter is used to hide sensitive information.
        /// </para>
        /// </summary>
        public bool? IsNoEcho { get; set; }

        /// <summary>
        /// Checks to see if the IsNoEcho property is set.
        /// </summary>
        internal bool IsSetIsNoEcho() => this.IsNoEcho.HasValue;

        /// <summary>
        /// Gets and sets the property ParameterConstraints. 
        /// <para>
        /// Constraints that the administrator has put on a parameter.
        /// </para>
        /// </summary>
        public ParameterConstraints ParameterConstraints { get; set; }

        /// <summary>
        /// Checks to see if the ParameterConstraints property is set.
        /// </summary>
        internal bool IsSetParameterConstraints() => this.ParameterConstraints != null;

        /// <summary>
        /// Gets and sets the property ParameterKey. 
        /// <para>
        /// The parameter key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string ParameterKey { get; set; }

        /// <summary>
        /// Checks to see if the ParameterKey property is set.
        /// </summary>
        internal bool IsSetParameterKey() => this.ParameterKey != null;

        /// <summary>
        /// Gets and sets the property ParameterType. 
        /// <para>
        /// The parameter type.
        /// </para>
        /// </summary>
        public string ParameterType { get; set; }

        /// <summary>
        /// Checks to see if the ParameterType property is set.
        /// </summary>
        internal bool IsSetParameterType() => this.ParameterType != null;
    }
}
