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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AdvancedEventSelector
    {
        private List<AdvancedFieldSelector> _fieldSelectors = new List<AdvancedFieldSelector>();
        private string _name;

        /// <summary>
        /// Gets and sets the property FieldSelectors.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AdvancedFieldSelector> FieldSelectors
        {
            get { return this._fieldSelectors; }
            set { this._fieldSelectors = value; }
        }

        // Check to see if FieldSelectors property is set
        internal bool IsSetFieldSelectors()
        {
            return this._fieldSelectors != null && this._fieldSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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

    }
}