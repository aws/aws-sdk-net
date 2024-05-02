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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A map of key-value pairs containing the patterns that need to be replaced in a managed
    /// template job document schema. You can use the description of each key as a guidance
    /// to specify the inputs during runtime when creating a job.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>documentParameters</c> can only be used when creating jobs from Amazon Web Services
    /// managed templates. This parameter can't be used with custom job templates or to create
    /// jobs from them.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DocumentParameter
    {
        private string _description;
        private string _example;
        private string _key;
        private bool? _optional;
        private string _regex;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the map field containing the patterns that need to be replaced in a
        /// managed template job document schema.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Example. 
        /// <para>
        /// An example illustrating a pattern that need to be replaced in a managed template job
        /// document schema.
        /// </para>
        /// </summary>
        public string Example
        {
            get { return this._example; }
            set { this._example = value; }
        }

        // Check to see if Example property is set
        internal bool IsSetExample()
        {
            return this._example != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key of the map field containing the patterns that need to be replaced in a managed
        /// template job document schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property Optional. 
        /// <para>
        /// Specifies whether a pattern that needs to be replaced in a managed template job document
        /// schema is optional or required.
        /// </para>
        /// </summary>
        public bool? Optional
        {
            get { return this._optional; }
            set { this._optional = value; }
        }

        // Check to see if Optional property is set
        internal bool IsSetOptional()
        {
            return this._optional.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// A regular expression of the patterns that need to be replaced in a managed template
        /// job document schema.
        /// </para>
        /// </summary>
        public string Regex
        {
            get { return this._regex; }
            set { this._regex = value; }
        }

        // Check to see if Regex property is set
        internal bool IsSetRegex()
        {
            return this._regex != null;
        }

    }
}