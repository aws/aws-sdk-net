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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about the configuration of an analyzer for an Amazon Web Services
    /// organization or account.
    /// </summary>
    public partial class AnalyzerConfiguration
    {
        private InternalAccessConfiguration _internalAccess;
        private UnusedAccessConfiguration _unusedAccess;

        /// <summary>
        /// Gets and sets the property InternalAccess. 
        /// <para>
        /// Specifies the configuration of an internal access analyzer for an Amazon Web Services
        /// organization or account. This configuration determines how the analyzer evaluates
        /// access within your Amazon Web Services environment.
        /// </para>
        /// </summary>
        public InternalAccessConfiguration InternalAccess
        {
            get { return this._internalAccess; }
            set { this._internalAccess = value; }
        }

        // Check to see if InternalAccess property is set
        internal bool IsSetInternalAccess()
        {
            return this._internalAccess != null;
        }

        /// <summary>
        /// Gets and sets the property UnusedAccess. 
        /// <para>
        /// Specifies the configuration of an unused access analyzer for an Amazon Web Services
        /// organization or account.
        /// </para>
        /// </summary>
        public UnusedAccessConfiguration UnusedAccess
        {
            get { return this._unusedAccess; }
            set { this._unusedAccess = value; }
        }

        // Check to see if UnusedAccess property is set
        internal bool IsSetUnusedAccess()
        {
            return this._unusedAccess != null;
        }

    }
}