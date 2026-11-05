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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the map field containing the patterns that need to be replaced in a
        /// managed template job document schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Example. 
        /// <para>
        /// An example illustrating a pattern that need to be replaced in a managed template job
        /// document schema.
        /// </para>
        /// </summary>
        public string Example { get; set; }

        /// <summary>
        /// Checks to see if the Example property is set.
        /// </summary>
        internal bool IsSetExample() => this.Example != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Key of the map field containing the patterns that need to be replaced in a managed
        /// template job document schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Specifies whether a pattern that needs to be replaced in a managed template job document
        /// schema is optional or required.
        /// </para>
        /// </summary>
        public bool? Optional { get; set; }

        /// <summary>
        /// Checks to see if the Optional property is set.
        /// </summary>
        internal bool IsSetOptional() => this.Optional.HasValue;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// A regular expression of the patterns that need to be replaced in a managed template
        /// job document schema.
        /// </para>
        /// </summary>
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;
    }
}
