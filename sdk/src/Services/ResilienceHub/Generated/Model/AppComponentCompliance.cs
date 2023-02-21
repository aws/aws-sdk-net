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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the compliance of an Application Component against the resiliency policy.
    /// </summary>
    public partial class AppComponentCompliance
    {
        private string _appComponentName;
        private Dictionary<string, DisruptionCompliance> _compliance = new Dictionary<string, DisruptionCompliance>();
        private Cost _cost;
        private string _message;
        private ResiliencyScore _resiliencyScore;
        private ComplianceStatus _status;

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// The name of the Application Component.
        /// </para>
        /// </summary>
        public string AppComponentName
        {
            get { return this._appComponentName; }
            set { this._appComponentName = value; }
        }

        // Check to see if AppComponentName property is set
        internal bool IsSetAppComponentName()
        {
            return this._appComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The compliance of the Application Component against the resiliency policy.
        /// </para>
        /// </summary>
        public Dictionary<string, DisruptionCompliance> Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null && this._compliance.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost for the application.
        /// </para>
        /// </summary>
        public Cost Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The compliance message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// The current resiliency score for the application.
        /// </para>
        /// </summary>
        public ResiliencyScore ResiliencyScore
        {
            get { return this._resiliencyScore; }
            set { this._resiliencyScore = value; }
        }

        // Check to see if ResiliencyScore property is set
        internal bool IsSetResiliencyScore()
        {
            return this._resiliencyScore != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        /// </summary>
        public ComplianceStatus Status
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