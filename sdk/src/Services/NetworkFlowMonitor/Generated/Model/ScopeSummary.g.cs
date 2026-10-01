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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A summary of information about a scope, including the ARN, target ID, and Amazon Web
    /// Services Region.
    /// </summary>
    public partial class ScopeSummary
    {
        /// <summary>
        /// Gets and sets the property ScopeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ScopeArn { get; set; }

        /// <summary>
        /// Checks to see if the ScopeArn property is set.
        /// </summary>
        internal bool IsSetScopeArn() => this.ScopeArn != null;

        /// <summary>
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The identifier for the scope that includes the resources that you want to get data
        /// results for. A scope ID is an internally-generated identifier that includes all the
        /// resources for the accounts in a scope.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScopeId { get; set; }

        /// <summary>
        /// Checks to see if the ScopeId property is set.
        /// </summary>
        internal bool IsSetScopeId() => this.ScopeId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for a scope. The status can be one of the following: <c>SUCCEEDED</c>,
        /// <c>IN_PROGRESS</c>, <c>FAILED</c>, <c>DEACTIVATING</c>, or <c>DEACTIVATED</c>.
        /// </para>
        ///  
        /// <para>
        /// A status of <c>DEACTIVATING</c> means that you've requested a scope to be deactivated
        /// and Network Flow Monitor is in the process of deactivating the scope. A status of
        /// <c>DEACTIVATED</c> means that the deactivating process is complete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScopeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
