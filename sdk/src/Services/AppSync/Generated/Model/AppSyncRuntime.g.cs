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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a runtime used by an Amazon Web Services AppSync pipeline resolver or Amazon
    /// Web Services AppSync function. Specifies the name and version of the runtime to use.
    /// Note that if a runtime is specified, code must also be specified.
    /// </summary>
    public partial class AppSyncRuntime
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <c>name</c> of the runtime to use. Currently, the only allowed value is <c>APPSYNC_JS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RuntimeVersion. 
        /// <para>
        /// The <c>version</c> of the runtime to use. Currently, the only allowed version is <c>1.0.0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RuntimeVersion { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeVersion property is set.
        /// </summary>
        internal bool IsSetRuntimeVersion() => this.RuntimeVersion != null;
    }
}
