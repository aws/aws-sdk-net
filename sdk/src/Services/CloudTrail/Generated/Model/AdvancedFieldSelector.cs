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
    public partial class AdvancedFieldSelector
    {
        private List<string> _endsWith = new List<string>();
        private List<string> _equals = new List<string>();
        private string _field;
        private List<string> _notEndsWith = new List<string>();
        private List<string> _notEquals = new List<string>();
        private List<string> _notStartsWith = new List<string>();
        private List<string> _startsWith = new List<string>();

        /// <summary>
        /// Gets and sets the property EndsWith.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> EndsWith
        {
            get { return this._endsWith; }
            set { this._endsWith = value; }
        }

        // Check to see if EndsWith property is set
        internal bool IsSetEndsWith()
        {
            return this._endsWith != null && this._endsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Equals.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null && this._equals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Field.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property NotEndsWith.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEndsWith
        {
            get { return this._notEndsWith; }
            set { this._notEndsWith = value; }
        }

        // Check to see if NotEndsWith property is set
        internal bool IsSetNotEndsWith()
        {
            return this._notEndsWith != null && this._notEndsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotEquals.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotEquals
        {
            get { return this._notEquals; }
            set { this._notEquals = value; }
        }

        // Check to see if NotEquals property is set
        internal bool IsSetNotEquals()
        {
            return this._notEquals != null && this._notEquals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotStartsWith.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> NotStartsWith
        {
            get { return this._notStartsWith; }
            set { this._notStartsWith = value; }
        }

        // Check to see if NotStartsWith property is set
        internal bool IsSetNotStartsWith()
        {
            return this._notStartsWith != null && this._notStartsWith.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartsWith.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> StartsWith
        {
            get { return this._startsWith; }
            set { this._startsWith = value; }
        }

        // Check to see if StartsWith property is set
        internal bool IsSetStartsWith()
        {
            return this._startsWith != null && this._startsWith.Count > 0; 
        }

    }
}