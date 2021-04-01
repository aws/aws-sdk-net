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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Defines an association between Amazon Kinesis Data Firehose destinations and a web
    /// ACL resource, for logging from AWS WAF. As part of the association, you can specify
    /// parts of the standard logging fields to keep out of the logs and you can specify filters
    /// so that you log only a subset of the logging records.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private List<string> _logDestinationConfigs = new List<string>();
        private LoggingFilter _loggingFilter;
        private bool? _managedByFirewallManager;
        private List<FieldToMatch> _redactedFields = new List<FieldToMatch>();
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property LogDestinationConfigs. 
        /// <para>
        /// The Amazon Kinesis Data Firehose Amazon Resource Name (ARNs) that you want to associate
        /// with the web ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> LogDestinationConfigs
        {
            get { return this._logDestinationConfigs; }
            set { this._logDestinationConfigs = value; }
        }

        // Check to see if LogDestinationConfigs property is set
        internal bool IsSetLogDestinationConfigs()
        {
            return this._logDestinationConfigs != null && this._logDestinationConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoggingFilter. 
        /// <para>
        /// Filtering that specifies which web requests are kept in the logs and which are dropped.
        /// You can filter on the rule action and on the web request labels that were applied
        /// by matching rules during web ACL evaluation. 
        /// </para>
        /// </summary>
        public LoggingFilter LoggingFilter
        {
            get { return this._loggingFilter; }
            set { this._loggingFilter = value; }
        }

        // Check to see if LoggingFilter property is set
        internal bool IsSetLoggingFilter()
        {
            return this._loggingFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedByFirewallManager. 
        /// <para>
        /// Indicates whether the logging configuration was created by AWS Firewall Manager, as
        /// part of an AWS WAF policy configuration. If true, only Firewall Manager can modify
        /// or delete the configuration. 
        /// </para>
        /// </summary>
        public bool ManagedByFirewallManager
        {
            get { return this._managedByFirewallManager.GetValueOrDefault(); }
            set { this._managedByFirewallManager = value; }
        }

        // Check to see if ManagedByFirewallManager property is set
        internal bool IsSetManagedByFirewallManager()
        {
            return this._managedByFirewallManager.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RedactedFields. 
        /// <para>
        /// The parts of the request that you want to keep out of the logs. For example, if you
        /// redact the <code>HEADER</code> field, the <code>HEADER</code> field in the firehose
        /// will be <code>xxx</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must use one of the following values: <code>URI</code>, <code>QUERY_STRING</code>,
        /// <code>HEADER</code>, or <code>METHOD</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FieldToMatch> RedactedFields
        {
            get { return this._redactedFields; }
            set { this._redactedFields = value; }
        }

        // Check to see if RedactedFields property is set
        internal bool IsSetRedactedFields()
        {
            return this._redactedFields != null && this._redactedFields.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with <code>LogDestinationConfigs</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}