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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The additional attributes of an inventory asset.
    /// </summary>
    public partial class AssetItemAdditionalAttributes
    {
        private List<FormOutput> _formsOutput = new List<FormOutput>();
        private List<FormOutput> _readOnlyFormsOutput = new List<FormOutput>();

        /// <summary>
        /// Gets and sets the property FormsOutput. 
        /// <para>
        /// The forms included in the additional attributes of an inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<FormOutput> FormsOutput
        {
            get { return this._formsOutput; }
            set { this._formsOutput = value; }
        }

        // Check to see if FormsOutput property is set
        internal bool IsSetFormsOutput()
        {
            return this._formsOutput != null && this._formsOutput.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnlyFormsOutput. 
        /// <para>
        /// The read-only forms included in the additional attributes of an inventory asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<FormOutput> ReadOnlyFormsOutput
        {
            get { return this._readOnlyFormsOutput; }
            set { this._readOnlyFormsOutput = value; }
        }

        // Check to see if ReadOnlyFormsOutput property is set
        internal bool IsSetReadOnlyFormsOutput()
        {
            return this._readOnlyFormsOutput != null && this._readOnlyFormsOutput.Count > 0; 
        }

    }
}