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
    /// Describes the observability configuration of an App Runner service. These are additional
    /// observability features, like tracing, that you choose to enable. They're configured
    /// in a separate resource that you associate with your service.
    /// </summary>
    public partial class ServiceObservabilityConfiguration
    {
        private string _observabilityConfigurationArn;
        private bool? _observabilityEnabled;

        /// <summary>
        /// Gets and sets the property ObservabilityConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the observability configuration that is associated
        /// with the service. Specified only when <c>ObservabilityEnabled</c> is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Specify an ARN with a name and a revision number to associate that revision. For example:
        /// <c>arn:aws:apprunner:us-east-1:123456789012:observabilityconfiguration/xray-tracing/3</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify just the name to associate the latest revision. For example: <c>arn:aws:apprunner:us-east-1:123456789012:observabilityconfiguration/xray-tracing</c>
        /// 
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
        /// Gets and sets the property ObservabilityEnabled. 
        /// <para>
        /// When <c>true</c>, an observability configuration resource is associated with the service,
        /// and an <c>ObservabilityConfigurationArn</c> is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ObservabilityEnabled
        {
            get { return this._observabilityEnabled; }
            set { this._observabilityEnabled = value; }
        }

        // Check to see if ObservabilityEnabled property is set
        internal bool IsSetObservabilityEnabled()
        {
            return this._observabilityEnabled.HasValue; 
        }

    }
}