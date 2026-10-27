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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes an individual assessment from a premigration assessment
    /// run.
    /// </summary>
    public partial class ReplicationTaskIndividualAssessment
    {
        /// <summary>
        /// Gets and sets the property IndividualAssessmentName. 
        /// <para>
        /// Name of this individual assessment.
        /// </para>
        /// </summary>
        public string IndividualAssessmentName { get; set; }

        /// <summary>
        /// Checks to see if the IndividualAssessmentName property is set.
        /// </summary>
        internal bool IsSetIndividualAssessmentName() => this.IndividualAssessmentName != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskAssessmentRunArn. 
        /// <para>
        /// ARN of the premigration assessment run that is created to run this individual assessment.
        /// </para>
        /// </summary>
        public string ReplicationTaskAssessmentRunArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskAssessmentRunArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskAssessmentRunArn() => this.ReplicationTaskAssessmentRunArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIndividualAssessmentArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of this individual assessment.
        /// </para>
        /// </summary>
        public string ReplicationTaskIndividualAssessmentArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIndividualAssessmentArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIndividualAssessmentArn() => this.ReplicationTaskIndividualAssessmentArn != null;

        /// <summary>
        /// Gets and sets the property ReplicationTaskIndividualAssessmentStartDate. 
        /// <para>
        /// Date when this individual assessment was started as part of running the <c>StartReplicationTaskAssessmentRun</c>
        /// operation.
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskIndividualAssessmentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskIndividualAssessmentStartDate property is set.
        /// </summary>
        internal bool IsSetReplicationTaskIndividualAssessmentStartDate() => this.ReplicationTaskIndividualAssessmentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Individual assessment status.
        /// </para>
        ///  
        /// <para>
        /// This status can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"cancelled"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"error"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"passed"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"pending"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"skipped"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"running"</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
