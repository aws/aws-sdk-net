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
    /// Defines an application summary.
    /// </summary>
    public partial class AppSummary
    {
        private string _appArn;
        private AppAssessmentScheduleType _assessmentSchedule;
        private AppComplianceStatusType _complianceStatus;
        private DateTime? _creationTime;
        private string _description;
        private string _name;
        private double? _resiliencyScore;
        private AppStatusType _status;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i> guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentSchedule. 
        /// <para>
        ///  Assessment execution schedule with 'Daily' or 'Disabled' values. 
        /// </para>
        /// </summary>
        public AppAssessmentScheduleType AssessmentSchedule
        {
            get { return this._assessmentSchedule; }
            set { this._assessmentSchedule = value; }
        }

        // Check to see if AssessmentSchedule property is set
        internal bool IsSetAssessmentSchedule()
        {
            return this._assessmentSchedule != null;
        }

        /// <summary>
        /// Gets and sets the property ComplianceStatus. 
        /// <para>
        /// The current status of compliance for the resiliency policy.
        /// </para>
        /// </summary>
        public AppComplianceStatusType ComplianceStatus
        {
            get { return this._complianceStatus; }
            set { this._complianceStatus = value; }
        }

        // Check to see if ComplianceStatus property is set
        internal bool IsSetComplianceStatus()
        {
            return this._complianceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp for when the app was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for an app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// The current resiliency score for the application.
        /// </para>
        /// </summary>
        public double ResiliencyScore
        {
            get { return this._resiliencyScore.GetValueOrDefault(); }
            set { this._resiliencyScore = value; }
        }

        // Check to see if ResiliencyScore property is set
        internal bool IsSetResiliencyScore()
        {
            return this._resiliencyScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the application.
        /// </para>
        /// </summary>
        public AppStatusType Status
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