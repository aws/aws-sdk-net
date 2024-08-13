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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// An object that filters items in a list of component types.
    /// 
    ///  <note> 
    /// <para>
    /// Only one object is accepted as a valid input.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListComponentTypesFilter
    {
        private string _extendsFrom;
        private bool? _isAbstract;
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property ExtendsFrom. 
        /// <para>
        /// The component type that the component types in the list extend.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ExtendsFrom
        {
            get { return this._extendsFrom; }
            set { this._extendsFrom = value; }
        }

        // Check to see if ExtendsFrom property is set
        internal bool IsSetExtendsFrom()
        {
            return this._extendsFrom != null;
        }

        /// <summary>
        /// Gets and sets the property IsAbstract. 
        /// <para>
        /// A Boolean value that specifies whether the component types in the list are abstract.
        /// </para>
        /// </summary>
        public bool? IsAbstract
        {
            get { return this._isAbstract; }
            set { this._isAbstract = value; }
        }

        // Check to see if IsAbstract property is set
        internal bool IsSetIsAbstract()
        {
            return this._isAbstract.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to which the component types in the list belong.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

    }
}