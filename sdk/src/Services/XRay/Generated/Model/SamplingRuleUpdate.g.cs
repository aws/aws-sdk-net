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

namespace Amazon.XRay.Model
{
    /// <summary>
    /// A document specifying changes to a sampling rule's configuration.
    /// </summary>
    public partial class SamplingRuleUpdate
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Matches attributes derived from the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FixedRate. 
        /// <para>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </para>
        /// </summary>
        public double? FixedRate { get; set; }

        /// <summary>
        /// Checks to see if the FixedRate property is set.
        /// </summary>
        internal bool IsSetFixedRate() => this.FixedRate.HasValue;

        /// <summary>
        /// Gets and sets the property HTTPMethod. 
        /// <para>
        /// Matches the HTTP method of a request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public string HTTPMethod { get; set; }

        /// <summary>
        /// Checks to see if the HTTPMethod property is set.
        /// </summary>
        internal bool IsSetHTTPMethod() => this.HTTPMethod != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// Matches the hostname from a request URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the sampling rule.
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ReservoirSize. 
        /// <para>
        /// A fixed number of matching requests to instrument per second, prior to applying the
        /// fixed rate. The reservoir is not used directly by services, but applies to all services
        /// using the rule collectively.
        /// </para>
        /// </summary>
        public int? ReservoirSize { get; set; }

        /// <summary>
        /// Checks to see if the ReservoirSize property is set.
        /// </summary>
        internal bool IsSetReservoirSize() => this.ReservoirSize.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Matches the ARN of the Amazon Web Services resource on which the service runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property RuleARN. 
        /// <para>
        /// The ARN of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        public string RuleARN { get; set; }

        /// <summary>
        /// Checks to see if the RuleARN property is set.
        /// </summary>
        internal bool IsSetRuleARN() => this.RuleARN != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property SamplingRateBoost. 
        /// <para>
        /// Specifies the multiplier applied to the base sampling rate. This boost allows you
        /// to temporarily increase sampling without changing the rule's configuration.
        /// </para>
        /// </summary>
        public SamplingRateBoost SamplingRateBoost { get; set; }

        /// <summary>
        /// Checks to see if the SamplingRateBoost property is set.
        /// </summary>
        internal bool IsSetSamplingRateBoost() => this.SamplingRateBoost != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Matches the <c>name</c> that the service uses to identify itself in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// Matches the <c>origin</c> that the service uses to identify its type in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;

        /// <summary>
        /// Gets and sets the property URLPath. 
        /// <para>
        /// Matches the path from a request URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string URLPath { get; set; }

        /// <summary>
        /// Checks to see if the URLPath property is set.
        /// </summary>
        internal bool IsSetURLPath() => this.URLPath != null;
    }
}
