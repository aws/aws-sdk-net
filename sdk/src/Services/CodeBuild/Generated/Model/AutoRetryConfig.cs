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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the auto-retry configuration for the build.
    /// </summary>
    public partial class AutoRetryConfig
    {
        private int? _autoRetryLimit;
        private int? _autoRetryNumber;
        private string _nextAutoRetry;
        private string _previousAutoRetry;

        /// <summary>
        /// Gets and sets the property AutoRetryLimit. 
        /// <para>
        /// The maximum number of additional automatic retries after a failed build. For example,
        /// if the auto-retry limit is set to 2, CodeBuild will call the <c>RetryBuild</c> API
        /// to automatically retry your build for up to 2 additional times.
        /// </para>
        /// </summary>
        public int? AutoRetryLimit
        {
            get { return this._autoRetryLimit; }
            set { this._autoRetryLimit = value; }
        }

        // Check to see if AutoRetryLimit property is set
        internal bool IsSetAutoRetryLimit()
        {
            return this._autoRetryLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoRetryNumber. 
        /// <para>
        /// The number of times that the build has been retried. The initial build will have an
        /// auto-retry number of 0.
        /// </para>
        /// </summary>
        public int? AutoRetryNumber
        {
            get { return this._autoRetryNumber; }
            set { this._autoRetryNumber = value; }
        }

        // Check to see if AutoRetryNumber property is set
        internal bool IsSetAutoRetryNumber()
        {
            return this._autoRetryNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextAutoRetry. 
        /// <para>
        /// The build ARN of the auto-retried build triggered by the current build. The next auto-retry
        /// will be <c>null</c> for builds that don't trigger an auto-retry.
        /// </para>
        /// </summary>
        public string NextAutoRetry
        {
            get { return this._nextAutoRetry; }
            set { this._nextAutoRetry = value; }
        }

        // Check to see if NextAutoRetry property is set
        internal bool IsSetNextAutoRetry()
        {
            return this._nextAutoRetry != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousAutoRetry. 
        /// <para>
        /// The build ARN of the build that triggered the current auto-retry build. The previous
        /// auto-retry will be <c>null</c> for the initial build.
        /// </para>
        /// </summary>
        public string PreviousAutoRetry
        {
            get { return this._previousAutoRetry; }
            set { this._previousAutoRetry = value; }
        }

        // Check to see if PreviousAutoRetry property is set
        internal bool IsSetPreviousAutoRetry()
        {
            return this._previousAutoRetry != null;
        }

    }
}