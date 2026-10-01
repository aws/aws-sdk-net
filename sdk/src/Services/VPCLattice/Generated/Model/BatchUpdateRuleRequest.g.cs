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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateRule operation. Updates the listener
    /// rules in a batch. You can use this operation to change the priority of listener rules.
    /// This can be useful when bulk updating or swapping rule priority. <para> <b>Required
    /// permissions:</b> <c>vpc-lattice:UpdateRule</c> </para> <para> For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc-lattice/latest/ug/security_iam_service-with-iam.html">How
    /// Amazon VPC Lattice works with IAM</a> in the <i>Amazon VPC Lattice User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchUpdateRuleRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property ListenerIdentifier. 
        /// <para>
        /// The ID or ARN of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ListenerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ListenerIdentifier property is set.
        /// </summary>
        internal bool IsSetListenerIdentifier() => this.ListenerIdentifier != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The rules for the specified listener.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<RuleUpdate> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleUpdate>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;
    }
}
