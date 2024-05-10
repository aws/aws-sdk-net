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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private string _arn;
        private double? _billingMinutes;
        private DateTime? _created;
        private DateTime? _ended;
        private string _seleniumProperties;
        private TestGridSessionStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingMinutes. 
        /// <para>
        /// The number of billed minutes that were used for this session. 
        /// </para>
        /// </summary>
        public double? BillingMinutes
        {
            get { return this._billingMinutes; }
            set { this._billingMinutes = value; }
        }

        // Check to see if BillingMinutes property is set
        internal bool IsSetBillingMinutes()
        {
            return this._billingMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The time that the session was started.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ended. 
        /// <para>
        /// The time the session ended.
        /// </para>
        /// </summary>
        public DateTime? Ended
        {
            get { return this._ended; }
            set { this._ended = value; }
        }

        // Check to see if Ended property is set
        internal bool IsSetEnded()
        {
            return this._ended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeleniumProperties. 
        /// <para>
        /// A JSON object of options and parameters passed to the Selenium WebDriver.
        /// </para>
        /// </summary>
        public string SeleniumProperties
        {
            get { return this._seleniumProperties; }
            set { this._seleniumProperties = value; }
        }

        // Check to see if SeleniumProperties property is set
        internal bool IsSetSeleniumProperties()
        {
            return this._seleniumProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the session.
        /// </para>
        /// </summary>
        public TestGridSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}