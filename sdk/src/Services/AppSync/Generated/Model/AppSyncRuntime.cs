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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes a runtime used by an Amazon Web Services AppSync pipeline resolver or Amazon
    /// Web Services AppSync function. Specifies the name and version of the runtime to use.
    /// Note that if a runtime is specified, code must also be specified.
    /// </summary>
    public partial class AppSyncRuntime
    {
        private RuntimeName _name;
        private string _runtimeVersion;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <code>name</code> of the runtime to use. Currently, the only allowed value is
        /// <code>APPSYNC_JS</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeVersion. 
        /// <para>
        /// The <code>version</code> of the runtime to use. Currently, the only allowed version
        /// is <code>1.0.0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuntimeVersion
        {
            get { return this._runtimeVersion; }
            set { this._runtimeVersion = value; }
        }

        // Check to see if RuntimeVersion property is set
        internal bool IsSetRuntimeVersion()
        {
            return this._runtimeVersion != null;
        }

    }
}