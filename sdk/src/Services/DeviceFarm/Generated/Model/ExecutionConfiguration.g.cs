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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents configuration information about a test run, such as the execution timeout
    /// (in minutes).
    /// </summary>
    public partial class ExecutionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AccountsCleanup. 
        /// <para>
        /// True if account cleanup is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? AccountsCleanup { get; set; }

        /// <summary>
        /// Checks to see if the AccountsCleanup property is set.
        /// </summary>
        internal bool IsSetAccountsCleanup() => this.AccountsCleanup.HasValue;

        /// <summary>
        /// Gets and sets the property AppPackagesCleanup. 
        /// <para>
        /// True if app package cleanup is enabled at the beginning of the test. Otherwise, false.
        /// </para>
        /// </summary>
        public bool? AppPackagesCleanup { get; set; }

        /// <summary>
        /// Checks to see if the AppPackagesCleanup property is set.
        /// </summary>
        internal bool IsSetAppPackagesCleanup() => this.AppPackagesCleanup.HasValue;

        /// <summary>
        /// Gets and sets the property JobTimeoutMinutes. 
        /// <para>
        /// The number of minutes a test run executes before it times out.
        /// </para>
        /// </summary>
        public int? JobTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the JobTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetJobTimeoutMinutes() => this.JobTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <c>true</c>, for private devices, Device Farm does not sign your app again.
        /// For public devices, Device Farm always signs your apps again.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your apps, see <a href="http://aws.amazon.com/device-farm/faqs/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool? SkipAppResign { get; set; }

        /// <summary>
        /// Checks to see if the SkipAppResign property is set.
        /// </summary>
        internal bool IsSetSkipAppResign() => this.SkipAppResign.HasValue;

        /// <summary>
        /// Gets and sets the property VideoCapture. 
        /// <para>
        /// Set to true to enable video capture. Otherwise, set to false. The default is true.
        /// </para>
        /// </summary>
        public bool? VideoCapture { get; set; }

        /// <summary>
        /// Checks to see if the VideoCapture property is set.
        /// </summary>
        internal bool IsSetVideoCapture() => this.VideoCapture.HasValue;
    }
}
