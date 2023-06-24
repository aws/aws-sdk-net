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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The name and version of the service dependant on the requested service.
    /// </summary>
    public partial class DependentService
    {
        private ServiceName _serviceName;
        private ServiceVersion _serviceVersion;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the dependent service.
        /// </para>
        /// </summary>
        public ServiceName ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceVersion. 
        /// <para>
        /// The version of the dependent service.
        /// </para>
        /// </summary>
        public ServiceVersion ServiceVersion
        {
            get { return this._serviceVersion; }
            set { this._serviceVersion = value; }
        }

        // Check to see if ServiceVersion property is set
        internal bool IsSetServiceVersion()
        {
            return this._serviceVersion != null;
        }

    }
}