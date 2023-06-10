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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An Amazon Web Services Systems Manager parameter in Parameter Store.
    /// </summary>
    public partial class Parameter
    {
        private string _arn;
        private string _dataType;
        private DateTime? _lastModifiedDate;
        private string _name;
        private string _selector;
        private string _sourceResult;
        private ParameterType _type;
        private string _value;
        private long? _version;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parameter.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the parameter, such as <code>text</code> or <code>aws:ec2:image</code>.
        /// The default is <code>text</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// Date the parameter was last changed or updated and the parameter version was created.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        [AWSProperty(Min=0, Max=128)]
        public string Selector
        {
            get { return this._selector; }
            set { this._selector = value; }
        }

        // Check to see if Selector property is set
        internal bool IsSetSelector()
        {
            return this._selector != null;
        }

        /// <summary>
        /// Gets and sets the property SourceResult. 
        /// <para>
        /// Applies to parameters that reference information in other Amazon Web Services services.
        /// <code>SourceResult</code> is the raw result or response from the source.
        /// </para>
        /// </summary>
        public string SourceResult
        {
            get { return this._sourceResult; }
            set { this._sourceResult = value; }
        }

        // Check to see if SourceResult property is set
        internal bool IsSetSourceResult()
        {
            return this._sourceResult != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of parameter. Valid values include the following: <code>String</code>, <code>StringList</code>,
        /// and <code>SecureString</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If type is <code>StringList</code>, the system returns a comma-separated string with
        /// no spaces between commas in the <code>Value</code> field.
        /// </para>
        ///  </note>
        /// </summary>
        public ParameterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The parameter value.
        /// </para>
        ///  <note> 
        /// <para>
        /// If type is <code>StringList</code>, the system returns a comma-separated string with
        /// no spaces between commas in the <code>Value</code> field.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The parameter version.
        /// </para>
        /// </summary>
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}