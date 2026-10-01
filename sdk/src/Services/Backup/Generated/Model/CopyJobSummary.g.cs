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
    /// This is a summary of copy jobs created or running within the most recent 14 days.
    /// 
    ///  
    /// <para>
    /// The returned summary may contain the following: Region, Account, State, RestourceType,
    /// MessageCategory, StartTime, EndTime, and Count of included jobs.
    /// </para>
    /// </summary>
    public partial class CopyJobSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the jobs within the summary.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The value as a number of jobs in a job summary.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The value of time in number format of a job end time.
        /// </para>
        ///  
        /// <para>
        /// This value is the time in Unix format, Coordinated Universal Time (UTC), and accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MessageCategory. 
        /// <para>
        /// This parameter is the job count for the specified message category.
        /// </para>
        ///  
        /// <para>
        /// Example strings include <c>AccessDenied</c>, <c>Success</c>, and <c>InvalidParameters</c>.
        /// See <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// for a list of MessageCategory strings.
        /// </para>
        ///  
        /// <para>
        /// The the value ANY returns count of all message categories.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all message categories and returns
        /// the sum.
        /// </para>
        /// </summary>
        public string MessageCategory { get; set; }

        /// <summary>
        /// Checks to see if the MessageCategory property is set.
        /// </summary>
        internal bool IsSetMessageCategory() => this.MessageCategory != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Regions within the job summary.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// This value is the job count for the specified resource type. The request <c>GetSupportedResourceTypes</c>
        /// returns strings for supported resource types
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The value of time in number format of a job start time.
        /// </para>
        ///  
        /// <para>
        /// This value is the time in Unix format, Coordinated Universal Time (UTC), and accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// This value is job count for jobs with the specified state.
        /// </para>
        /// </summary>
        public CopyJobStatus State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
