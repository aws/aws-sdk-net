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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>Export</c> structure describes the exported output values for a stack.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/using-cfn-stack-exports.html">Get
    /// exported outputs from a deployed CloudFormation stack</a>.
    /// </para>
    /// </summary>
    public partial class Export
    {
        private string _exportingStackId;
        private string _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property ExportingStackId. 
        /// <para>
        /// The stack that contains the exported output name and value.
        /// </para>
        /// </summary>
        public string ExportingStackId
        {
            get { return this._exportingStackId; }
            set { this._exportingStackId = value; }
        }

        // Check to see if ExportingStackId property is set
        internal bool IsSetExportingStackId()
        {
            return this._exportingStackId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of exported output value. Use this name and the <c>Fn::ImportValue</c> function
        /// to import the associated value into other stacks. The name is defined in the <c>Export</c>
        /// field in the associated stack's <c>Outputs</c> section.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the exported output, such as a resource physical ID. This value is defined
        /// in the <c>Export</c> field in the associated stack's <c>Outputs</c> section.
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