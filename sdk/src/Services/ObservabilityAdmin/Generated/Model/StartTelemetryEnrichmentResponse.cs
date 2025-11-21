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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the StartTelemetryEnrichment operation.
    /// </summary>
    public partial class StartTelemetryEnrichmentResponse : AmazonWebServiceResponse
    {
        private string _awsResourceExplorerManagedViewArn;
        private TelemetryEnrichmentStatus _status;

        /// <summary>
        /// Gets and sets the property AwsResourceExplorerManagedViewArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Amazon Web Services Resource Explorer managed
        /// view created for resource tags for telemetry. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AwsResourceExplorerManagedViewArn
        {
            get { return this._awsResourceExplorerManagedViewArn; }
            set { this._awsResourceExplorerManagedViewArn = value; }
        }

        // Check to see if AwsResourceExplorerManagedViewArn property is set
        internal bool IsSetAwsResourceExplorerManagedViewArn()
        {
            return this._awsResourceExplorerManagedViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the resource tags for telemetry feature after the start operation (<c>Running</c>,
        /// <c>Stopped</c>, or <c>Impaired</c>). 
        /// </para>
        /// </summary>
        public TelemetryEnrichmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}