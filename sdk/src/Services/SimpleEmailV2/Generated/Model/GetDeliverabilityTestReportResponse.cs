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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
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
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DeliverabilityTestReport. 
        /// <para>
        /// An object that contains the results of the predictive inbox placement test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of objects that define the tags (keys and values) that are associated with
        /// the predictive inbox placement test.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}