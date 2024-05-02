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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
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
namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// A key-value pair that describes a property of a pipeline object. The value is specified
    /// as either a string value (<c>StringValue</c>) or a reference to another object (<c>RefValue</c>)
    /// but not as both.
    /// </summary>
    public partial class Field
    {
        private string _key;
        private string _refValue;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The field identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property RefValue. 
        /// <para>
        /// The field value, expressed as the identifier of another object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RefValue
        {
            get { return this._refValue; }
            set { this._refValue = value; }
        }

        // Check to see if RefValue property is set
        internal bool IsSetRefValue()
        {
            return this._refValue != null;
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// The field value, expressed as a String.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}