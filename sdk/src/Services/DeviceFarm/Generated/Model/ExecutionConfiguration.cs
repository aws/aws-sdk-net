/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents configuration information about a test run, such as the execution timeout
    /// (in minutes).
    /// </summary>
    public partial class ExecutionConfiguration
    {
        private bool? _accountsCleanup;
        private bool? _appPackagesCleanup;
        private int? _jobTimeoutMinutes;

        /// <summary>
        /// Gets and sets the property AccountsCleanup. 
        /// <para>
        /// True if account cleanup is enabled at the beginning of the test; otherwise, false.
        /// </para>
        /// </summary>
        public bool AccountsCleanup
        {
            get { return this._accountsCleanup.GetValueOrDefault(); }
            set { this._accountsCleanup = value; }
        }

        // Check to see if AccountsCleanup property is set
        internal bool IsSetAccountsCleanup()
        {
            return this._accountsCleanup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppPackagesCleanup. 
        /// <para>
        /// True if app package cleanup is enabled at the beginning of the test; otherwise, false.
        /// </para>
        /// </summary>
        public bool AppPackagesCleanup
        {
            get { return this._appPackagesCleanup.GetValueOrDefault(); }
            set { this._appPackagesCleanup = value; }
        }

        // Check to see if AppPackagesCleanup property is set
        internal bool IsSetAppPackagesCleanup()
        {
            return this._appPackagesCleanup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobTimeoutMinutes. 
        /// <para>
        /// The number of minutes a test run will execute before it times out.
        /// </para>
        /// </summary>
        public int JobTimeoutMinutes
        {
            get { return this._jobTimeoutMinutes.GetValueOrDefault(); }
            set { this._jobTimeoutMinutes = value; }
        }

        // Check to see if JobTimeoutMinutes property is set
        internal bool IsSetJobTimeoutMinutes()
        {
            return this._jobTimeoutMinutes.HasValue; 
        }

    }
}