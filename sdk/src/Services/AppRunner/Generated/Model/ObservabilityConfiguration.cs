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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes an App Runner observability configuration resource. Multiple revisions of
    /// a configuration have the same <c>ObservabilityConfigurationName</c> and different
    /// <c>ObservabilityConfigurationRevision</c> values.
    /// 
    ///  
    /// <para>
    /// The resource is designed to configure multiple features (currently one feature, tracing).
    /// This type contains optional members that describe the configuration of these features
    /// (currently one member, <c>TraceConfiguration</c>). If a feature member isn't specified,
    /// the feature isn't enabled.
    /// </para>
    /// </summary>
    public partial class ObservabilityConfiguration
    {
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private bool? _latest;
        private string _observabilityConfigurationArn;
        private string _observabilityConfigurationName;
        private int? _observabilityConfigurationRevision;
        private ObservabilityConfigurationStatus _status;
        private TraceConfiguration _traceConfiguration;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the observability configuration was created. It's in Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the observability configuration was deleted. It's in Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Latest. 
        /// <para>
        /// It's set to <c>true</c> for the configuration with the highest <c>Revision</c> among
        /// all configurations that share the same <c>ObservabilityConfigurationName</c>. It's
        /// set to <c>false</c> otherwise.
        /// </para>
        /// </summary>
        public bool? Latest
        {
            get { return this._latest; }
            set { this._latest = value; }
        }

        // Check to see if Latest property is set
        internal bool IsSetLatest()
        {
            return this._latest.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this observability configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ObservabilityConfigurationArn
        {
            get { return this._observabilityConfigurationArn; }
            set { this._observabilityConfigurationArn = value; }
        }

        // Check to see if ObservabilityConfigurationArn property is set
        internal bool IsSetObservabilityConfigurationArn()
        {
            return this._observabilityConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationName. 
        /// <para>
        /// The customer-provided observability configuration name. It can be used in multiple
        /// revisions of a configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=32)]
        public string ObservabilityConfigurationName
        {
            get { return this._observabilityConfigurationName; }
            set { this._observabilityConfigurationName = value; }
        }

        // Check to see if ObservabilityConfigurationName property is set
        internal bool IsSetObservabilityConfigurationName()
        {
            return this._observabilityConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationRevision. 
        /// <para>
        /// The revision of this observability configuration. It's unique among all the active
        /// configurations (<c>"Status": "ACTIVE"</c>) that share the same <c>ObservabilityConfigurationName</c>.
        /// </para>
        /// </summary>
        public int? ObservabilityConfigurationRevision
        {
            get { return this._observabilityConfigurationRevision; }
            set { this._observabilityConfigurationRevision = value; }
        }

        // Check to see if ObservabilityConfigurationRevision property is set
        internal bool IsSetObservabilityConfigurationRevision()
        {
            return this._observabilityConfigurationRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the observability configuration. If the status of a configuration
        /// revision is <c>INACTIVE</c>, it was deleted and can't be used. Inactive configuration
        /// revisions are permanently removed some time after they are deleted.
        /// </para>
        /// </summary>
        public ObservabilityConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TraceConfiguration. 
        /// <para>
        /// The configuration of the tracing feature within this observability configuration.
        /// If not specified, tracing isn't enabled.
        /// </para>
        /// </summary>
        public TraceConfiguration TraceConfiguration
        {
            get { return this._traceConfiguration; }
            set { this._traceConfiguration = value; }
        }

        // Check to see if TraceConfiguration property is set
        internal bool IsSetTraceConfiguration()
        {
            return this._traceConfiguration != null;
        }

    }
}