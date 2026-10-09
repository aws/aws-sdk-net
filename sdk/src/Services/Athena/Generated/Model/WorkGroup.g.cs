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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// A workgroup, which contains a name, description, creation time, state, and other configuration,
    /// listed under <a>WorkGroup$Configuration</a>. Each workgroup enables you to isolate
    /// queries for you or your group of users from other queries in the same account, to
    /// configure the query results location and the encryption configuration (known as workgroup
    /// settings), to enable sending query metrics to Amazon CloudWatch, and to establish
    /// per-query data usage control limits for all queries in a workgroup. The workgroup
    /// settings override is specified in <c>EnforceWorkGroupConfiguration</c> (true/false)
    /// in the <c>WorkGroupConfiguration</c>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
    /// </summary>
    public partial class WorkGroup
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the workgroup, which includes the location in Amazon S3 where
        /// query and calculation results are stored, the encryption configuration, if any, used
        /// for query and calculation results; whether the Amazon CloudWatch Metrics are enabled
        /// for the workgroup; whether workgroup settings override client-side settings; and the
        /// data usage limits for the amount of data scanned per query or per workgroup. The workgroup
        /// settings override is specified in <c>EnforceWorkGroupConfiguration</c> (true/false)
        /// in the <c>WorkGroupConfiguration</c>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public WorkGroupConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the workgroup was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The workgroup description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The ARN of the IAM Identity Center enabled application associated with the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string IdentityCenterApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterApplicationArn() => this.IdentityCenterApplicationArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The workgroup name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the workgroup: ENABLED or DISABLED.
        /// </para>
        /// </summary>
        public WorkGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
