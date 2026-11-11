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
    /// A <a>TestGridSession</a> is a single instance of a browser launched from the URL provided
    /// by a call to <a>CreateTestGridUrl</a>.
    /// </summary>
    public partial class TestGridSession
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingMinutes. 
        /// <para>
        /// The number of billed minutes that were used for this session. 
        /// </para>
        /// </summary>
        public double? BillingMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BillingMinutes property is set.
        /// </summary>
        internal bool IsSetBillingMinutes() => this.BillingMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time that the session was started.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Ended. 
        /// <para>
        /// The time the session ended.
        /// </para>
        /// </summary>
        public DateTime? Ended { get; set; }

        /// <summary>
        /// Checks to see if the Ended property is set.
        /// </summary>
        internal bool IsSetEnded() => this.Ended.HasValue;

        /// <summary>
        /// Gets and sets the property SeleniumProperties. 
        /// <para>
        /// A JSON object of options and parameters passed to the Selenium WebDriver.
        /// </para>
        /// </summary>
        public string SeleniumProperties { get; set; }

        /// <summary>
        /// Checks to see if the SeleniumProperties property is set.
        /// </summary>
        internal bool IsSetSeleniumProperties() => this.SeleniumProperties != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the session.
        /// </para>
        /// </summary>
        public TestGridSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
