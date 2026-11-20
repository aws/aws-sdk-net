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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A Change Guardrail and its status. A Change Guardrail checks each change to the records
    /// in a hosted zone, and rejects the change if the check fails.
    /// 
    ///  
    /// <para>
    /// When you submit a <c>ChangeResourceRecordSets</c> request, Route 53 checks each change
    /// against every guardrail that is turned on. If a check fails, Route 53 rejects the
    /// whole request and returns an error that identifies the guardrail. If every check passes,
    /// Route 53 applies the changes.
    /// </para>
    ///  
    /// <para>
    /// For example, suppose that <c>ALIAS_TARGET_CHECK</c> is turned on, and an alias record
    /// points to <c>www.example.com</c>. If you try to delete <c>www.example.com</c>, Route
    /// 53 rejects the request. To delete the record, first delete or change the alias record.
    /// </para>
    /// </summary>
    public partial class ChangeGuardrail
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the guardrail. Valid values are the following:
        /// </para>
        ///  <dl> <dt>NS_FORMAT_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects an NS record whose value looks like a Route 53 name server
        /// but isn't one.
        /// </para>
        ///  </dd> <dt>NS_DELEGATION_AUTHORITY_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects an NS record that delegates a subdomain to Route 53 name servers
        /// that don't host it.
        /// </para>
        ///  
        /// <para>
        /// This guardrail applies only to public hosted zones.
        /// </para>
        ///  </dd> <dt>NS_OCCLUSION_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects a change that leaves records under a delegated subdomain, where
        /// resolvers never use them.
        /// </para>
        ///  </dd> <dt>ALIAS_TARGET_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects deleting a record that an alias record in the same hosted zone
        /// points to.
        /// </para>
        ///  </dd> <dt>ACTIVE_RECORD_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects deleting a record that still receives DNS queries, if no other
        /// record with the same name and type remains to answer them.
        /// </para>
        ///  </dd> <dt>ACTIVE_DELEGATION_CHECK</dt> <dd> 
        /// <para>
        /// This guardrail rejects deleting the NS record for a subdomain while resolvers are
        /// still referred to it.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// The tier of the hosted zone determines which guardrails it includes and which ones
        /// you can turn on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeGuardrailName Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the guardrail. Valid values are the following:
        /// </para>
        ///  <dl> <dt>ENABLED</dt> <dd> 
        /// <para>
        ///  <c>ENABLED</c> means that the guardrail is turned on.
        /// </para>
        ///  </dd> <dt>DISABLED</dt> <dd> 
        /// <para>
        ///  <c>DISABLED</c> means that the guardrail is turned off.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeGuardrailStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
