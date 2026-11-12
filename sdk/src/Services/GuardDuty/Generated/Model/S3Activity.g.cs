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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about Amazon S3 activity.
    /// </summary>
    public partial class S3Activity
    {
        /// <summary>
        /// Gets and sets the property ActivityWindow. 
        /// <para>
        /// The time range of the activity.
        /// </para>
        /// </summary>
        public ActivityWindow ActivityWindow { get; set; }

        /// <summary>
        /// Checks to see if the ActivityWindow property is set.
        /// </summary>
        internal bool IsSetActivityWindow() => this.ActivityWindow != null;

        /// <summary>
        /// Gets and sets the property Actor. 
        /// <para>
        /// The identity that performed the activity.
        /// </para>
        /// </summary>
        public InvestigationActor Actor { get; set; }

        /// <summary>
        /// Checks to see if the Actor property is set.
        /// </summary>
        internal bool IsSetActor() => this.Actor != null;

        /// <summary>
        /// Gets and sets the property AffectedBucket. 
        /// <para>
        /// The name of the affected bucket, or <c>account-wide</c> if the activity isn't limited
        /// to one bucket.
        /// </para>
        /// </summary>
        public string AffectedBucket { get; set; }

        /// <summary>
        /// Checks to see if the AffectedBucket property is set.
        /// </summary>
        internal bool IsSetAffectedBucket() => this.AffectedBucket != null;

        /// <summary>
        /// Gets and sets the property Api. 
        /// <para>
        /// The Amazon S3 API operation that was called.
        /// </para>
        /// </summary>
        public string Api { get; set; }

        /// <summary>
        /// Checks to see if the Api property is set.
        /// </summary>
        internal bool IsSetApi() => this.Api != null;

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// Additional context about the activity, such as geolocation information.
        /// </para>
        /// </summary>
        public Enrichment Enrichment { get; set; }

        /// <summary>
        /// Checks to see if the Enrichment property is set.
        /// </summary>
        internal bool IsSetEnrichment() => this.Enrichment != null;

        /// <summary>
        /// Gets and sets the property EventCount. 
        /// <para>
        /// The number of events.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? EventCount { get; set; }

        /// <summary>
        /// Checks to see if the EventCount property is set.
        /// </summary>
        internal bool IsSetEventCount() => this.EventCount.HasValue;

        /// <summary>
        /// Gets and sets the property NonS3Activity. 
        /// <para>
        /// Related activity on Amazon Web Services services other than Amazon S3.
        /// </para>
        /// </summary>
        public string NonS3Activity { get; set; }

        /// <summary>
        /// Checks to see if the NonS3Activity property is set.
        /// </summary>
        internal bool IsSetNonS3Activity() => this.NonS3Activity != null;

        /// <summary>
        /// Gets and sets the property OtherS3Activity. 
        /// <para>
        /// Other Amazon S3 activity that is related to the observation.
        /// </para>
        /// </summary>
        public string OtherS3Activity { get; set; }

        /// <summary>
        /// Checks to see if the OtherS3Activity property is set.
        /// </summary>
        internal bool IsSetOtherS3Activity() => this.OtherS3Activity != null;

        /// <summary>
        /// Gets and sets the property SessionAssessment. 
        /// <para>
        /// An assessment of the session in which the activity occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string SessionAssessment { get; set; }

        /// <summary>
        /// Checks to see if the SessionAssessment property is set.
        /// </summary>
        internal bool IsSetSessionAssessment() => this.SessionAssessment != null;

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The source address of the activity, or a description of the source.
        /// </para>
        /// </summary>
        public string SourceIp { get; set; }

        /// <summary>
        /// Checks to see if the SourceIp property is set.
        /// </summary>
        internal bool IsSetSourceIp() => this.SourceIp != null;
    }
}
