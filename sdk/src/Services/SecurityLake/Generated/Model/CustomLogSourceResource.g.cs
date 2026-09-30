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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Amazon Security Lake can collect logs and events from third-party custom sources.
    /// </summary>
    public partial class CustomLogSourceResource
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of a third-party custom source.
        /// </para>
        /// </summary>
        public CustomLogSourceAttributes Attributes { get; set; }

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null;

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The details of the log provider for a third-party custom source.
        /// </para>
        /// </summary>
        public CustomLogSourceProvider Provider { get; set; }

        /// <summary>
        /// Checks to see if the Provider property is set.
        /// </summary>
        internal bool IsSetProvider() => this.Provider != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name for a third-party custom source. This must be a Regionally unique value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The version for a third-party custom source. This must be a Regionally unique value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;
    }
}
