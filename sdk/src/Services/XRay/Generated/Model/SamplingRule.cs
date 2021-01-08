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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.XRay.Model
{
    /// <summary>
    /// A sampling rule that services use to decide whether to instrument a request. Rule
    /// fields can match properties of the service, or properties of a request. The service
    /// can ignore rules that don't match its properties.
    /// </summary>
    public partial class SamplingRule
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private double? _fixedRate;
        private string _host;
        private string _httpMethod;
        private int? _priority;
        private int? _reservoirSize;
        private string _resourceARN;
        private string _ruleARN;
        private string _ruleName;
        private string _serviceName;
        private string _serviceType;
        private string _urlPath;
        private int? _version;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Matches attributes derived from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FixedRate. 
        /// <para>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double FixedRate
        {
            get { return this._fixedRate.GetValueOrDefault(); }
            set { this._fixedRate = value; }
        }

        // Check to see if FixedRate property is set
        internal bool IsSetFixedRate()
        {
            return this._fixedRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// Matches the hostname from a request URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string Host
        {
            get { return this._host; }
            set { this._host = value; }
        }

        // Check to see if Host property is set
        internal bool IsSetHost()
        {
            return this._host != null;
        }

        /// <summary>
        /// Gets and sets the property HTTPMethod. 
        /// <para>
        /// Matches the HTTP method of a request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=10)]
        public string HTTPMethod
        {
            get { return this._httpMethod; }
            set { this._httpMethod = value; }
        }

        // Check to see if HTTPMethod property is set
        internal bool IsSetHTTPMethod()
        {
            return this._httpMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the sampling rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=9999)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservoirSize. 
        /// <para>
        /// A fixed number of matching requests to instrument per second, prior to applying the
        /// fixed rate. The reservoir is not used directly by services, but applies to all services
        /// using the rule collectively.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int ReservoirSize
        {
            get { return this._reservoirSize.GetValueOrDefault(); }
            set { this._reservoirSize = value; }
        }

        // Check to see if ReservoirSize property is set
        internal bool IsSetReservoirSize()
        {
            return this._reservoirSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// Matches the ARN of the AWS resource on which the service runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=500)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property RuleARN. 
        /// <para>
        /// The ARN of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        public string RuleARN
        {
            get { return this._ruleARN; }
            set { this._ruleARN = value; }
        }

        // Check to see if RuleARN property is set
        internal bool IsSetRuleARN()
        {
            return this._ruleARN != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the sampling rule. Specify a rule by either name or ARN, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// Matches the <code>name</code> that the service uses to identify itself in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// Matches the <code>origin</code> that the service uses to identify its type in segments.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        // Check to see if ServiceType property is set
        internal bool IsSetServiceType()
        {
            return this._serviceType != null;
        }

        /// <summary>
        /// Gets and sets the property URLPath. 
        /// <para>
        /// Matches the path from a request URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string URLPath
        {
            get { return this._urlPath; }
            set { this._urlPath = value; }
        }

        // Check to see if URLPath property is set
        internal bool IsSetURLPath()
        {
            return this._urlPath != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the sampling rule format (<code>1</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}