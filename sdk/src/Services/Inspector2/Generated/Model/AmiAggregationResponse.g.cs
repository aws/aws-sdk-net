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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a finding aggregation by AMI.
    /// </summary>
    public partial class AmiAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AffectedInstances. 
        /// <para>
        /// The IDs of Amazon EC2 instances using this AMI.
        /// </para>
        /// </summary>
        public long? AffectedInstances { get; set; }

        /// <summary>
        /// Checks to see if the AffectedInstances property is set.
        /// </summary>
        internal bool IsSetAffectedInstances() => this.AffectedInstances.HasValue;

        /// <summary>
        /// Gets and sets the property Ami. 
        /// <para>
        /// The ID of the AMI that findings were aggregated for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Ami { get; set; }

        /// <summary>
        /// Checks to see if the Ami property is set.
        /// </summary>
        internal bool IsSetAmi() => this.Ami != null;

        /// <summary>
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the AMI aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CloudAccountId property is set.
        /// </summary>
        internal bool IsSetCloudAccountId() => this.CloudAccountId != null;

        /// <summary>
        /// Gets and sets the property CloudOrgId. 
        /// <para>
        /// The cloud organization ID for the AMI aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string CloudOrgId { get; set; }

        /// <summary>
        /// Checks to see if the CloudOrgId property is set.
        /// </summary>
        internal bool IsSetCloudOrgId() => this.CloudOrgId != null;

        /// <summary>
        /// Gets and sets the property CloudPartition. 
        /// <para>
        /// The cloud infrastructure partition associated with this AMI aggregation. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CloudPartition { get; set; }

        /// <summary>
        /// Checks to see if the CloudPartition property is set.
        /// </summary>
        internal bool IsSetCloudPartition() => this.CloudPartition != null;

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud service provider associated with this Amazon Machine Image (AMI) aggregation.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Provider CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property CloudRegion. 
        /// <para>
        /// The cloud Region associated with this AMI aggregation. The value format depends on
        /// the cloud provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CloudRegion { get; set; }

        /// <summary>
        /// Checks to see if the CloudRegion property is set.
        /// </summary>
        internal bool IsSetCloudRegion() => this.CloudRegion != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts. 
        /// <para>
        /// An object that contains the count of matched findings per severity.
        /// </para>
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}
