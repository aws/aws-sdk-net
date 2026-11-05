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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains information about the module from which the resource was created, if the
    /// resource was created from a module included in the stack template.
    /// 
    ///  
    /// <para>
    /// For more information about modules, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/modules.html">Create
    /// reusable resource configurations that can be included across templates with CloudFormation
    /// modules</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModuleInfo
    {
        /// <summary>
        /// Gets and sets the property LogicalIdHierarchy. 
        /// <para>
        /// A concatenated list of the logical IDs of the module or modules that contains the
        /// resource. Modules are listed starting with the inner-most nested module, and separated
        /// by <c>/</c>.
        /// </para>
        ///  
        /// <para>
        /// In the following example, the resource was created from a module, <c>moduleA</c>,
        /// that's nested inside a parent module, <c>moduleB</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>moduleA/moduleB</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/module-ref-resources.html">Reference
        /// module resources in CloudFormation templates</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string LogicalIdHierarchy { get; set; }

        /// <summary>
        /// Checks to see if the LogicalIdHierarchy property is set.
        /// </summary>
        internal bool IsSetLogicalIdHierarchy() => this.LogicalIdHierarchy != null;

        /// <summary>
        /// Gets and sets the property TypeHierarchy. 
        /// <para>
        /// A concatenated list of the module type or types that contains the resource. Module
        /// types are listed starting with the inner-most nested module, and separated by <c>/</c>.
        /// </para>
        ///  
        /// <para>
        /// In the following example, the resource was created from a module of type <c>AWS::First::Example::MODULE</c>,
        /// that's nested inside a parent module of type <c>AWS::Second::Example::MODULE</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS::First::Example::MODULE/AWS::Second::Example::MODULE</c> 
        /// </para>
        /// </summary>
        public string TypeHierarchy { get; set; }

        /// <summary>
        /// Checks to see if the TypeHierarchy property is set.
        /// </summary>
        internal bool IsSetTypeHierarchy() => this.TypeHierarchy != null;
    }
}
