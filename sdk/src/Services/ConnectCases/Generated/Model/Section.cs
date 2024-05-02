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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This represents a sections within a panel or tab of the page layout.
    /// </summary>
    public partial class Section
    {
        private FieldGroup _fieldGroup;

        /// <summary>
        /// Gets and sets the property FieldGroup. 
        /// <para>
        /// Consists of a group of fields and associated properties.
        /// </para>
        /// </summary>
        public FieldGroup FieldGroup
        {
            get { return this._fieldGroup; }
            set { this._fieldGroup = value; }
        }

        // Check to see if FieldGroup property is set
        internal bool IsSetFieldGroup()
        {
            return this._fieldGroup != null;
        }

    }
}