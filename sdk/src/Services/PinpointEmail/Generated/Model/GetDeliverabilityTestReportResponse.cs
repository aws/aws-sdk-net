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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// The results of the predictive inbox placement test.
    /// </summary>
    public partial class GetDeliverabilityTestReportResponse : AmazonWebServiceResponse
    {
        private DeliverabilityTestReport _deliverabilityTestReport;
        private List<IspPlacement> _ispPlacements = new List<IspPlacement>();
        private string _message;
        private PlacementStatistics _overallPlacement;

        /// <summary>
        /// Gets and sets the property DeliverabilityTestReport. 
        /// <para>
        /// An object that contains the results of the predictive inbox placement test.
        /// </para>
        /// </summary>
        public DeliverabilityTestReport DeliverabilityTestReport
        {
            get { return this._deliverabilityTestReport; }
            set { this._deliverabilityTestReport = value; }
        }

        // Check to see if DeliverabilityTestReport property is set
        internal bool IsSetDeliverabilityTestReport()
        {
            return this._deliverabilityTestReport != null;
        }

        /// <summary>
        /// Gets and sets the property IspPlacements. 
        /// <para>
        /// An object that describes how the test email was handled by several email providers,
        /// including Gmail, Hotmail, Yahoo, AOL, and others.
        /// </para>
        /// </summary>
        public List<IspPlacement> IspPlacements
        {
            get { return this._ispPlacements; }
            set { this._ispPlacements = value; }
        }

        // Check to see if IspPlacements property is set
        internal bool IsSetIspPlacements()
        {
            return this._ispPlacements != null && this._ispPlacements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An object that contains the message that you sent when you performed this predictive
        /// inbox placement test.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OverallPlacement. 
        /// <para>
        /// An object that specifies how many test messages that were sent during the predictive
        /// inbox placement test were delivered to recipients' inboxes, how many were sent to
        /// recipients' spam folders, and how many weren't delivered.
        /// </para>
        /// </summary>
        public PlacementStatistics OverallPlacement
        {
            get { return this._overallPlacement; }
            set { this._overallPlacement = value; }
        }

        // Check to see if OverallPlacement property is set
        internal bool IsSetOverallPlacement()
        {
            return this._overallPlacement != null;
        }

    }
}