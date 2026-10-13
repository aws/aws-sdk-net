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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the parameters in the config file of the dynamic transform.
    /// </summary>
    public partial class TransformConfigParameter
    {
        /// <summary>
        /// Gets and sets the property IsOptional. 
        /// <para>
        /// Specifies whether the parameter is optional or not in the config file of the dynamic
        /// transform.
        /// </para>
        /// </summary>
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Checks to see if the IsOptional property is set.
        /// </summary>
        internal bool IsSetIsOptional() => this.IsOptional.HasValue;

        /// <summary>
        /// Gets and sets the property ListType. 
        /// <para>
        /// Specifies the list type of the parameter in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public ParamType ListType { get; set; }

        /// <summary>
        /// Checks to see if the ListType property is set.
        /// </summary>
        internal bool IsSetListType() => this.ListType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the parameter in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the parameter type in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParamType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidationMessage. 
        /// <para>
        /// Specifies the validation message in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public string ValidationMessage { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMessage property is set.
        /// </summary>
        internal bool IsSetValidationMessage() => this.ValidationMessage != null;

        /// <summary>
        /// Gets and sets the property ValidationRule. 
        /// <para>
        /// Specifies the validation rule in the config file of the dynamic transform.
        /// </para>
        /// </summary>
        public string ValidationRule { get; set; }

        /// <summary>
        /// Checks to see if the ValidationRule property is set.
        /// </summary>
        internal bool IsSetValidationRule() => this.ValidationRule != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies the value of the parameter in the config file of the dynamic transform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Value { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null && (this.Value.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
