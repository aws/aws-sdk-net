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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the UpdateReportPlan operation.
    /// </summary>
    public partial class UpdateReportPlanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a report plan is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ReportPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string ReportPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanArn property is set.
        /// </summary>
        internal bool IsSetReportPlanArn() => this.ReportPlanArn != null;

        /// <summary>
        /// Gets and sets the property ReportPlanName. 
        /// <para>
        /// The unique name of the report plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ReportPlanName { get; set; }

        /// <summary>
        /// Checks to see if the ReportPlanName property is set.
        /// </summary>
        internal bool IsSetReportPlanName() => this.ReportPlanName != null;
    }
}
