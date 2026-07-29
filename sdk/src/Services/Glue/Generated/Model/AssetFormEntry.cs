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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// A form on an asset, consisting of the form type identifier and its JSON content.
    /// </summary>
    public partial class AssetFormEntry
    {
        private string _content;
        private string _formTypeId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON content of the form, conforming to the schema of the specified form type.
        /// </para>
        /// </summary>
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property FormTypeId. 
        /// <para>
        /// The identifier of the form type that defines this form's schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FormTypeId
        {
            get { return this._formTypeId; }
            set { this._formTypeId = value; }
        }

        // Check to see if FormTypeId property is set
        internal bool IsSetFormTypeId()
        {
            return this._formTypeId != null;
        }

    }
}