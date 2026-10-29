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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An Amazon Web Services Systems Manager parameter in Parameter Store.
    /// </summary>
    public partial class Parameter
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parameter.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter, such as <c>text</c> or <c>aws:ec2:image</c>. The default
        /// is <c>text</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date the parameter was last changed or updated and the parameter version was created.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Selector. 
        /// <para>
        /// Either the version number or the label used to retrieve the parameter value. Specify
        /// selectors by using one of the following formats:
        /// </para>
        ///  
        /// <para>
        /// parameter_name:version
        /// </para>
        ///  
        /// <para>
        /// parameter_name:label
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Selector { get; set; }

        /// <summary>
        /// Checks to see if the Selector property is set.
        /// </summary>
        internal bool IsSetSelector() => this.Selector != null;

        /// <summary>
        /// Gets and sets the property SourceResult. 
        /// <para>
        /// Applies to parameters that reference information in other Amazon Web Services services.
        /// <c>SourceResult</c> is the raw result or response from the source.
        /// </para>
        /// </summary>
        public string SourceResult { get; set; }

        /// <summary>
        /// Checks to see if the SourceResult property is set.
        /// </summary>
        internal bool IsSetSourceResult() => this.SourceResult != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter. Valid values include the following: <c>String</c>, <c>StringList</c>,
        /// and <c>SecureString</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If type is <c>StringList</c>, the system returns a comma-separated string with no
        /// spaces between commas in the <c>Value</c> field.
        /// </para>
        ///  </note>
        /// </summary>
        public ParameterType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The parameter value.
        /// </para>
        ///  <note> 
        /// <para>
        /// If type is <c>StringList</c>, the system returns a comma-separated string with no
        /// spaces between commas in the <c>Value</c> field.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The parameter version.
        /// </para>
        /// </summary>
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
