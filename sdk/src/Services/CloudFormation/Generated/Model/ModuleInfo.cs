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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains information about the module from which the resource was created, if the
    /// resource was created from a module included in the stack template.
    /// 
    ///  
    /// <para>
    /// For more information on modules, see <a href="AWSCloudFormation/latest/UserGuide/modules.html">Using
    /// modules to encapsulate and reuse resource configurations</a> in the <i>CloudFormation
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModuleInfo
    {
        private string _logicalIdHierarchy;
        private string _typeHierarchy;

        /// <summary>
        /// Gets and sets the property LogicalIdHierarchy. 
        /// <para>
        /// A concantenated list of the logical IDs of the module or modules containing the resource.
        /// Modules are listed starting with the inner-most nested module, and separated by <code>/</code>.
        /// </para>
        ///  
        /// <para>
        /// In the following example, the resource was created from a module, <code>moduleA</code>,
        /// that is nested inside a parent module, <code>moduleB</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>moduleA/moduleB</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="AWSCloudFormation/latest/UserGuide/modules.html#module-ref-resources">Referencing
        /// resources in a module</a> in the <i>CloudFormation User Guide</i>.
        /// </para>
        /// </summary>
        public string LogicalIdHierarchy
        {
            get { return this._logicalIdHierarchy; }
            set { this._logicalIdHierarchy = value; }
        }

        // Check to see if LogicalIdHierarchy property is set
        internal bool IsSetLogicalIdHierarchy()
        {
            return this._logicalIdHierarchy != null;
        }

        /// <summary>
        /// Gets and sets the property TypeHierarchy. 
        /// <para>
        /// A concantenated list of the the module type or types containing the resource. Module
        /// types are listed starting with the inner-most nested module, and separated by <code>/</code>.
        /// </para>
        ///  
        /// <para>
        /// In the following example, the resource was created from a module of type <code>AWS::First::Example::MODULE</code>,
        /// that is nested inside a parent module of type <code>AWS::Second::Example::MODULE</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>AWS::First::Example::MODULE/AWS::Second::Example::MODULE</code> 
        /// </para>
        /// </summary>
        public string TypeHierarchy
        {
            get { return this._typeHierarchy; }
            set { this._typeHierarchy = value; }
        }

        // Check to see if TypeHierarchy property is set
        internal bool IsSetTypeHierarchy()
        {
            return this._typeHierarchy != null;
        }

    }
}