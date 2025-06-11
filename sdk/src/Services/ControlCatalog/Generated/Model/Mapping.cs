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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
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
namespace Amazon.ControlCatalog.Model
{
    /// <summary>
    /// A structure that contains the details of a mapping relationship, which can be either
    /// to a framework or to a common control.
    /// </summary>
    public partial class Mapping
    {
        private CommonControlMappingDetails _commonControl;
        private FrameworkMappingDetails _framework;

        /// <summary>
        /// Gets and sets the property CommonControl. 
        /// <para>
        /// The common control mapping details when the mapping type relates to a common control.
        /// </para>
        /// </summary>
        public CommonControlMappingDetails CommonControl
        {
            get { return this._commonControl; }
            set { this._commonControl = value; }
        }

        // Check to see if CommonControl property is set
        internal bool IsSetCommonControl()
        {
            return this._commonControl != null;
        }

        /// <summary>
        /// Gets and sets the property Framework. 
        /// <para>
        /// The framework mapping details when the mapping type relates to a compliance framework.
        /// </para>
        /// </summary>
        public FrameworkMappingDetails Framework
        {
            get { return this._framework; }
            set { this._framework = value; }
        }

        // Check to see if Framework property is set
        internal bool IsSetFramework()
        {
            return this._framework != null;
        }

    }
}