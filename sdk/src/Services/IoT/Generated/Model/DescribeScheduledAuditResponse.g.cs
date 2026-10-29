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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeScheduledAudit operation.
    /// </summary>
    public partial class DescribeScheduledAuditResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DayOfMonth. 
        /// <para>
        /// The day of the month on which the scheduled audit takes place. This is will be <c>1</c>
        /// through <c>31</c> or <c>LAST</c>. If days <c>29</c>-<c>31</c> are specified, and the
        /// month does not have that many days, the audit takes place on the <c>LAST</c> day of
        /// the month.
        /// </para>
        /// </summary>
        public string DayOfMonth { get; set; }

        /// <summary>
        /// Checks to see if the DayOfMonth property is set.
        /// </summary>
        internal bool IsSetDayOfMonth() => this.DayOfMonth != null;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week on which the scheduled audit takes place, either one of <c>SUN</c>,
        /// <c>MON</c>, <c>TUE</c>, <c>WED</c>, <c>THU</c>, <c>FRI</c>, or <c>SAT</c>.
        /// </para>
        /// </summary>
        public DayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// Checks to see if the DayOfWeek property is set.
        /// </summary>
        internal bool IsSetDayOfWeek() => this.DayOfWeek != null;

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// How often the scheduled audit takes place, either one of <c>DAILY</c>, <c>WEEKLY</c>,
        /// <c>BIWEEKLY</c>, or <c>MONTHLY</c>. The start time of each audit is determined by
        /// the system.
        /// </para>
        /// </summary>
        public AuditFrequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property ScheduledAuditArn. 
        /// <para>
        /// The ARN of the scheduled audit.
        /// </para>
        /// </summary>
        public string ScheduledAuditArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAuditArn property is set.
        /// </summary>
        internal bool IsSetScheduledAuditArn() => this.ScheduledAuditArn != null;

        /// <summary>
        /// Gets and sets the property ScheduledAuditName. 
        /// <para>
        /// The name of the scheduled audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ScheduledAuditName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledAuditName property is set.
        /// </summary>
        internal bool IsSetScheduledAuditName() => this.ScheduledAuditName != null;

        /// <summary>
        /// Gets and sets the property TargetCheckNames. 
        /// <para>
        /// Which checks are performed during the scheduled audit. Checks must be enabled for
        /// your account. (Use <c>DescribeAccountAuditConfiguration</c> to see the list of all
        /// checks, including those that are enabled or use <c>UpdateAccountAuditConfiguration</c>
        /// to select which checks are enabled.)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetCheckNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetCheckNames property is set.
        /// </summary>
        internal bool IsSetTargetCheckNames() => this.TargetCheckNames != null && (this.TargetCheckNames.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
