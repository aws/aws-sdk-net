/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the AddAttributesToFindings operation.
    /// Assigns attributes (key and value pair) to the findings specified by the findings'
    /// ARNs.
    /// </summary>
    public partial class AddAttributesToFindingsRequest : AmazonInspectorRequest
    {
        private List<Attribute> _attributes = new List<Attribute>();
        private List<string> _findingArns = new List<string>();

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The array of attributes that you want to assign to specified findings.
        /// </para>
        /// </summary>
        public List<Attribute> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FindingArns. 
        /// <para>
        /// The ARNs specifying the findings that you want to assign attributes to.
        /// </para>
        /// </summary>
        public List<string> FindingArns
        {
            get { return this._findingArns; }
            set { this._findingArns = value; }
        }

        // Check to see if FindingArns property is set
        internal bool IsSetFindingArns()
        {
            return this._findingArns != null && this._findingArns.Count > 0; 
        }

    }
}