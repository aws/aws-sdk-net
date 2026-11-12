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
    /// Contains an analysis of Amazon S3 activity or exposure. The members that can be set
    /// depend on <c>AnalysisType</c>: <c>S3_EXPOSURE</c> (<c>FindingSubtype</c>, <c>EffectivePermission</c>,
    /// <c>BlockPublicAccessSettings</c>, and <c>Exposure</c>), <c>S3_ACTOR_CONTEXT</c> (<c>UserAgent</c>,
    /// <c>UserAgentClassification</c>, <c>SourceIp</c>, <c>IpReputation</c>, and <c>ActorAssessment</c>),
    /// and <c>S3_PEN_TEST</c> (<c>UserAgent</c>, <c>S3ApiActivity</c>, <c>SourceContext</c>,
    /// and <c>AuthorizationAssessment</c>).
    /// </summary>
    public partial class S3Analysis
    {
        /// <summary>
        /// Gets and sets the property ActorAssessment. 
        /// <para>
        /// An assessment of the identity that performed the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string ActorAssessment { get; set; }

        /// <summary>
        /// Checks to see if the ActorAssessment property is set.
        /// </summary>
        internal bool IsSetActorAssessment() => this.ActorAssessment != null;

        /// <summary>
        /// Gets and sets the property AuthorizationAssessment. 
        /// <para>
        /// An assessment of whether the activity was authorized.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string AuthorizationAssessment { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationAssessment property is set.
        /// </summary>
        internal bool IsSetAuthorizationAssessment() => this.AuthorizationAssessment != null;

        /// <summary>
        /// Gets and sets the property BlockPublicAccessSettings. 
        /// <para>
        /// A description of the Amazon S3 Block Public Access settings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string BlockPublicAccessSettings { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAccessSettings property is set.
        /// </summary>
        internal bool IsSetBlockPublicAccessSettings() => this.BlockPublicAccessSettings != null;

        /// <summary>
        /// Gets and sets the property EffectivePermission. 
        /// <para>
        /// The effective permission of the Amazon S3 resource.
        /// </para>
        /// </summary>
        public string EffectivePermission { get; set; }

        /// <summary>
        /// Checks to see if the EffectivePermission property is set.
        /// </summary>
        internal bool IsSetEffectivePermission() => this.EffectivePermission != null;

        /// <summary>
        /// Gets and sets the property Exposure. 
        /// <para>
        /// An assessment of the exposure of the Amazon S3 resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Exposure { get; set; }

        /// <summary>
        /// Checks to see if the Exposure property is set.
        /// </summary>
        internal bool IsSetExposure() => this.Exposure != null;

        /// <summary>
        /// Gets and sets the property FindingSubtype. 
        /// <para>
        /// The subtype of the finding.
        /// </para>
        /// </summary>
        public string FindingSubtype { get; set; }

        /// <summary>
        /// Checks to see if the FindingSubtype property is set.
        /// </summary>
        internal bool IsSetFindingSubtype() => this.FindingSubtype != null;

        /// <summary>
        /// Gets and sets the property IpReputation. 
        /// <para>
        /// The reputation of the source IP address.
        /// </para>
        /// </summary>
        public string IpReputation { get; set; }

        /// <summary>
        /// Checks to see if the IpReputation property is set.
        /// </summary>
        internal bool IsSetIpReputation() => this.IpReputation != null;

        /// <summary>
        /// Gets and sets the property S3ApiActivity. 
        /// <para>
        /// A description of the Amazon S3 API activity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string S3ApiActivity { get; set; }

        /// <summary>
        /// Checks to see if the S3ApiActivity property is set.
        /// </summary>
        internal bool IsSetS3ApiActivity() => this.S3ApiActivity != null;

        /// <summary>
        /// Gets and sets the property SourceContext. 
        /// <para>
        /// Context about the source of the activity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string SourceContext { get; set; }

        /// <summary>
        /// Checks to see if the SourceContext property is set.
        /// </summary>
        internal bool IsSetSourceContext() => this.SourceContext != null;

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

        /// <summary>
        /// Gets and sets the property UserAgent. 
        /// <para>
        /// The user agent of the caller.
        /// </para>
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Checks to see if the UserAgent property is set.
        /// </summary>
        internal bool IsSetUserAgent() => this.UserAgent != null;

        /// <summary>
        /// Gets and sets the property UserAgentClassification. 
        /// <para>
        /// The classification of the user agent.
        /// </para>
        /// </summary>
        public string UserAgentClassification { get; set; }

        /// <summary>
        /// Checks to see if the UserAgentClassification property is set.
        /// </summary>
        internal bool IsSetUserAgentClassification() => this.UserAgentClassification != null;
    }
}
