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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object representing the method header to be matched.
    /// </summary>
    public partial class GrpcMetadataMatchMethod
    {
        /// <summary>
        /// Gets and sets the property Exact. 
        /// <para>
        /// The exact method header to be matched on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Exact { get; set; }

        /// <summary>
        /// Checks to see if the Exact property is set.
        /// </summary>
        internal bool IsSetExact() => this.Exact != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The specified beginning characters of the method header to be matched on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property Range.
        /// </summary>
        public MatchRange Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property Regex. 
        /// <para>
        /// The regex used to match the method header.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Regex { get; set; }

        /// <summary>
        /// Checks to see if the Regex property is set.
        /// </summary>
        internal bool IsSetRegex() => this.Regex != null;

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// The specified ending characters of the method header to match on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Suffix { get; set; }

        /// <summary>
        /// Checks to see if the Suffix property is set.
        /// </summary>
        internal bool IsSetSuffix() => this.Suffix != null;
    }
}
