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

namespace Amazon.ServerlessApplicationRepository.Model
{
    /// <summary>
    /// Parameters supported by the application.
    /// </summary>
    public partial class ParameterDefinition
    {
        /// <summary>
        /// Gets and sets the property AllowedPattern. 
        /// <para>
        /// A regular expression that represents the patterns to allow for String types.
        /// </para>
        /// </summary>
        public string AllowedPattern { get; set; }

        /// <summary>
        /// Checks to see if the AllowedPattern property is set.
        /// </summary>
        internal bool IsSetAllowedPattern() => this.AllowedPattern != null;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// An array containing the list of values allowed for the parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null && (this.AllowedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConstraintDescription. 
        /// <para>
        /// A string that explains a constraint when the constraint is violated. For example,
        /// without a constraint description, a parameter that has an allowed pattern of [A-Za-z0-9]+
        /// displays the following error message when the user specifies an invalid value:
        /// </para>
        /// 
        /// <para>
        ///  Malformed input-Parameter MyParameter must match pattern [A-Za-z0-9]+ 
        /// </para>
        /// 
        /// <para>
        /// By adding a constraint description, such as "must contain only uppercase and lowercase
        /// letters and numbers," you can display the following customized error message:
        /// </para>
        /// 
        /// <para>
        ///  Malformed input-Parameter MyParameter must contain only uppercase and lowercase letters
        /// and numbers. 
        /// </para>
        /// </summary>
        public string ConstraintDescription { get; set; }

        /// <summary>
        /// Checks to see if the ConstraintDescription property is set.
        /// </summary>
        internal bool IsSetConstraintDescription() => this.ConstraintDescription != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// A value of the appropriate type for the template to use if no value is specified when
        /// a stack is created. If you define constraints for the parameter, you must specify
        /// a value that adheres to those constraints.
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
        /// A string of up to 4,000 characters that describes the parameter.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// An integer value that determines the largest number of characters that you want to
        /// allow for String types.
        /// </para>
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// A numeric value that determines the largest numeric value that you want to allow for
        /// Number types.
        /// </para>
        /// </summary>
        public int? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// An integer value that determines the smallest number of characters that you want to
        /// allow for String types.
        /// </para>
        /// </summary>
        public int? MinLength { get; set; }

        /// <summary>
        /// Checks to see if the MinLength property is set.
        /// </summary>
        internal bool IsSetMinLength() => this.MinLength.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// A numeric value that determines the smallest numeric value that you want to allow
        /// for Number types.
        /// </para>
        /// </summary>
        public int? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NoEcho. 
        /// <para>
        /// Whether to mask the parameter value whenever anyone makes a call that describes the
        /// stack. If you set the value to true, the parameter value is masked with asterisks
        /// (*****).
        /// </para>
        /// </summary>
        public bool? NoEcho { get; set; }

        /// <summary>
        /// Checks to see if the NoEcho property is set.
        /// </summary>
        internal bool IsSetNoEcho() => this.NoEcho.HasValue;

        /// <summary>
        /// Gets and sets the property ReferencedByResources. 
        /// <para>
        /// A list of AWS SAM resources that use this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> ReferencedByResources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReferencedByResources property is set.
        /// </summary>
        internal bool IsSetReferencedByResources() => this.ReferencedByResources != null && (this.ReferencedByResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the parameter.
        /// </para>
        /// 
        /// <para>
        /// Valid values: String | Number | List&lt;Number> | CommaDelimitedList 
        /// </para>
        /// 
        /// <para>
        ///  String: A literal string.
        /// </para>
        /// 
        /// <para>
        /// For example, users can specify "MyUserName".
        /// </para>
        /// 
        /// <para>
        ///  Number: An integer or float. AWS CloudFormation validates the parameter value as
        /// a number. However, when you use the parameter elsewhere in your template (for example,
        /// by using the Ref intrinsic function), the parameter value becomes a string.
        /// </para>
        /// 
        /// <para>
        /// For example, users might specify "8888".
        /// </para>
        /// 
        /// <para>
        ///  List&lt;Number>: An array of integers or floats that are separated by commas. AWS
        /// CloudFormation validates the parameter value as numbers. However, when you use the
        /// parameter elsewhere in your template (for example, by using the Ref intrinsic function),
        /// the parameter value becomes a list of strings.
        /// </para>
        /// 
        /// <para>
        /// For example, users might specify "80,20", and then Ref results in ["80","20"].
        /// </para>
        /// 
        /// <para>
        ///  CommaDelimitedList: An array of literal strings that are separated by commas. The
        /// total number of strings should be one more than the total number of commas. Also,
        /// each member string is space-trimmed.
        /// </para>
        /// 
        /// <para>
        /// For example, users might specify "test,dev,prod", and then Ref results in ["test","dev","prod"].
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
