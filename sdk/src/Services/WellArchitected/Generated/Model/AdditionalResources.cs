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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// The choice level additional resources for a custom lens.
    /// 
    ///  
    /// <para>
    /// This field does not apply to Amazon Web Services official lenses.
    /// </para>
    /// </summary>
    public partial class AdditionalResources
    {
        private List<ChoiceContent> _content = new List<ChoiceContent>();
        private AdditionalResourceType _type;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The URLs for additional resources, either helpful resources or improvement plans,
        /// for a custom lens. Up to five additional URLs can be specified.
        /// </para>
        /// </summary>
        public List<ChoiceContent> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && this._content.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of additional resource for a custom lens.
        /// </para>
        /// </summary>
        public AdditionalResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}