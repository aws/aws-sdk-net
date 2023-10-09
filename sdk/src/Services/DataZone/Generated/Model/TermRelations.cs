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
    /// The details of the term relations.
    /// </summary>
    public partial class TermRelations
    {
        private List<string> _classifies = new List<string>();
        private List<string> _isa = new List<string>();

        /// <summary>
        /// Gets and sets the property Classifies. 
        /// <para>
        /// The classifies of the term relations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Classifies
        {
            get { return this._classifies; }
            set { this._classifies = value; }
        }

        // Check to see if Classifies property is set
        internal bool IsSetClassifies()
        {
            return this._classifies != null && this._classifies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsA. 
        /// <para>
        /// The <code>isA</code> property of the term relations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> IsA
        {
            get { return this._isa; }
            set { this._isa = value; }
        }

        // Check to see if IsA property is set
        internal bool IsSetIsA()
        {
            return this._isa != null && this._isa.Count > 0; 
        }

    }
}